using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalkulator {
    //売り上げクラス
    public class Sale {
        //店舗名
        public string ShopName { get; set; } = String.Empty;
        //商品カテゴリー
        public string ProductCategory { get; set; } = String.Empty;
        //売上高
        public int Amout { get; set; }
    }
}
