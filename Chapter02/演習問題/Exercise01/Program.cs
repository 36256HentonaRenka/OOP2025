using System.Globalization;
using System.Reflection;

namespace Exercise01 {
    internal class Program {
        public static void Main(string[] args) {
            //歌データを入れるリストオブジェクトを生成
            var songs = new List<Song>();

            Console.WriteLine("****曲の登録****");
            while (true) {
            Console.Write("曲名:");
            string title  = Console.ReadLine();

                if (title.Equals("end",StringComparison.OrdinalIgnoreCase)) {
                    break;
                } 
                Console.Write("アーティスト名:");
                string arthistName = Console.ReadLine();
                   
                Console.Write("演奏時間(秒):");
                int length = int.Parse(Console.ReadLine());

                //Songインスタンスを生成
                //var song = new Song(title, arthistName, length);
                Song song = new Song() {
                    Title = title,
                    ArtistName = arthistName,
                    Length = length
                };


                //歌データを入れるリストオブジェクトへ登録
                songs.Add(song);

                Console.WriteLine();//改行
            }

            Console.WriteLine("***登録曲一覧***");
            printSongs(songs);
            
                
        }
        //2-1-4
        private static void printSongs(List<Song> songs) {
#if false
            foreach ( var song in songs) {
                int min = song.Length / 60;
                int sec = song.Length % 60;
                Console.WriteLine($"{song.Title}, {song.ArtistName} {min}:{sec:00}");
            }
#else        
            //TimeSpamn構造体を使った場合
            foreach (var song in songs) {
                var timespan = TimeSpan.FromSeconds(song.Length);
                Console.WriteLine($"{song.Title}, {song.ArtistName} {timespan.Minutes}:{timespan.Seconds:00}");
            }
            /*foreach(var song in songs) {
                Console.WriteLine(@"{0},{1} {2:m\:ss}",
                    song.Title,song. ArtistName, TimeSpan.FromSeconds(song.Length));
            }*/

#endif
            Console.WriteLine();
        }
    }
}
