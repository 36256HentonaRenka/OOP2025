using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    public class CarReport {
        public enum MakerGroup {
            なし  ,
            トヨタ,
            日産,
            ホンダ,
            スバル,
            輸入車,
            その他
        }

        public DateTime Date { get; set; }
        public string Author { get; set; } = string.Empty;
        public MakerGroup Maker { get; set; }
        public string CarName { get; set; } = string.Empty;
        public string Report { get; set; } = string.Empty;
        public Image? Picture { get; set; }
    }
}
