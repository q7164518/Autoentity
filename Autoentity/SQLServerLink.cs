using Autoentity.Tools;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoentity
{
    public partial class SQLServerLink : Form
    {
        /// <summary>
        /// 绑定连接信息
        /// </summary>
        private readonly Action<LinkModel> BindLinkInfoEvent;

        /// <summary>
        /// 保存连接信息
        /// </summary>
        LinkModel LinkInfo = new LinkModel { Type = DataBaseType.SQLServer };

        /// <summary>
        /// 是否测试成功
        /// </summary>
        bool IsTestSuccess = false;

        /// <summary>
        /// 绑定连接信息事件
        /// </summary>
        /// <param name="action"></param>
        internal SQLServerLink(Action<LinkModel> action)
        {
            InitializeComponent();
            this.CheckType_ComboBox.SelectedIndex = 0;
            this.BindLinkInfoEvent = action;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.LinkInfo = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (!this.IsTestSuccess)
            {
                MessageBox.Show("请先进行测试连接~", "连接提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string database = this.DataBase_ComboBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(database))
            {
                MessageBox.Show("请选择数据库~", "连接提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (this.CheckType_ComboBox.SelectedIndex == 0)
            {
                this.LinkInfo.LinkString = $"Data Source={this.LinkInfo.Host};Initial Catalog={database};Persist Security Info=True;User ID={this.LinkInfo.Account};Password={this.LinkInfo.Password}";
            }
            else
            {
                this.LinkInfo.LinkString = $"Data Source={this.LinkInfo.Host};Initial Catalog={database};Integrated Security=True";
            }
            this.BindLinkInfoEvent?.Invoke(this.LinkInfo);
            this.Close();
        }

        /// <summary>
        /// 连接测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Test_Button_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                var result = this.Invoke(new Func<LinkModel>(() =>
                {
                    this.Test_Button.Enabled = this.OK_Button.Enabled = this.Cancel_Button.Enabled = false;
                    this.Test_Button.Text = "测试中...";
                    return this.CheckInfo();
                })) as LinkModel;
                if (result == null)
                {
                    this.Invoke(new Action(() =>
                    {
                        this.Test_Button.Enabled = this.OK_Button.Enabled = this.Cancel_Button.Enabled = true;
                        this.Test_Button.Text = "连接测试";
                    }));
                    return;
                }
                try
                {
                    if (SQLServerHelper.TestLink(result.LinkString))
                    {
                        this.Invoke(new Action(() =>
                        {
                            this.Test_Button.Enabled = this.OK_Button.Enabled = this.Cancel_Button.Enabled = true;
                            this.Test_Button.Text = "连接测试";
                        }));
                        this.IsTestSuccess = true;
                        MessageBox.Show("测试连接成功", "测试连接", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        this.Invoke(new Action(() =>
                        {
                            this.Test_Button.Enabled = this.OK_Button.Enabled = this.Cancel_Button.Enabled = true;
                            this.Test_Button.Text = "连接测试";
                        }));
                        MessageBox.Show("测试连接失败", "测试连接", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    this.Invoke(new Action(() =>
                    {
                        this.Test_Button.Enabled = this.OK_Button.Enabled = this.Cancel_Button.Enabled = true;
                        this.Test_Button.Text = "连接测试";
                    }));
                    MessageBox.Show($"测试连接失败, 失败信息为: {ex.Message}", "测试连接", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            });
        }

        private LinkModel CheckInfo()
        {
            var linkName = this.LinkName_TextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(linkName))
            {
                MessageBox.Show("请输入连接名称~", "连接提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            LinkInfo.LinkName = linkName;
            var host = this.Host_TextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(host))
            {
                MessageBox.Show("请输入主机地址~", "连接提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
            this.LinkInfo.Host = host;
            if (this.CheckType_ComboBox.SelectedIndex == 0)
            {
                var account = this.Account_TextBox.Text.Trim();
                if (string.IsNullOrWhiteSpace(account))
                {
                    MessageBox.Show("请输入用户名~", "连接提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return null;
                }
                this.LinkInfo.Account = account;
                var pwd = this.Password_TextBox.Text.Trim();
                if (string.IsNullOrWhiteSpace(pwd))
                {
                    MessageBox.Show("请输入密码~", "连接提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return null;
                }
                this.LinkInfo.Password = pwd;
                LinkInfo.LinkString = $"Data Source={host};Initial Catalog=master;Persist Security Info=True;User ID={account};Password={pwd}";
            }
            else
            {
                LinkInfo.LinkString = $"Data Source={host};Initial Catalog=master;Integrated Security=True";
            }
            return LinkInfo;
        }

        private void CheckType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CheckType_ComboBox.SelectedIndex == 0)
            {
                this.Account_TextBox.Enabled = this.Password_TextBox.Enabled = true;
            }
            else
            {
                this.Account_TextBox.Enabled = this.Password_TextBox.Enabled = false;
            }
        }

        private async void DataBase_ComboBox_DropDown(object sender, EventArgs e)
        {
            void QueryDataBase()
            {
                this.Invoke(new Action(() =>
                {
                    this.DataBase_ComboBox.DataSource = SQLServerHelper.QueryDataTable(this.LinkInfo.LinkString, "select * from sysdatabases where dbid>4");
                    this.DataBase_ComboBox.DisplayMember = "name";
                }));
            }

            await Task.Run(() =>
            {
                if (!this.IsTestSuccess)
                {
                    MessageBox.Show("请先进行测试连接, 测试连接成功后再选择数据库~", "连接提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                QueryDataBase();
            });
        }
    }
}