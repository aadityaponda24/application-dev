/* 
 * Name: Aaditya Ponda
 * Date: Jan 25 2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponda_aaditya_API
{
    class Season
    {
        /* Season Properties */
        public string UID { get; }
        public string Title { get; }
        public int SeasonNum { get; }
        public int NumEpisodes { get;  }

        public Season(string id, string t, int seasonNum, int numEpisodes)
        {
            UID = id;
            Title = t;
            SeasonNum = seasonNum;
            NumEpisodes = numEpisodes;

        }
    }
}
