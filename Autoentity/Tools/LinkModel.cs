namespace Autoentity.Tools
{
    /// <summary>
    /// 连接信息
    /// </summary>
    [System.Serializable]
    internal class LinkModel
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public string LinkString { get; set; }

        /// <summary>
        /// 数据库类型
        /// </summary>
        public DataBaseType Type { get; set; }

        /// <summary>
        /// 连接名称
        /// </summary>
        public string LinkName { get; set; }

        public string Account { get; set; }

        public string Password { get; set; }

        /// <summary>
        /// MySQL端口号
        /// </summary>
        public ushort Port { get; set; }

        /// <summary>
        /// 主机地址
        /// </summary>
        public string Host { get; set; }
    }

    /// <summary>
    /// 数据库类型
    /// </summary>
    internal enum DataBaseType
    {
        SQLServer = 1,
        MySQL,
        Oracler,
        SQLite,
        PostgreSQL
    }
}