using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperConnection.Class
{
    /// <summary>
    /// PCB版加工数量统计类
    /// </summary>
    public class StatisticsPCBData
    {
        public int pcbdata_id { get; set; }

        public DateTime pcbdata_day { get; set; }
        public int pcbdata_time { get; set; }
        public string pcbdata_craft_name { get; set; }

        public int pcbdata_process_number { get; set; }

        public int pcbdata_pcb_number { get; set; }
        public decimal pcbdata_insert_efficiency { get; set; }
        public decimal pcbdata_process_efficiency { get; set; }
    }
}
