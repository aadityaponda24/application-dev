/* 
 * Name: Aaditya Ponda
 * Date: Jan 28 2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponda_aaditya_API
{
    class Episode
    {
        /* Properties for the Episode */
        public string EID { get; }
        public string Title { get; }
        public object Year { get; }
        public object Released { get; }
        public object Runtime { get; }
        public object Genre { get; }
        public object Director { get;}
        public object Writer { get;}
        public object Actors { get;}

        public Episode(string eid, string title, string year, string released, string runtime, string genre, string director, string writer, string actors)
        {
            EID = eid;
            Title = title;
            Year = year;
            Released = released;
            Runtime = runtime;
            Genre = genre;
            Director = director;
            Writer = writer;
            Actors = actors;
        }

        public Episode(string eid, string title)
        {
            EID = eid;
            Title = title;
        }
    }
}
