namespace SteamTool
{
    partial class ConfigManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_src = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_dst = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_configcp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_gameid = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "源配置文件：";
            // 
            // comboBox_src
            // 
            this.comboBox_src.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_src.FormattingEnabled = true;
            this.comboBox_src.Location = new System.Drawing.Point(122, 33);
            this.comboBox_src.Name = "comboBox_src";
            this.comboBox_src.Size = new System.Drawing.Size(245, 20);
            this.comboBox_src.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox_src);
            this.panel1.Location = new System.Drawing.Point(20, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 92);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox_dst);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(20, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 81);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(25, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "目标置文件：";
            // 
            // comboBox_dst
            // 
            this.comboBox_dst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dst.FormattingEnabled = true;
            this.comboBox_dst.Location = new System.Drawing.Point(122, 35);
            this.comboBox_dst.Name = "comboBox_dst";
            this.comboBox_dst.Size = new System.Drawing.Size(245, 20);
            this.comboBox_dst.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox_gameid);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.button_configcp);
            this.panel3.Location = new System.Drawing.Point(403, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(107, 204);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button_configcp
            // 
            this.button_configcp.Location = new System.Drawing.Point(18, 123);
            this.button_configcp.Name = "button_configcp";
            this.button_configcp.Size = new System.Drawing.Size(72, 23);
            this.button_configcp.TabIndex = 1;
            this.button_configcp.Text = "覆盖";
            this.button_configcp.UseVisualStyleBackColor = true;
            this.button_configcp.Click += new System.EventHandler(this.button_configcp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(26, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "游戏ID";
            // 
            // textBox_gameid
            // 
            this.textBox_gameid.Location = new System.Drawing.Point(18, 70);
            this.textBox_gameid.Name = "textBox_gameid";
            this.textBox_gameid.Size = new System.Drawing.Size(72, 21);
            this.textBox_gameid.TabIndex = 3;
            this.textBox_gameid.Text = "730";
            // 
            // ConfigManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 254);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ConfigManager";
            this.Text = "ConfigManager";
            this.Load += new System.EventHandler(this.ConfigManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_src;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_dst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_configcp;
        private System.Windows.Forms.TextBox textBox_gameid;
        private System.Windows.Forms.Label label3;
    }
}