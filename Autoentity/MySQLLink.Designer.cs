namespace Autoentity
{
    partial class MySQLLink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MySQLLink));
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Account_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Host_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LinkName_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Port_TextBox = new System.Windows.Forms.TextBox();
            this.DataBase_ComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Test_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(83, 201);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(257, 21);
            this.Password_TextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "密码: ";
            // 
            // Account_TextBox
            // 
            this.Account_TextBox.Location = new System.Drawing.Point(83, 156);
            this.Account_TextBox.Name = "Account_TextBox";
            this.Account_TextBox.Size = new System.Drawing.Size(257, 21);
            this.Account_TextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "用户名: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "端口号: ";
            // 
            // Host_TextBox
            // 
            this.Host_TextBox.Location = new System.Drawing.Point(83, 65);
            this.Host_TextBox.Name = "Host_TextBox";
            this.Host_TextBox.Size = new System.Drawing.Size(257, 21);
            this.Host_TextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "主机地址: ";
            // 
            // LinkName_TextBox
            // 
            this.LinkName_TextBox.Location = new System.Drawing.Point(83, 20);
            this.LinkName_TextBox.Name = "LinkName_TextBox";
            this.LinkName_TextBox.Size = new System.Drawing.Size(257, 21);
            this.LinkName_TextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "连接名称: ";
            // 
            // Port_TextBox
            // 
            this.Port_TextBox.Location = new System.Drawing.Point(83, 109);
            this.Port_TextBox.Name = "Port_TextBox";
            this.Port_TextBox.Size = new System.Drawing.Size(257, 21);
            this.Port_TextBox.TabIndex = 3;
            this.Port_TextBox.Text = "3306";
            // 
            // DataBase_ComboBox
            // 
            this.DataBase_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBase_ComboBox.FormattingEnabled = true;
            this.DataBase_ComboBox.Location = new System.Drawing.Point(83, 239);
            this.DataBase_ComboBox.Name = "DataBase_ComboBox";
            this.DataBase_ComboBox.Size = new System.Drawing.Size(257, 20);
            this.DataBase_ComboBox.TabIndex = 19;
            this.DataBase_ComboBox.DropDown += new System.EventHandler(this.DataBase_ComboBox_DropDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "数据库: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.Test_Button);
            this.panel1.Controls.Add(this.Cancel_Button);
            this.panel1.Controls.Add(this.OK_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 34);
            this.panel1.TabIndex = 21;
            // 
            // Test_Button
            // 
            this.Test_Button.Location = new System.Drawing.Point(12, 6);
            this.Test_Button.Name = "Test_Button";
            this.Test_Button.Size = new System.Drawing.Size(75, 23);
            this.Test_Button.TabIndex = 7;
            this.Test_Button.Text = "连接测试";
            this.Test_Button.UseVisualStyleBackColor = true;
            this.Test_Button.Click += new System.EventHandler(this.Test_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(265, 6);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 9;
            this.Cancel_Button.Text = "取消";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(172, 6);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 8;
            this.OK_Button.Text = "确定";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // MySQLLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(352, 310);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataBase_ComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Port_TextBox);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Account_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Host_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LinkName_TextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(368, 349);
            this.MinimizeBox = false;
            this.Name = "MySQLLink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySQL - 新建连接";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Account_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Host_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LinkName_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Port_TextBox;
        private System.Windows.Forms.ComboBox DataBase_ComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Test_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button OK_Button;
    }
}