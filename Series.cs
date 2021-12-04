using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesApp
{
    internal class Series : IComparable
    {
        public string name;
        public string ganer;
        public int nuOfMovie;

        public Series(string name, string ganer, int nuOfMovie)
        {
            this.name = name;
            this.ganer = ganer;
            this.nuOfMovie = nuOfMovie;
        }

        public int CompareTo(object? obj)
        {
            Series nuOfMovie_ = (Series)obj;
            if (this.nuOfMovie < nuOfMovie_.nuOfMovie)
            {
                return -1;
            }
            if (this.nuOfMovie > nuOfMovie_.nuOfMovie)
            {
                return 1;
            }
            return 0;

        }
    }
}