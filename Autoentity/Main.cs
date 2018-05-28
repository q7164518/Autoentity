using Autoentity.Tools;
using ICSharpCode.TextEditor.Document;
using System;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoentity
{
    public partial class Main : Form
    {
        /// <summary>
        /// 代码文本框
        /// </summary>
        private ICSharpCode.TextEditor.TextEditorControl Code_TextEditorControl;

        private MainInfoModel _MainInfoModel = new MainInfoModel();

        public Main()
        {
            InitializeComponent();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            DefaultHighlightingStrategy defaultHighlightingStrategy1 = new DefaultHighlightingStrategy();
            DefaultTextEditorProperties defaultTextEditorProperties1 = new DefaultTextEditorProperties();
            this.Code_TextEditorControl = new ICSharpCode.TextEditor.TextEditorControl
            {
                Anchor = (((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right))),
                Encoding = ((Encoding)(resources.GetObject("Code_TextEditorControl.Encoding"))),
                Location = new System.Drawing.Point(197, 239),
                Name = "Code_TextEditorControl",
                ShowEOLMarkers = true,
                ShowSpaces = true,
                ShowTabs = true,
                ShowVRuler = true,
                Size = new System.Drawing.Size(848, 499),
                TabIndex = 4,
                TextEditorProperties = defaultTextEditorProperties1
            };
            defaultHighlightingStrategy1.Extensions = new string[0];
            defaultTextEditorProperties1.AllowCaretBeyondEOL = false;
            defaultTextEditorProperties1.AutoInsertCurlyBracket = true;
            defaultTextEditorProperties1.BracketMatchingStyle = BracketMatchingStyle.After;
            defaultTextEditorProperties1.ConvertTabsToSpaces = false;
            defaultTextEditorProperties1.CreateBackupCopy = false;
            defaultTextEditorProperties1.DocumentSelectionMode = DocumentSelectionMode.Normal;
            defaultTextEditorProperties1.EnableFolding = true;
            defaultTextEditorProperties1.Encoding = ((System.Text.Encoding)(resources.GetObject("defaultTextEditorProperties1.Encoding")));
            defaultTextEditorProperties1.Font = new System.Drawing.Font("Courier New", 10F);
            defaultTextEditorProperties1.HideMouseCursor = false;
            defaultTextEditorProperties1.IndentStyle = IndentStyle.Smart;
            defaultTextEditorProperties1.IsIconBarVisible = true;
            defaultTextEditorProperties1.LineTerminator = "\r\n";
            defaultTextEditorProperties1.LineViewerStyle = LineViewerStyle.None;
            defaultTextEditorProperties1.MouseWheelScrollDown = true;
            defaultTextEditorProperties1.MouseWheelTextZoom = true;
            defaultTextEditorProperties1.ShowEOLMarker = true;
            defaultTextEditorProperties1.ShowHorizontalRuler = false;
            defaultTextEditorProperties1.ShowInvalidLines = true;
            defaultTextEditorProperties1.ShowLineNumbers = true;
            defaultTextEditorProperties1.ShowMatchingBracket = true;
            defaultTextEditorProperties1.ShowSpaces = true;
            defaultTextEditorProperties1.ShowTabs = true;
            defaultTextEditorProperties1.ShowVerticalRuler = true;
            defaultTextEditorProperties1.TabIndent = 4;
            defaultTextEditorProperties1.UseAntiAliasedFont = false;
            defaultTextEditorProperties1.UseCustomLine = false;
            defaultTextEditorProperties1.VerticalRulerRow = 80;
            this.Controls.Add(this.Code_TextEditorControl);
            this.Code_TextEditorControl.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy("C#");
            this.Code_TextEditorControl.Encoding = Encoding.Default;
        }

        /// <summary>
        /// 连接SQL Server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SqlServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sqlServerModel = new SQLServerLink(linkInfo =>
            {
                this.LinkInfo_TreeView.Nodes.Add(new TreeNode
                {
                    Name = linkInfo.LinkString,
                    Text = linkInfo.LinkName,
                    Tag = linkInfo.Type
                });
                this._MainInfoModel.LinkList.Add(linkInfo);
            }).ShowDialog();
        }

        /// <summary>
        /// 获得类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        Type GetTypeByString(string type)
        {
            switch (type.ToLower())
            {
                case "system.boolean":
                    return Type.GetType("System.Boolean", true, true);
                case "system.byte":
                    return Type.GetType("System.Byte", true, true);
                case "system.sbyte":
                    return Type.GetType("System.SByte", true, true);
                case "system.char":
                    return Type.GetType("System.Char", true, true);
                case "system.decimal":
                    return Type.GetType("System.Decimal", true, true);
                case "system.double":
                    return Type.GetType("System.Double", true, true);
                case "system.single":
                    return Type.GetType("System.Single", true, true);
                case "system.int32":
                    return Type.GetType("System.Int32", true, true);
                case "system.uint32":
                    return Type.GetType("System.UInt32", true, true);
                case "system.int64":
                    return Type.GetType("System.Int64", true, true);
                case "system.uint64":
                    return Type.GetType("System.UInt64", true, true);
                case "system.object":
                    return Type.GetType("System.Object", true, true);
                case "system.int16":
                    return Type.GetType("System.Int16", true, true);
                case "system.uint16":
                    return Type.GetType("System.UInt16", true, true);
                case "system.string":
                    return Type.GetType("System.String", true, true);
                case "system.datetime":
                case "datetime":
                    return Type.GetType("System.DateTime", true, true);
                case "system.guid":
                    return Type.GetType("System.Guid", true, true);
                default:
                    return Type.GetType(type, true, true);
            }
        }

        /// <summary>
        /// 双击节点, 查询所有表信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void LinkInfo_TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent == null)
            {
                void Tables()
                {
                    this.Invoke(new Action(() => LoadingTables(e.Node)));
                }

                await Task.Run(() => Tables());
            }
            else
            {
                void CodeByText()
                {
                    this.Invoke(new Action(() => this.Code_TextEditorControl.Text = this.GetEntityCode(e.Node)));
                }

                this.Code_TextEditorControl.Text = "正在生成...";
                await Task.Run(() => CodeByText());
            }
        }

        /// <summary>
        /// 加载所有表
        /// </summary>
        /// <param name="node"></param>
        private void LoadingTables(TreeNode node)
        {
            var type = (DataBaseType)node.Tag;
            switch (type)
            {
                case DataBaseType.SQLServer:
                    var sql = @"select * from
(SELECT 
    表名       = case when a.colorder=1 then d.name else '' end,
    表说明     = case when a.colorder=1 then isnull(f.value,'') else '' end
FROM 
    syscolumns a
inner join 
    sysobjects d 
on 
    a.id=d.id  and d.xtype='U' and  d.name<>'dtproperties'
left join
sys.extended_properties f
on 
    d.id=f.major_id and f.minor_id=0) t
	where t.表名!=''";
                    var dt = SQLServerHelper.QueryDataTable(node.Name, sql);
                    if (dt?.Rows.Count > 0)
                    {
                        node.Nodes.Clear();
                        foreach (DataRow item in dt.Rows)
                        {
                            var nodeItem = new TreeNode
                            {
                                Text = item["表名"].ToString(),
                                Name = item["表说明"].ToString(),
                                Tag = type
                            };
                            node.Nodes.Add(nodeItem);
                        }
                        dt.Rows.Clear();
                        dt.Clear();
                        dt.Dispose();
                        dt = null;
                        GC.Collect();
                    }
                    break;
                case DataBaseType.MySQL:
                    var database = node.Name.Substring(node.Name.IndexOf("Database=") + 9, node.Name.IndexOf(";port=") - node.Name.IndexOf("Database=") - 9);
                    var sql1 = $"SELECT TABLE_NAME as 表名, Table_Comment as 表说明 FROM INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = '{database}'";
                    var dt1 = MySQLHelper.QueryDataTable(node.Name, sql1);
                    if (dt1?.Rows.Count > 0)
                    {
                        node.Nodes.Clear();
                        foreach (DataRow item in dt1.Rows)
                        {
                            var nodeItem = new TreeNode
                            {
                                Text = item["表名"].ToString(),
                                Name = item["表说明"].ToString(),
                                Tag = type
                            };
                            node.Nodes.Add(nodeItem);
                        }
                        dt1.Rows.Clear();
                        dt1.Clear();
                        dt1.Dispose();
                        dt1 = null;
                        GC.Collect();
                    }
                    break;
                case DataBaseType.Oracler:
                    break;
                case DataBaseType.SQLite:
                    break;
                case DataBaseType.PostgreSQL:
                    break;
                default:
                    break;
            }
        }

        private string GetEntityCode(TreeNode node)
        {
            var type = (DataBaseType)node.Tag;
            StringBuilder codeString = new StringBuilder();
            switch (type)
            {
                case DataBaseType.SQLServer:
                    #region SQL Server生成实体类代码
                    codeString.Append($@"using SqlSugar;{(string.IsNullOrWhiteSpace(this.Using_TextBox.Text) ? "" : $"{Environment.NewLine}{this.Using_TextBox.Text.Trim()}")}

namespace {this.Namespace_TextBox.Text.Trim()}
{{
    /// <summary>
    /// {node.Name}
    /// </summary>{(string.IsNullOrWhiteSpace(this.CusAttr_TextBox.Text) ? "" : $"{Environment.NewLine}    {this.CusAttr_TextBox.Text.Trim()}")}
    public class {(this.TableCapsCount_NumericUpDown.Value > 0 ? node.Text.SetLengthToUpperByStart((int)this.TableCapsCount_NumericUpDown.Value) : node.Text)}{(string.IsNullOrWhiteSpace(this.BaseClass_TextBox.Text) ? "" : $" : {this.BaseClass_TextBox.Text.Trim()}")}
    {{");
                    var tableInfo = SQLServerHelper.QueryTableInfo(node.Parent.Name, $"select * from {node.Text} where 1=2");
                    DataTable colsInfos = SQLServerHelper.QueryDataTable(node.Parent.Name, "SELECT OBJNAME,VALUE FROM ::FN_LISTEXTENDEDPROPERTY (NULL, 'USER', 'DBO', 'TABLE', '" + node.Text + "', 'COLUMN', DEFAULT)", null);
                    var getString = this.GetCus_TextBox.Text.Trim();
                    if (string.IsNullOrWhiteSpace(getString))
                    {
                        getString = "return this._-colName-;";
                    }
                    else
                    {
                        getString = getString.Replace("属性", "-colName-");
                    }
                    var setString = this.SetCus_TextBox.Text.Trim();
                    if (string.IsNullOrWhiteSpace(setString))
                    {
                        setString = "this._-colName- = -value-;";
                    }
                    else
                    {
                        setString = setString.Replace("属性", "-colName-");
                    }
                    foreach (DataRow dr in tableInfo.Rows)
                    {
                        var zhuShi = string.Empty;//列名注释
                        foreach (DataRow uu in colsInfos.Rows)
                        {
                            if (uu["OBJNAME"].ToString().ToUpper() == dr["ColumnName"].ToString().ToUpper())
                                zhuShi = uu["VALUE"].ToString();
                        }
                        if ((bool)dr["IsKey"] && !(bool)dr["IsIdentity"])
                        {
                            if (this.SqlSugarPK_CheckBox.Checked && this.SqlSugarBZL_CheckBox.Checked)
                            {
                                codeString.Append($@"
        private -dbType- _-colName-;
        /// <summary>
        /// -zhuShi-
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = false)]
        public -dbType- -colName- {{ get {{ {getString} }} set {{ {setString} }} }}
");
                            }
                            else if (this.SqlSugarPK_CheckBox.Checked && !this.SqlSugarBZL_CheckBox.Checked)
                            {
                                codeString.Append($@"
        private -dbType- _-colName-;
        /// <summary>
        /// -zhuShi-
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public -dbType- -colName- {{ get {{ {getString} }} set {{ {setString} }} }}
");
                            }
                            else
                            {
                                codeString.Append($@"
        private -dbType- _-colName-;
        /// <summary>
        /// -zhuShi-
        /// </summary>
        public -dbType- -colName- {{ get {{ {getString} }} set {{ {setString} }} }}
");
                            }
                        }
                        else if ((bool)dr["IsKey"] && (bool)dr["IsIdentity"])
                        {
                            if (this.SqlSugarPK_CheckBox.Checked && this.SqlSugarBZL_CheckBox.Checked)
                            {
                                codeString.Append($@"
        private -dbType- _-colName-;
        /// <summary>
        /// -zhuShi-
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public -dbType- -colName- {{ get {{ {getString} }} set {{ {setString} }} }}
");
                            }
                            else if (this.SqlSugarPK_CheckBox.Checked && !this.SqlSugarBZL_CheckBox.Checked)
                            {
                                codeString.Append($@"
        private -dbType- _-colName-;
        /// <summary>
        /// -zhuShi-
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public -dbType- -colName- {{ get {{ {getString} }} set {{ {setString} }} }}
");
                            }
                            else if (!this.SqlSugarPK_CheckBox.Checked && this.SqlSugarBZL_CheckBox.Checked)
                            {
                                codeString.Append($@"
        private -dbType- _-colName-;
        /// <summary>
        /// -zhuShi-
        /// </summary>
        [SugarColumn(IsIdentity = true)]
        public -dbType- -colName- {{ get {{ {getString} }} set {{ {setString} }} }}
");
                            }
                            else
                            {
                                codeString.Append($@"
        private -dbType- _-colName-;
        /// <summary>
        /// -zhuShi-
        /// </summary>
        public -dbType- -colName- {{ get {{ {getString} }} set {{ {setString} }} }}
");
                            }
                        }
                        else if (!(bool)dr["IsKey"] && (bool)dr["IsIdentity"])
                        {
                            if (this.SqlSugarBZL_CheckBox.Checked)
                            {
                                codeString.Append($@"
        private -dbType- _-colName-;
        /// <summary>
        /// -zhuShi-
        /// </summary>
        [SugarColumn(IsIdentity = true)]
        public -dbType- -colName- {{ get {{ {getString} }} set {{ {setString} }} }}
");
                            }
                            else
                            {
                                codeString.Append($@"
        private -dbType- _-colName-;
        /// <summary>
        /// -zhuShi-
        /// </summary>
        public -dbType- -colName- {{ get {{ {getString} }} set {{ {setString} }} }}
");
                            }
                        }
                        else
                        {
                            codeString.Append($@"
        private -dbType- _-colName-;
        /// <summary>
        /// -zhuShi-
        /// </summary>
        public -dbType- -colName- {{ get {{ {getString} }} set {{ {setString} }} }}
");
                        }
                        Type ttttt = this.GetTypeByString(dr["DataType"].ToString());
                        if (ttttt.IsValueType && dr["AllowDBNull"].ToString() == "True")
                        {
                            codeString.Replace("-dbType-", dr["DataType"].ToString() + "?");  //替换数据类型
                            if (this.PropDefault_CheckBox.Checked)
                            {
                                codeString.Replace("-value-", $"value ?? default({dr["DataType"].ToString()})");
                            }
                            else
                            {
                                codeString.Replace("-value-", "value");
                            }
                        }
                        else
                        {
                            if (dr["DataType"].ToString() == "System.String")
                            {
                                codeString.Replace("-dbType-", dr["DataType"].ToString());  //替换数据类型
                                if (this.PropTrim_CheckBox.Checked)
                                {
                                    codeString.Replace("-value-", "value?.Trim()");
                                }
                                else
                                {
                                    codeString.Replace("-value-", "value");
                                }
                            }
                            else
                            {
                                codeString.Replace("-dbType-", dr["DataType"].ToString());  //替换数据类型
                                codeString.Replace("-value-", "value");
                            }
                        }
                        codeString.Replace("-colName-", this.PropCapsCount_NumericUpDown.Value > 0 ? dr["ColumnName"].ToString().SetLengthToUpperByStart((int)this.PropCapsCount_NumericUpDown.Value) : dr["ColumnName"].ToString());  //替换列名（属性名）
                        codeString.Replace("-zhuShi-", zhuShi);
                    }
                    codeString.Append(@"    }
}");
                    #endregion
                    break;
                case DataBaseType.MySQL:
                    var database = node.Parent.Name.Substring(node.Parent.Name.IndexOf("Database=") + 9, node.Parent.Name.IndexOf(";port=") - node.Parent.Name.IndexOf("Database=") - 9);
                    codeString.Append($@"using SqlSugar;{(string.IsNullOrWhiteSpace(this.Using_TextBox.Text) ? "" : $"{Environment.NewLine}{this.Using_TextBox.Text.Trim()}")}

namespace {this.Namespace_TextBox.Text.Trim()}
{{
    /// <summary>
    /// {node.Name}
    /// </summary>{(string.IsNullOrWhiteSpace(this.CusAttr_TextBox.Text) ? "" : $"{Environment.NewLine}    {this.CusAttr_TextBox.Text.Trim()}")}
    public class {(this.TableCapsCount_NumericUpDown.Value > 0 ? node.Text.SetLengthToUpperByStart((int)this.TableCapsCount_NumericUpDown.Value) : node.Text)}{(string.IsNullOrWhiteSpace(this.BaseClass_TextBox.Text) ? "" : $" : {this.BaseClass_TextBox.Text.Trim()}")}
    {{");
                    var mysql_tableInfo = MySQLHelper.QueryTableInfo(node.Parent.Name, $"select * from {node.Text} where 1=2");
                    DataTable mysql_colsInfos = MySQLHelper.QueryDataTable(node.Parent.Name, $"select COLUMN_NAME as OBJNAME,column_comment as VALUE from INFORMATION_SCHEMA.Columns where table_name='{node.Text}' and table_schema='{database}'", null);
                    var mysql_getString = this.GetCus_TextBox.Text.Trim();
                    if (string.IsNullOrWhiteSpace(mysql_getString))
                    {
                        mysql_getString = "return this._-colName-;";
                    }
                    else
                    {
                        mysql_getString = mysql_getString.Replace("属性", "-colName-");
                    }
                    var mysql_setString = this.SetCus_TextBox.Text.Trim();
                    if (string.IsNullOrWhiteSpace(mysql_setString))
                    {
                        mysql_setString = "this._-colName- = -value-;";
                    }
                    else
                    {
                        mysql_setString = mysql_setString.Replace("属性", "-colName-");
                    }
                    foreach (DataRow dr in mysql_tableInfo.Rows)
                    {
                        var zhuShi = string.Empty;//列名注释
                        foreach (DataRow uu in mysql_colsInfos.Rows)
                        {
                            if (uu["OBJNAME"].ToString().ToUpper() == dr["ColumnName"].ToString().ToUpper())
                                zhuShi = uu["VALUE"].ToString();
                        }
                        if ((bool)dr["IsKey"] && !(bool)dr["IsAutoIncrement"])
                        {
                            if (this.SqlSugarPK_CheckBox.Checked && this.SqlSugarBZL_CheckBox.Checked)
                            {
                                codeString.Append($@"
        private -dbType- _-colName-;
        /// <summary>
        /// -zhuShi-
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = false)]
        public -dbType- -colName- {{ get {{ {mysql_getString} }} set {{ {mysql_setString} }} }}
");
                            }
                            else if (this.SqlSugarPK_CheckBox.Checked && !this.SqlSugarBZL_CheckBox.Checked)
                            {
                                codeString.Append($@"
        private -dbType- _-colName-;
        /// <summary>
        /// -zhuShi-
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public -dbType- -colName- {{ get {{ {mysql_getString} }} set {{ {mysql_setString} }} }}
");
                            }
                            else
                            {
                                codeString.Append($@"
        private -dbType- _-colName-;
        /// <summary>
        /// -zhuShi-
        /// </summary>
        public -dbType- -colName- {{ get {{ {mysql_getString} }} set {{ {mysql_setString} }} }}
");
                            }
                        }
                        else if ((bool)dr["IsKey"] && (bool)dr["IsAutoIncrement"])
                        {
                            if (this.SqlSugarPK_CheckBox.Checked && this.SqlSugarBZL_CheckBox.Checked)
                            {
                                codeString.Append($@"
        private -dbType- _-colName-;
        /// <summary>
        /// -zhuShi-
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public -dbType- -colName- {{ get {{ {mysql_getString} }} set {{ {mysql_setString} }} }}
");
                            }
                            else if (this.SqlSugarPK_CheckBox.Checked && !this.SqlSugarBZL_CheckBox.Checked)
                            {
                                codeString.Append($@"
        private -dbType- _-colName-;
        /// <summary>
        /// -zhuShi-
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public -dbType- -colName- {{ get {{ {mysql_getString} }} set {{ {mysql_setString} }} }}
");
                            }
                            else if (!this.SqlSugarPK_CheckBox.Checked && this.SqlSugarBZL_CheckBox.Checked)
                            {
                                codeString.Append($@"
        private -dbType- _-colName-;
        /// <summary>
        /// -zhuShi-
        /// </summary>
        [SugarColumn(IsIdentity = true)]
        public -dbType- -colName- {{ get {{ {mysql_getString} }} set {{ {mysql_setString} }} }}
");
                            }
                            else
                            {
                                codeString.Append($@"
        private -dbType- _-colName-;
        /// <summary>
        /// -zhuShi-
        /// </summary>
        public -dbType- -colName- {{ get {{ {mysql_getString} }} set {{ {mysql_setString} }} }}
");
                            }
                        }
                        else if (!(bool)dr["IsKey"] && (bool)dr["IsAutoIncrement"])
                        {
                            if (this.SqlSugarBZL_CheckBox.Checked)
                            {
                                codeString.Append($@"
        private -dbType- _-colName-;
        /// <summary>
        /// -zhuShi-
        /// </summary>
        [SugarColumn(IsIdentity = true)]
        public -dbType- -colName- {{ get {{ {mysql_getString} }} set {{ {mysql_setString} }} }}
");
                            }
                            else
                            {
                                codeString.Append($@"
        private -dbType- _-colName-;
        /// <summary>
        /// -zhuShi-
        /// </summary>
        public -dbType- -colName- {{ get {{ {mysql_getString} }} set {{ {mysql_setString} }} }}
");
                            }
                        }
                        else
                        {
                            codeString.Append($@"
        private -dbType- _-colName-;
        /// <summary>
        /// -zhuShi-
        /// </summary>
        public -dbType- -colName- {{ get {{ {mysql_getString} }} set {{ {mysql_setString} }} }}
");
                        }
                        Type ttttt = this.GetTypeByString(dr["DataType"].ToString());
                        if (ttttt.IsValueType && dr["AllowDBNull"].ToString() == "True")
                        {
                            codeString.Replace("-dbType-", dr["DataType"].ToString() + "?");  //替换数据类型
                            if (this.PropDefault_CheckBox.Checked)
                            {
                                codeString.Replace("-value-", $"value ?? default({dr["DataType"].ToString()})");
                            }
                            else
                            {
                                codeString.Replace("-value-", "value");
                            }
                        }
                        else
                        {
                            if (dr["DataType"].ToString() == "System.String")
                            {
                                codeString.Replace("-dbType-", dr["DataType"].ToString());  //替换数据类型
                                if (this.PropTrim_CheckBox.Checked)
                                {
                                    codeString.Replace("-value-", "value?.Trim()");
                                }
                                else
                                {
                                    codeString.Replace("-value-", "value");
                                }
                            }
                            else
                            {
                                codeString.Replace("-dbType-", dr["DataType"].ToString());  //替换数据类型
                                codeString.Replace("-value-", "value");
                            }
                        }
                        codeString.Replace("-colName-", this.PropCapsCount_NumericUpDown.Value > 0 ? dr["ColumnName"].ToString().SetLengthToUpperByStart((int)this.PropCapsCount_NumericUpDown.Value) : dr["ColumnName"].ToString());  //替换列名（属性名）
                        codeString.Replace("-zhuShi-", zhuShi);
                    }
                    codeString.Append(@"    }
}");
                    break;
                case DataBaseType.Oracler:
                    break;
                case DataBaseType.SQLite:
                    break;
                case DataBaseType.PostgreSQL:
                    break;
                default:
                    break;
            }
            return codeString.ToString();
        }

        private void Using_TextBox_MouseHover(object sender, EventArgs e)
        {
            this.UsingTip.Show($"一行一个命名空间, 如 {Environment.NewLine}using System;{Environment.NewLine}using System.Data;", this.Using_TextBox);
        }

        private void BaseClass_TextBox_MouseHover(object sender, EventArgs e)
        {
            this.UsingTip.Show("不要继承父类, 则无需写入值", this.BaseClass_TextBox);
        }

        private void CusAttr_TextBox_MouseHover(object sender, EventArgs e)
        {
            this.UsingTip.Show("实体类自定义特性, 如 [Key, Cus], 会加在实体类上面", this.CusAttr_TextBox);
        }

        private void GetCus_TextBox_MouseHover(object sender, EventArgs e)
        {
            this.UsingTip.Show("get表达式, 如输入: return this._属性; 则会生成 get { return this._Prop; }", this.GetCus_TextBox);
        }

        private void SetCus_TextBox_MouseHover(object sender, EventArgs e)
        {
            this.UsingTip.Show("set表达式, 如输入: this._属性 = -value-; 则会生成 set { this._Prop = value; }", this.SetCus_TextBox);
        }

        /// <summary>
        /// 关闭事件, 保存设置信息等等
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this._MainInfoModel.UsingString = this.Using_TextBox.Text.Trim();
            this._MainInfoModel.BaseClass = this.BaseClass_TextBox.Text.Trim();
            this._MainInfoModel.Namespace = this.Namespace_TextBox.Text.Trim();
            this._MainInfoModel.TableCapsCount = (int)this.TableCapsCount_NumericUpDown.Value;
            this._MainInfoModel.PropCapsCount = (int)this.PropCapsCount_NumericUpDown.Value;
            this._MainInfoModel.StringTrim = this.PropTrim_CheckBox.Checked;
            this._MainInfoModel.ValueDefault = this.PropDefault_CheckBox.Checked;
            this._MainInfoModel.PK = this.SqlSugarPK_CheckBox.Checked;
            this._MainInfoModel.BZL = this.SqlSugarBZL_CheckBox.Checked;
            this._MainInfoModel.CusAttr = this.CusAttr_TextBox.Text.Trim();
            this._MainInfoModel.GetString = this.GetCus_TextBox.Text.Trim();
            this._MainInfoModel.SetString = this.SetCus_TextBox.Text.Trim();
            FileStream fs = new FileStream("info.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();  //创建二进制对象
            bf.Serialize(fs, this._MainInfoModel);
            fs.Close();
            fs.Dispose();
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (File.Exists("info.dat"))
            {
                FileStream fs = new FileStream("info.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();  //二进制对象
                this._MainInfoModel = bf.Deserialize(fs) as MainInfoModel;
                bf = null;
                fs.Dispose();
                fs = null;
                GC.Collect();
                foreach (var item in this._MainInfoModel.LinkList)
                {
                    this.LinkInfo_TreeView.Nodes.Add(new TreeNode
                    {
                        Name = item.LinkString,
                        Text = item.LinkName,
                        Tag = item.Type
                    });
                }
                this.Using_TextBox.Text = this._MainInfoModel.UsingString;
                this.BaseClass_TextBox.Text = this._MainInfoModel.BaseClass;
                this.Namespace_TextBox.Text = this._MainInfoModel.Namespace;
                this.TableCapsCount_NumericUpDown.Value = this._MainInfoModel.TableCapsCount;
                this.PropCapsCount_NumericUpDown.Value = this._MainInfoModel.PropCapsCount;
                this.PropTrim_CheckBox.Checked = this._MainInfoModel.StringTrim;
                this.PropDefault_CheckBox.Checked = this._MainInfoModel.ValueDefault;
                this.SqlSugarPK_CheckBox.Checked = this._MainInfoModel.PK;
                this.SqlSugarBZL_CheckBox.Checked = this._MainInfoModel.BZL;
                this.CusAttr_TextBox.Text = this._MainInfoModel.CusAttr;
                this.GetCus_TextBox.Text = this._MainInfoModel.GetString;
                this.SetCus_TextBox.Text = this._MainInfoModel.SetString;
            }
        }

        private async void 预览生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            void YL()
            {
                this.Invoke(new Action(() =>
                {
                    var selectNode = this.LinkInfo_TreeView.SelectedNode;
                    if (selectNode == null || selectNode.Parent == null)
                    {
                        MessageBox.Show("请选择表名再生成预览", "预览提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    this.Code_TextEditorControl.Text = this.GetEntityCode(selectNode);
                }));
            }

            await Task.Run(() => YL());
        }

        private async void 生成所有ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            void CreateCodes()
            {
                this.Invoke(new Action(() =>
                {
                    var selectNode = this.LinkInfo_TreeView.SelectedNode;
                    if (selectNode == null)
                    {
                        MessageBox.Show("请选择节点", "生成提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    var folderBrowserDialog = new FolderBrowserDialog();
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (selectNode.Parent != null)
                        {
                            selectNode = selectNode.Parent;
                        }
                        else
                        {
                            if (selectNode.Nodes.Count <= 0)
                            {
                                MessageBox.Show("请先加载出表", "生成提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                        }
                        Directory.CreateDirectory(folderBrowserDialog.SelectedPath + "\\" + this.Namespace_TextBox.Text.Trim());
                        foreach (TreeNode node in selectNode.Nodes)
                        {
                            using (StreamWriter sw = new StreamWriter(folderBrowserDialog.SelectedPath + "\\" + this.Namespace_TextBox.Text.Trim() + "\\" + (this.TableCapsCount_NumericUpDown.Value > 0 ? node.Text.SetLengthToUpperByStart((int)this.TableCapsCount_NumericUpDown.Value) : node.Text) + ".cs"))
                            {
                                sw.Write(this.GetEntityCode(node));
                            }
                        }
                        MessageBox.Show("生成成功", "生成提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }));
            }

            await Task.Run(() =>
            {
                CreateCodes();
            });
        }

        private async void 加载表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectNode = this.LinkInfo_TreeView.SelectedNode;
            if (selectNode == null)
            {
                MessageBox.Show("请选择节点", "加载提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (selectNode.Parent != null)
            {
                selectNode = selectNode.Parent;
            }

            void Tables()
            {
                this.Invoke(new Action(() => LoadingTables(selectNode)));
            }

            await Task.Run(() => Tables());
        }

        private void 删除此连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定删除此连接吗?", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                var selectNode = this.LinkInfo_TreeView.SelectedNode;
                if (selectNode == null)
                {
                    MessageBox.Show("请选择要删除的节点", "删除提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (selectNode.Parent != null)
                {
                    selectNode = selectNode.Parent;
                }
                this.LinkInfo_TreeView.Nodes.Remove(selectNode);
            }
        }
        
        private void MySQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sqlServerModel = new MySQLLink(linkInfo =>
            {
                this.LinkInfo_TreeView.Nodes.Add(new TreeNode
                {
                    Name = linkInfo.LinkString,
                    Text = linkInfo.LinkName,
                    Tag = linkInfo.Type
                });
                this._MainInfoModel.LinkList.Add(linkInfo);
            }).ShowDialog();
        }
    }
}