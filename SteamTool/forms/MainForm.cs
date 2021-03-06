﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SteamTool.utils;

namespace SteamTool
{
    public partial class MainForm : Form
    {

        public string SteamPath = null;

        public MainForm()
        {
            InitializeComponent();
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Text = "SteamTool";
        }
        public void panel_Paint(PaintEventArgs ev)
        {
            ControlPaint.DrawBorder(ev.Graphics, ev.ClipRectangle,
                 Color.Black, 1, ButtonBorderStyle.Solid,
                 Color.Black, 1, ButtonBorderStyle.Solid,
                 Color.Black, 1, ButtonBorderStyle.Solid,
                 Color.Black, 1, ButtonBorderStyle.Solid);
        }

        private void bt_accountmanager_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AccountsManager am =  new AccountsManager(this);
            am.ShowDialog();
            
        }

        private void bt_configmanager_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConfigManager cm = new ConfigManager(this);
            cm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string conf_path = Application.StartupPath + "\\config.json";
            do {
                if (!File.Exists(conf_path))
                {
                    //获取路径
                    InitForm f = new InitForm(this);
                    f.ShowDialog();
                    FileStream fs = File.OpenWrite(conf_path);
                    fs.Close();
                }
                JConfig jc = new JConfig(conf_path);
                string path = jc.get("steampath");
                if (path == null) { jc.set("steampath", SteamPath); }
                SteamPath = path;
            } while (SteamPath == null);
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string selected = e.ClickedItem.Text;
            switch (selected)
            {

                case "显示":
                    this.Visible = true;
                    break;


                case "隐藏":
                    this.Visible = false;
                    break;


                case "退出":
                    Application.ExitThread();
                    break;

            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) e.Cancel = true;
            this.Visible = false;
        }
    }
}
