using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperConnection.Class
{
    /// <summary>
    /// PCB版加工数量统计类  对应数据库表名称 tb_PcbData
    /// </summary>
    public class StatisticsPCBData
    {
        public int pcbdata_id { get; set; }

        public DateTime pcbdata_day { get; set; }
        public int pcbdata_time { get; set; }
        public string pcbdata_CraftId { get; set; }

        public int pcbdata_InsertNumber { get; set; }

        public int pcbdata_PcbNumber { get; set; }
       
    }
}
