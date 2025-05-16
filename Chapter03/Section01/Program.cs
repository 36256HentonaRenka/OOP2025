namespace Section01 {
    internal class Program {

        static void Main(string[] args) {
           var cities = new List<string> {
            "Tokyo",
            "New Delhi",
            "Bangkok",
            "London",
            "Paris",
            "Berlin",
            "Canberra",
            "Hong Kong",
           };

            var lowerList = cities.ConvertAll(s => s.ToLower());
            lowerList.ForEach(s => Console.WriteLine(s));

            Console.WriteLine("");

            var highList = cities.ConvertAll(s => s.ToUpper());
            highList.ForEach(s => Console.WriteLine(s));
           

        }
    }
}
