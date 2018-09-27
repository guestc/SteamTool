namespace SteamTool
{
    partial class AccountsManager
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_account = new System.Windows.Forms.ListBox();
            this.listBox_steamname = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_accountswitch = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listBox_account);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(17, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 203);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account";
            // 
            // listBox_account
            // 
            this.listBox_account.FormattingEnabled = true;
            this.listBox_account.ItemHeight = 12;
            this.listBox_account.Location = new System.Drawing.Point(0, 31);
            this.listBox_account.Name = "listBox_account";
            this.listBox_account.Size = new System.Drawing.Size(105, 172);
            this.listBox_account.TabIndex = 0;
            this.listBox_account.SelectedValueChanged += new System.EventHandler(this.listBox_account_SelectedValueChanged);
            // 
            // listBox_steamname
            // 
            this.listBox_steamname.FormattingEnabled = true;
            this.listBox_steamname.ItemHeight = 12;
            this.listBox_steamname.Location = new System.Drawing.Point(0, 31);
            this.listBox_steamname.Name = "listBox_steamname";
            this.listBox_steamname.Size = new System.Drawing.Size(161, 172);
            this.listBox_steamname.TabIndex = 1;
            this.listBox_steamname.SelectedIndexChanged += new System.EventHandler(this.listBox_steamname_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(52, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "SteamName";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.listBox_steamname);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(123, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(161, 203);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // bt_accountswitch
            // 
            this.bt_accountswitch.Location = new System.Drawing.Point(17, 264);
            this.bt_accountswitch.Name = "bt_accountswitch";
            this.bt_accountswitch.Size = new System.Drawing.Size(266, 23);
            this.bt_accountswitch.TabIndex = 4;
            this.bt_accountswitch.Text = "切换";
            this.bt_accountswitch.UseVisualStyleBackColor = true;
            this.bt_accountswitch.Click += new System.EventHandler(this.bt_accountswitch_Click);
            // 
            // AccountsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 345);
            this.Controls.Add(this.bt_accountswitch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "AccountsManager";
            this.ShowIcon = false;
            this.Text = "帐号管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountsManager_FormClosed);
            this.Load += new System.EventHandler(this.AccountsManager_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox_steamname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBox_account;
        private System.Windows.Forms.Button bt_accountswitch;
    }
}