namespace Autoentity
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Tools = new System.Windows.Forms.MenuStrip();
            this.连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LinkInfo_TreeView = new System.Windows.Forms.TreeView();
            this.TreeNode_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.生成所有ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除此连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.预览生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加载表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SetCus_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GetCus_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Namespace_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CusAttr_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SqlSugarBZL_CheckBox = new System.Windows.Forms.CheckBox();
            this.SqlSugarPK_CheckBox = new System.Windows.Forms.CheckBox();
            this.PropDefault_CheckBox = new System.Windows.Forms.CheckBox();
            this.PropTrim_CheckBox = new System.Windows.Forms.CheckBox();
            this.PropCapsCount_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.TableCapsCount_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.BaseClass_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Using_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UsingTip = new System.Windows.Forms.ToolTip(this.components);
            this.SqlServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MySQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OracleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SQLiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PostgreSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools.SuspendLayout();
            this.TreeNode_ContextMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropCapsCount_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableCapsCount_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Tools
            // 
            this.Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.连接ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.Tools.Location = new System.Drawing.Point(0, 0);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(1057, 25);
            this.Tools.TabIndex = 0;
            this.Tools.Text = "menuStrip1";
            // 
            // 连接ToolStripMenuItem
            // 
            this.连接ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SqlServerToolStripMenuItem,
            this.MySQLToolStripMenuItem,
            this.OracleToolStripMenuItem,
            this.SQLiteToolStripMenuItem,
            this.PostgreSQLToolStripMenuItem});
            this.连接ToolStripMenuItem.Name = "连接ToolStripMenuItem";
            this.连接ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.连接ToolStripMenuItem.Text = "连接";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // LinkInfo_TreeView
            // 
            this.LinkInfo_TreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LinkInfo_TreeView.ContextMenuStrip = this.TreeNode_ContextMenuStrip;
            this.LinkInfo_TreeView.Location = new System.Drawing.Point(12, 28);
            this.LinkInfo_TreeView.Name = "LinkInfo_TreeView";
            this.LinkInfo_TreeView.Size = new System.Drawing.Size(179, 710);
            this.LinkInfo_TreeView.TabIndex = 1;
            this.LinkInfo_TreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.LinkInfo_TreeView_NodeMouseDoubleClick);
            // 
            // TreeNode_ContextMenuStrip
            // 
            this.TreeNode_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.生成所有ToolStripMenuItem,
            this.删除此连接ToolStripMenuItem,
            this.预览生成ToolStripMenuItem,
            this.加载表ToolStripMenuItem});
            this.TreeNode_ContextMenuStrip.Name = "TreeNode_ContextMenuStrip";
            this.TreeNode_ContextMenuStrip.Size = new System.Drawing.Size(137, 92);
            // 
            // 生成所有ToolStripMenuItem
            // 
            this.生成所有ToolStripMenuItem.Name = "生成所有ToolStripMenuItem";
            this.生成所有ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.生成所有ToolStripMenuItem.Text = "生成所有";
            this.生成所有ToolStripMenuItem.Click += new System.EventHandler(this.生成所有ToolStripMenuItem_Click);
            // 
            // 删除此连接ToolStripMenuItem
            // 
            this.删除此连接ToolStripMenuItem.Name = "删除此连接ToolStripMenuItem";
            this.删除此连接ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.删除此连接ToolStripMenuItem.Text = "删除此连接";
            this.删除此连接ToolStripMenuItem.Click += new System.EventHandler(this.删除此连接ToolStripMenuItem_Click);
            // 
            // 预览生成ToolStripMenuItem
            // 
            this.预览生成ToolStripMenuItem.Name = "预览生成ToolStripMenuItem";
            this.预览生成ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.预览生成ToolStripMenuItem.Text = "预览生成";
            this.预览生成ToolStripMenuItem.Click += new System.EventHandler(this.预览生成ToolStripMenuItem_Click);
            // 
            // 加载表ToolStripMenuItem
            // 
            this.加载表ToolStripMenuItem.Name = "加载表ToolStripMenuItem";
            this.加载表ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.加载表ToolStripMenuItem.Text = "加载表";
            this.加载表ToolStripMenuItem.Click += new System.EventHandler(this.加载表ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SetCus_TextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.GetCus_TextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Namespace_TextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CusAttr_TextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SqlSugarBZL_CheckBox);
            this.groupBox1.Controls.Add(this.SqlSugarPK_CheckBox);
            this.groupBox1.Controls.Add(this.PropDefault_CheckBox);
            this.groupBox1.Controls.Add(this.PropTrim_CheckBox);
            this.groupBox1.Controls.Add(this.PropCapsCount_NumericUpDown);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TableCapsCount_NumericUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BaseClass_TextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Using_TextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(197, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 205);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // SetCus_TextBox
            // 
            this.SetCus_TextBox.Location = new System.Drawing.Point(490, 175);
            this.SetCus_TextBox.Name = "SetCus_TextBox";
            this.SetCus_TextBox.Size = new System.Drawing.Size(327, 21);
            this.SetCus_TextBox.TabIndex = 20;
            this.SetCus_TextBox.Text = "this._属性 = -value-;";
            this.SetCus_TextBox.MouseHover += new System.EventHandler(this.SetCus_TextBox_MouseHover);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "set自定义: ";
            // 
            // GetCus_TextBox
            // 
            this.GetCus_TextBox.Location = new System.Drawing.Point(107, 175);
            this.GetCus_TextBox.Name = "GetCus_TextBox";
            this.GetCus_TextBox.Size = new System.Drawing.Size(276, 21);
            this.GetCus_TextBox.TabIndex = 18;
            this.GetCus_TextBox.Text = "return this._属性;";
            this.GetCus_TextBox.MouseHover += new System.EventHandler(this.GetCus_TextBox_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "get自定义格式: ";
            // 
            // Namespace_TextBox
            // 
            this.Namespace_TextBox.Location = new System.Drawing.Point(675, 17);
            this.Namespace_TextBox.Name = "Namespace_TextBox";
            this.Namespace_TextBox.Size = new System.Drawing.Size(142, 21);
            this.Namespace_TextBox.TabIndex = 16;
            this.Namespace_TextBox.Text = "Entity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(604, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "命名空间: ";
            // 
            // CusAttr_TextBox
            // 
            this.CusAttr_TextBox.Location = new System.Drawing.Point(532, 136);
            this.CusAttr_TextBox.Name = "CusAttr_TextBox";
            this.CusAttr_TextBox.Size = new System.Drawing.Size(285, 21);
            this.CusAttr_TextBox.TabIndex = 14;
            this.CusAttr_TextBox.MouseHover += new System.EventHandler(this.CusAttr_TextBox_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "自定义实体类特性: ";
            // 
            // SqlSugarBZL_CheckBox
            // 
            this.SqlSugarBZL_CheckBox.AutoSize = true;
            this.SqlSugarBZL_CheckBox.Location = new System.Drawing.Point(203, 138);
            this.SqlSugarBZL_CheckBox.Name = "SqlSugarBZL_CheckBox";
            this.SqlSugarBZL_CheckBox.Size = new System.Drawing.Size(180, 16);
            this.SqlSugarBZL_CheckBox.TabIndex = 12;
            this.SqlSugarBZL_CheckBox.Text = "使用SqlSugar特性标识标识列";
            this.SqlSugarBZL_CheckBox.UseVisualStyleBackColor = true;
            // 
            // SqlSugarPK_CheckBox
            // 
            this.SqlSugarPK_CheckBox.AutoSize = true;
            this.SqlSugarPK_CheckBox.Location = new System.Drawing.Point(8, 139);
            this.SqlSugarPK_CheckBox.Name = "SqlSugarPK_CheckBox";
            this.SqlSugarPK_CheckBox.Size = new System.Drawing.Size(168, 16);
            this.SqlSugarPK_CheckBox.TabIndex = 11;
            this.SqlSugarPK_CheckBox.Text = "使用SqlSugar特性标识主键";
            this.SqlSugarPK_CheckBox.UseVisualStyleBackColor = true;
            // 
            // PropDefault_CheckBox
            // 
            this.PropDefault_CheckBox.AutoSize = true;
            this.PropDefault_CheckBox.Location = new System.Drawing.Point(203, 106);
            this.PropDefault_CheckBox.Name = "PropDefault_CheckBox";
            this.PropDefault_CheckBox.Size = new System.Drawing.Size(438, 16);
            this.PropDefault_CheckBox.TabIndex = 10;
            this.PropDefault_CheckBox.Text = "值类型属性为Null返回默认值, 如bool?为null的时候, set的时候会变成False";
            this.PropDefault_CheckBox.UseVisualStyleBackColor = true;
            // 
            // PropTrim_CheckBox
            // 
            this.PropTrim_CheckBox.AutoSize = true;
            this.PropTrim_CheckBox.Location = new System.Drawing.Point(8, 106);
            this.PropTrim_CheckBox.Name = "PropTrim_CheckBox";
            this.PropTrim_CheckBox.Size = new System.Drawing.Size(144, 16);
            this.PropTrim_CheckBox.TabIndex = 9;
            this.PropTrim_CheckBox.Text = "String属性去首尾空格";
            this.PropTrim_CheckBox.UseVisualStyleBackColor = true;
            // 
            // PropCapsCount_NumericUpDown
            // 
            this.PropCapsCount_NumericUpDown.Location = new System.Drawing.Point(745, 63);
            this.PropCapsCount_NumericUpDown.Name = "PropCapsCount_NumericUpDown";
            this.PropCapsCount_NumericUpDown.Size = new System.Drawing.Size(72, 21);
            this.PropCapsCount_NumericUpDown.TabIndex = 7;
            this.PropCapsCount_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "属性开头字母大写个数: ";
            // 
            // TableCapsCount_NumericUpDown
            // 
            this.TableCapsCount_NumericUpDown.Location = new System.Drawing.Point(510, 63);
            this.TableCapsCount_NumericUpDown.Name = "TableCapsCount_NumericUpDown";
            this.TableCapsCount_NumericUpDown.Size = new System.Drawing.Size(72, 21);
            this.TableCapsCount_NumericUpDown.TabIndex = 5;
            this.TableCapsCount_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "表名开头字母大写个数: ";
            // 
            // BaseClass_TextBox
            // 
            this.BaseClass_TextBox.Location = new System.Drawing.Point(450, 17);
            this.BaseClass_TextBox.Name = "BaseClass_TextBox";
            this.BaseClass_TextBox.Size = new System.Drawing.Size(132, 21);
            this.BaseClass_TextBox.TabIndex = 3;
            this.BaseClass_TextBox.MouseHover += new System.EventHandler(this.BaseClass_TextBox_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "继承的父类: ";
            // 
            // Using_TextBox
            // 
            this.Using_TextBox.Location = new System.Drawing.Point(101, 20);
            this.Using_TextBox.Multiline = true;
            this.Using_TextBox.Name = "Using_TextBox";
            this.Using_TextBox.Size = new System.Drawing.Size(248, 74);
            this.Using_TextBox.TabIndex = 1;
            this.Using_TextBox.MouseHover += new System.EventHandler(this.Using_TextBox_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "导入命名空间: ";
            // 
            // SqlServerToolStripMenuItem
            // 
            this.SqlServerToolStripMenuItem.Image = global::Autoentity.Properties.Resources.dbs_sqlserver_32px_1097092_easyicon_net;
            this.SqlServerToolStripMenuItem.Name = "SqlServerToolStripMenuItem";
            this.SqlServerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SqlServerToolStripMenuItem.Text = "SQL Server";
            this.SqlServerToolStripMenuItem.Click += new System.EventHandler(this.SqlServerToolStripMenuItem_Click);
            // 
            // MySQLToolStripMenuItem
            // 
            this.MySQLToolStripMenuItem.Image = global::Autoentity.Properties.Resources.mysql;
            this.MySQLToolStripMenuItem.Name = "MySQLToolStripMenuItem";
            this.MySQLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MySQLToolStripMenuItem.Text = "MySQL";
            this.MySQLToolStripMenuItem.Click += new System.EventHandler(this.MySQLToolStripMenuItem_Click);
            // 
            // OracleToolStripMenuItem
            // 
            this.OracleToolStripMenuItem.Image = global::Autoentity.Properties.Resources.Oracle;
            this.OracleToolStripMenuItem.Name = "OracleToolStripMenuItem";
            this.OracleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OracleToolStripMenuItem.Text = "Oracle";
            // 
            // SQLiteToolStripMenuItem
            // 
            this.SQLiteToolStripMenuItem.Image = global::Autoentity.Properties.Resources.dbs_sqlite_32px_1097091_easyicon_net;
            this.SQLiteToolStripMenuItem.Name = "SQLiteToolStripMenuItem";
            this.SQLiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SQLiteToolStripMenuItem.Text = "SQLite";
            // 
            // PostgreSQLToolStripMenuItem
            // 
            this.PostgreSQLToolStripMenuItem.Image = global::Autoentity.Properties.Resources.dbs_postgresql_32px_1097088_easyicon_net;
            this.PostgreSQLToolStripMenuItem.Name = "PostgreSQLToolStripMenuItem";
            this.PostgreSQLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PostgreSQLToolStripMenuItem.Text = "PostgreSQL";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LinkInfo_TreeView);
            this.Controls.Add(this.Tools);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Tools;
            this.MinimumSize = new System.Drawing.Size(1073, 789);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "大魔方 - 实体类生成器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            this.TreeNode_ContextMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropCapsCount_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableCapsCount_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Tools;
        private System.Windows.Forms.ToolStripMenuItem 连接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SqlServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MySQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OracleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SQLiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PostgreSQLToolStripMenuItem;
        private System.Windows.Forms.TreeView LinkInfo_TreeView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Using_TextBox;
        private System.Windows.Forms.ToolTip UsingTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BaseClass_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown TableCapsCount_NumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown PropCapsCount_NumericUpDown;
        private System.Windows.Forms.CheckBox PropTrim_CheckBox;
        private System.Windows.Forms.CheckBox PropDefault_CheckBox;
        private System.Windows.Forms.CheckBox SqlSugarPK_CheckBox;
        private System.Windows.Forms.CheckBox SqlSugarBZL_CheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CusAttr_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Namespace_TextBox;
        private System.Windows.Forms.TextBox GetCus_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SetCus_TextBox;
        private System.Windows.Forms.ContextMenuStrip TreeNode_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 生成所有ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除此连接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 预览生成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加载表ToolStripMenuItem;
    }
}

