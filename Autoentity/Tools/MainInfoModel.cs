using System.Collections.Generic;

namespace Autoentity.Tools
{
    /// <summary>
    /// 保存设置信息实体类
    /// </summary>
    [System.Serializable]
    internal class MainInfoModel
    {
        /// <summary>
        /// 已经添加连接信息
        /// </summary>
        public List<LinkModel> LinkList { get; set; } = new List<LinkModel>();

        /// <summary>
        /// 导入的命名空间
        /// </summary>
        public string UsingString { get; set; }

        /// <summary>
        /// 父类
        /// </summary>
        public string BaseClass { get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// 表名大写个数
        /// </summary>
        public int TableCapsCount { get; set; }

        /// <summary>
        /// 属性大写个数
        /// </summary>
        public int PropCapsCount { get; set; }

        /// <summary>
        /// String去空格
        /// </summary>
        public bool StringTrim { get; set; }

        /// <summary>
        /// 只类型返回默认值
        /// </summary>
        public bool ValueDefault { get; set; }

        /// <summary>
        /// 标识主键
        /// </summary>
        public bool PK { get; set; }

        /// <summary>
        /// 标识列
        /// </summary>
        public bool BZL { get; set; }

        /// <summary>
        /// 自定义表特性
        /// </summary>
        public string CusAttr { get; set; }

        /// <summary>
        /// get表达式
        /// </summary>
        public string GetString { get; set; }

        /// <summary>
        /// set表达式
        /// </summary>
        public string SetString { get; set; }
    }
}