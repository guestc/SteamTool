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
using System.Diagnostics;
using Microsoft.Win32;

namespace SteamTool
{
    public partial class AccountsManager : Form
    {
        private MainForm mainForm;
        public AccountsManager(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vdf v = new Vdf(mainForm.SteamPath+"\\config\\loginusers.vdf");
            Dictionary<string, SteamUserInfo> data = v.get();
            int index = 0;
            foreach (SteamUserInfo user in data.Values) {
                listBox_account.Items.Insert(index,user.user);
                listBox_steamname.Items.Insert(index, user.name);
                index++;
            }
            MessageBox.Show("加载完毕!");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            mainForm.panel_Paint(e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            mainForm.panel_Paint(e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            mainForm.panel_Paint(e);
        }

        private void listBox_account_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox_steamname.SelectedIndex = listBox_account.SelectedIndex;
        }

        private void listBox_steamname_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_account.SelectedIndex = listBox_steamname.SelectedIndex;
        }

        private void bt_accountswitch_Click(object sender, EventArgs e)
        {
            if (listBox_account.SelectedIndex == -1)
            {
                MessageBox.Show("请选择一个账号!");
            }
            RegistryKey key = Registry.CurrentUser;
            RegistryKey user = key.OpenSubKey(@"SOFTWARE\\Valve\\Steam", true);
            string username = listBox_account.SelectedItem.ToString();
            Console.WriteLine(username);
            user.SetValue("AutoLoginUser", username);
            MessageBox.Show("切换成功，重启Steam即可");
        }

        private void AccountsManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mainForm.Visible = true;
        }
    }
}
