using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    //2-1-1
    public class Song {
        //歌のタイトル
        public string Title { get; set; } = string.Empty;
        //アーティスト名
        public string ArtistName { get; set; } = string.Empty;
        //演奏時間
        public int Length { get; set; }

        //2-1-2
        public Song(string Title,string ArtistName,int Length) {
            this.Title = Title;
            this.ArtistName = ArtistName;
            this.Length = Length;
        }
        public Song() {

        }
    }
}