using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamTool
{
    public partial class InitForm : Form
    {

        MainForm mainForm = null;
        public InitForm(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (true) {
                openFileDialog1.ShowDialog();
                if (openFileDialog1.SafeFileName.Equals("Steam.exe")) break;
                MessageBox.Show("请选择Stean根目录下的Steam.exe文件");
            }
            if (mainForm == null) {
                MessageBox.Show("程序出错，找不到主窗体!");
                Application.Exit();
            }
            mainForm.SteamPath = openFileDialog1.FileName.Replace(openFileDialog1.SafeFileName, string.Empty);
            this.Close();
        }
    }
}
