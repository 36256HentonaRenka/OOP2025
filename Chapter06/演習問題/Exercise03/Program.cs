
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";
            var alp = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,z,y";
            var al = alp.Split(',');


            Console.WriteLine("6.3.1");
            Exercise1(text);

            Console.WriteLine("6.3.2");
            Exercise2(text);

            Console.WriteLine("6.3.3");
            Exercise3(text);

            Console.WriteLine("6.3.4");
            Exercise4(text);

            Console.WriteLine("6.3.5");
            Exercise5(text);

            Console.WriteLine("6.3.99");
            Exercise06(text,alp);

        }
        private static void Exercise06(string text,string alp) {
            /*var al = alp.Split(',');
            foreach (var s in al) {
                Console.WriteLine(s[0] + ":" + text.ToLower().
                                                    Count(a => a == s[0]));
            }*/
            var str = text.ToLower().Replace(" "," ");

            //辞書で集計
            var alphDicCount = Enumerable.Range('a', 26)
                                         .ToDictionary(num => ((char)num).ToString(), num => 0);
            foreach(var alph in str) {
                alphDicCount[alph.ToString()]++;
            }
            foreach(var item in alphDicCount) {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
            //*************************************************************
            //配列で集計
            var array = Enumerable.Repeat(0, 26).ToArray();

            foreach(var alph in str) {
                array[alph - 'a']++;
            }
            for (char ch = 'a'; ch <= 'z' ; ch++) {
                Console.WriteLine($"{ch}:{array[ch - 'a']}");
            }
            //***************************************************************
            //aから順にカウントして出力
            for(char ch = 'a';ch <= 'z'; ch++) {
                Console.WriteLine($"{ch}:{text.Count(tc => tc ==ch)}");
            }
           
        }

        private static void Exercise1(string text) {
            var taget = text.Count(c=> c == ' ');
            Console.WriteLine("空白行：" + taget);

            //var space = text.Count(char.IsWhiteSpace);
        }
        
        private static void Exercise2(string text) {
            Console.WriteLine(text.Replace("big", "small"));   
        }

        private static void Exercise3(string text) {
            var num = text.Split(' ');
            var sb = new StringBuilder();
            foreach(var word in num) {
                sb.Append(word + " ");
            }

            Console.WriteLine(sb.ToString().TrimEnd()+";");
        }

        private static void Exercise4(string text) {
            var num = text.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("単語数:" + num.Length);

            var count = text.Split(' ').Length;
            Console.WriteLine("単語数:" + count);
        }

        private static void Exercise5(string text) {
            var num = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);         
            foreach (var s in num.Where(s=> s.Length <= 4)) {
                Console.WriteLine(s);
            }

            /*var num = text.Split(' ').Where(s => s.Length <= 4);
            foreach (var s in num) {
                Console.WriteLine(s);
            }*/

        }
        
    }
}
