namespace ProductSample {
    internal class Program {
        static void Main(string[] args) {

            Product karinto = new Product(123, "かりんとう", 180);

            //税抜き価格を表示
            Console.WriteLine(karinto.Name + "の税抜き価格は" + karinto.Price +"です。");

            //消費税額の表示
            Console.WriteLine(karinto.Name + "の消費税額は" + karinto.GetTax() + "です。");

            //税込み価格を表示
            Console.WriteLine(karinto.Name + "の税込み価格は" + karinto.GetPrinceIntcludingTax() + "です。");

            Product daihuku = new Product(111, "だいふく", 130);

            Console.WriteLine(daihuku.Name + "の税抜き価格は" + daihuku.Price + "です。");

            Console.WriteLine(daihuku.Name + "の消費税額は" + daihuku.GetTax() + "です。");

            Console.WriteLine(daihuku.Name + "の税込み価格は" + daihuku.GetPrinceIntcludingTax() + "です。");

        }
    }
}
