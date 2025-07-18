using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader{
    class ItemData{
        public required string? Title { get; set; } = string.Empty;
        public required string? Link { get; set; } = string.Empty;
    }
}
