using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperConnection.Class
{
    /// <summary>
    /// 异常故障记录 对应数据库表名 tb_Warning
    /// </summary>
    public class MySql_Warn
    {
        public int warn_id { get; set; }

        public string warn_time { get; set; }
        
        public string warn_kind { get; set;}

      
    }

    
}
