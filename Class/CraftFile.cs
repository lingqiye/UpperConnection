using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperConnection.Class
{
    /// <summary>
    /// 工艺文件记录表 对应数据库表名称   tb_CraftFile
    /// </summary>
    public class StatisticsInsert
    {
        public int craft_id { get; set; }

        public string craft_name { get; set; }

        public DateTime craft_savetime { get; set; }
        public string craft_IniFile { get; set; }
    }
}
