/* 
 * Name: Aaditya Ponda
 * Date: Jan 25 2022
 */
using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json.Linq;


namespace ponda_aaditya_API
{
    class APIConnect
    {
        /* Connect to given URL and return dynamic Json Object */
        public dynamic Connect(string url)
        {
            dynamic jo;
            using (WebClient wc = new WebClient())
            {
                string results = wc.DownloadString(url);
                jo = JObject.Parse(results);
            }
            return jo;
        }

        /* Get List of Seasons */
        public List<Season> GetSeasons()
        {
            List<Season> seasons = new List<Season>();
            string url = "https://www.omdbapi.com/?i=tt0108778&apikey=7baac118";
            string seasonUrl;
            dynamic jo = Connect(url);
            int numOfSeasons = jo.totalSeasons;
            
            for(int i=1; i<=numOfSeasons; i++)
            {
                seasonUrl = $"{url}&Season={i}";
                jo = Connect(seasonUrl);
                string id = i.ToString();
                string title = $"Friends : Season {i}";
                int seasonNum = i;
                int numEpisodes = jo.Episodes.Count;

                seasons.Add(new Season(id, title, seasonNum, numEpisodes));


            }
            return seasons;
        }

        /* Get Episodes for a Season */
        public List<Episode> GetEpisodes(int seasonNum)
        {
            List<Episode> episodes = new List<Episode>();
            string url = "https://www.omdbapi.com/?i=tt0108778&apikey=7baac118";
            string seasonUrl = $"{url}&Season={seasonNum}";
            dynamic jo = Connect(seasonUrl);

            foreach(dynamic e in jo.Episodes)
            {
                string eid = e.imdbID;
                string title = e.Title;
                string year = e.Year;
                string released = e.Released;
                string runtime = e.Runtime;
                string genre = e.Genre;
                string director = e.Director;
                string writer = e.Writer;
                string actors = e.Actors;

                Episode episode = new Episode(eid, title);

                episodes.Add(episode);
            }
            return episodes;
        }

        /* Get Episode Details */
        public Episode GetEpisodeDetails(string eId)
        {
            List<Episode> episodes = new List<Episode>();
            string episodeUrl = $"https://www.omdbapi.com/?apikey=7baac118&i={eId}";
            dynamic jo = Connect(episodeUrl);

            string eid = jo.imdbID;
            string title = jo.Title;
            string year = jo.Year;
            string released = jo.Released;
            string runtime = jo.Runtime;
            string genre = jo.Genre;
            string director = jo.Director;
            string writer = jo.Writer;
            string actors = jo.Actors;
            Episode episode = new Episode(eid, title, year, released, runtime, genre, director, writer, actors);

            return episode;
        }
    }
}
