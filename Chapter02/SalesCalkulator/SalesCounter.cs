using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalkulator{
    //売り上げ集計クラス
    public class SalesCounter {
        private readonly List<Sale> _sales;

        public SalesCounter(List<Sale> sales) {
            _sales = sales;
        }

        //店舗別売り上げを求める
        public Dictionary<string, int> GetPerStoreSales() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales) {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amout;
                else
                    dict[sale.ShopName] = sale.Amout;
            }
            return dict;
        }
        //売り上げデータを読みこみSaleオブジェクトのリストを返す
        public static List<Sale> ReadSales(string filePath) {
            //売り上げデータを入れるリストオブジェクトを生成
            List<Sale> sales = new List<Sale>();
            //ファイルを一気に読み込み
            string[] lines = File.ReadAllLines(filePath);
            //読み込んだ行数分繰り返し
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Sale sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amout = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }
    }
}
