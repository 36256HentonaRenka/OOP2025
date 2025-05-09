using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalkulator{
    //売り上げ集計クラス
    public class SalesCounter {
        private readonly IEnumerable<Sale> _sales;
        
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
        }

        //店舗別売り上げを求める
        public IDictionary<string, int> GetPerStoreSales() {
            var dict = new SortedDictionary<string, int>();
            foreach (var sale in _sales) {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amout;
                else
                    dict[sale.ShopName] = sale.Amout;
            }
            return dict;
        }
        //売り上げデータを読みこみSaleオブジェクトのリストを返す
        public static IEnumerable<Sale> ReadSales(string filePath) {
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
