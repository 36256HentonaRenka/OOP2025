using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextFileProccerssorDI {
    public class LineToHalfNumberService : ITextFileService {
        //P３６２　問題15.1

        private static Dictionary<char, char> _dictonary =
            new Dictionary<char, char>() {
                {'０','0'},{'１','1'},{'２','2'},{'３','3'},{'４','4'},{'５','5'},{'６','6'},{'７','7'},{'８','8'},{'９','9'}
            };   



        public void Initialize(string fname) {
            
        }

        public void Execute(string line) {
            /*string result = new string (
                line.Select(c=> ('０' <= c && c <= '９') ? (char)(c - '０' + '０') : c).ToArray()
            );
            Console.WriteLine(result);*/

            var s = Regex.Replace(line, "[０-９]", c => _dictonary[c.Value[0]].ToString());
            Console.WriteLine(s);


        }

        public void Terminate() {
            
        }
    }
}

