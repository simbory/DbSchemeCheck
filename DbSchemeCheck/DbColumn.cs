using System;
using Newtonsoft.Json;

namespace DbSchemeCheck
{
    /// <summary>
    /// 表字段结构
    /// </summary>
    public sealed class DbColumn
    {
        /// <summary>
        /// 字段ID
        /// </summary>
        public int ColumnID { get; set; }

        /// <summary>
        /// 是否主键
        /// </summary>
        public bool IsPrimaryKey { get; set; }

        /// <summary>
        /// 字段名称
        /// </summary>
        public string ColumnName { get; set; }

        /// <summary>
        /// 字段类型
        /// </summary>
        public string ColumnType { get; set; }

        /// <summary>
        /// 数据库类型对应的C#类型
        /// </summary>
        [JsonIgnore]
        public string CSharpType => SqlServerDbTypeMap.MapCsharpType(ColumnType);

        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public Type CommonType => SqlServerDbTypeMap.MapCommonType(ColumnType);

        /// <summary>
        /// 字节长度
        /// </summary>
        public int ByteLength { get; set; }

        /// <summary>
        /// 字符长度
        /// </summary>
        public int CharLength { get; set; }

        /// <summary>
        /// 浮点数精度
        /// </summary>
        public int Precision { get; set; } 

        /// <summary>
        /// 浮点数小数位
        /// </summary>
        public int Scale { get; set; }

        /// <summary>
        /// 是否自增列
        /// </summary>
        public bool IsIdentity { get; set; }

        /// <summary>
        /// 是否允许空
        /// </summary>
        public bool IsNullable { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Remark { get; set; }

        public string DbType
        {
            get
            {
                if (ColumnType.Contains("char") || ColumnType.Contains("binary"))
                {
                    return ColumnType + "(" + (CharLength == -1 ? "max" : CharLength.ToString()) + ")";
                }
                if (ColumnType == "numeric" || ColumnType == "decimal")
                {
                    return ColumnType + "(" + Precision +"," + Scale +")";
                }
                return ColumnType;
            }
        }
    }
}