namespace SteamTool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bt_accountmanager = new System.Windows.Forms.Button();
            this.bt_configmanager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_accountmanager
            // 
            this.bt_accountmanager.Location = new System.Drawing.Point(92, 37);
            this.bt_accountmanager.Name = "bt_accountmanager";
            this.bt_accountmanager.Size = new System.Drawing.Size(128, 33);
            this.bt_accountmanager.TabIndex = 0;
            this.bt_accountmanager.Text = "帐号切换管理";
            this.bt_accountmanager.UseVisualStyleBackColor = true;
            this.bt_accountmanager.Click += new System.EventHandler(this.bt_accountmanager_Click);
            // 
            // bt_configmanager
            // 
            this.bt_configmanager.Location = new System.Drawing.Point(92, 137);
            this.bt_configmanager.Name = "bt_configmanager";
            this.bt_configmanager.Size = new System.Drawing.Size(128, 32);
            this.bt_configmanager.TabIndex = 1;
            this.bt_configmanager.Text = "配置文件管理";
            this.bt_configmanager.UseVisualStyleBackColor = true;
            this.bt_configmanager.Click += new System.EventHandler(this.bt_configmanager_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 252);
            this.Controls.Add(this.bt_configmanager);
            this.Controls.Add(this.bt_accountmanager);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SteamTool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_accountmanager;
        private System.Windows.Forms.Button bt_configmanager;
    }
}