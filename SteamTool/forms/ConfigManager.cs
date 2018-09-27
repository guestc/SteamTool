using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SteamTool.utils;
using System.IO;
namespace SteamTool
{
    public partial class ConfigManager : Form
    {
        private MainForm mainForm;

        private Dictionary<int, string> cache_data = new Dictionary<int, string>();
        public ConfigManager(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
        }


        private void ConfigManager_Load(object sender, EventArgs e)
        {
            Vdf v = new Vdf(mainForm.SteamPath + "\\config\\loginusers.vdf");
            Dictionary<string, SteamUserInfo> data = v.get();
            int index = 0;
            foreach (SteamUserInfo user in data.Values)
            {
                string str = user.user + " > " + user.name;
                cache_data.Add(index, user.id64);
                comboBox_dst.Items.Insert(index,str);
                comboBox_src.Items.Insert(index, str);
                index++;
            }
        }

        private void button_configcp_Click(object sender, EventArgs e)
        {
            if (comboBox_dst.SelectedIndex == -1 || comboBox_src.SelectedIndex == -1 || textBox_gameid.Text == "") {
                MessageBox.Show("设置有误，请检查!");
                return;
            }
            CoverConfig(comboBox_src.SelectedIndex, comboBox_dst.SelectedIndex, textBox_gameid.Text);
        }

        private void CoverConfig(int src, int dst, string gid) {
            int src_id = getSteamId3(cache_data[src]);
            int dst_id = getSteamId3(cache_data[dst]);
            string src_path = mainForm.SteamPath + "\\userdata\\" + src_id + "\\" + gid + "\\";
            string dst_path = mainForm.SteamPath + "\\userdata\\" + dst_id + "\\" + gid + "\\";
            removeDir(dst_path);
            MessageBox.Show( "已删除目标的配置文件!");
            CopyDir(src_path,dst_path);
            MessageBox.Show("覆盖完成!");

        }
        private void CopyDir(string src_path, string dst_path)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(src_path);
            if (!dirinfo.Exists)
            {
                MessageBox.Show("指定源帐号并没游戏ID为:" + textBox_gameid + " 的配置文件!");
                return;
            }
            FileSystemInfo[] fs = dirinfo.GetFileSystemInfos();
            foreach (FileSystemInfo f in fs)
            {
                Console.WriteLine("is dir=>" + (f is DirectoryInfo));
                if (f is DirectoryInfo)
                {
                    new DirectoryInfo(dst_path + "\\" + f.Name).Create();
                    CopyDir(f.FullName, dst_path + "\\" + f.Name);
                    Console.WriteLine(dst_path + "\\" + f.Name);
                }
                else {
                    FileInfo ff = new FileInfo(f.FullName);
                    ff.CopyTo(dst_path + "\\" + ff.Name);
                } 
            }
        }
        

        private void removeDir(string path) {
            DirectoryInfo dirinfo = new DirectoryInfo(path);
            if (!dirinfo.Exists) {
                dirinfo.Create();
                return;
            }
            FileSystemInfo[] fs = dirinfo.GetFileSystemInfos();
            foreach (FileSystemInfo f in fs) {
                if (f is DirectoryInfo) removeDir(f.FullName);
                f.Delete();
            }
        }
         

        public int getSteamId3(string str)
        {
            int rid = (int) long.Parse(str);
            int z = rid >> 1;
            int y = (rid & 1) == 1 ? 1 : 0;
            return z * 2 + y;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            mainForm.panel_Paint(e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            mainForm.panel_Paint(e);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            mainForm.panel_Paint(e);
        }

        private void ConfigManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mainForm.Visible = true;
        }
    }
}
