using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Track_My_Shows
{
    class Movie
    {
        public int tmdbId { get; set; }
        public string title { get; set; }
        public int length { get; set; }
        public bool watched { get; set; }
        public string overview { get; set; }
        public string tagline { get; set; }

        public override string ToString()
        {
            return this.title;
        }

    }
}
