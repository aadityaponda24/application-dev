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
    class Application
    {
        public Application()
        {
            /* Initialize API Connect for connections */
            APIConnect api = new APIConnect();

            /* Get Seasons */
            List<Season> seasons = api.GetSeasons();
            List<String> seasonTitles = new List<String>();
            foreach(Season s in seasons)
            {
                seasonTitles.Add(s.Title);
            }
            Menu seasonMenu = new Menu(seasonTitles);

            /* Display Seasons */
            Menu.DisplayHeader("Open Movie Database API : Friends Seasons ");
            seasonMenu.displayMenu(1);

            /* Get Season Number from user */
            int seasonNum = Validation.ValidateRange("Which season would you like? ",1,seasons.Count);

            /* Get List of Episodes for a given season */
            List<Episode> episodes = api.GetEpisodes(seasonNum);
            List<String> episodeTitles = new List<String>();
            foreach (Episode episode in episodes)
            {
                episodeTitles.Add(episode.Title);
            }
            Menu episodeMenu = new Menu(episodeTitles);

            /* Display Episode */
            Menu.DisplayHeader($"Open Movie Database API : Episodes for Season {seasonNum}");
            episodeMenu.displayMenu(1);

            /* Select the Episode */
            int episodeNum = Validation.ValidateRange("Which Episode would you like to see the details? ", 1, episodes.Count);
            string eId = episodes.ElementAt(episodeNum - 1).EID;

            /* Get Episode Details */
            Episode ep = api.GetEpisodeDetails(eId);

            /* Display Episode Details */
            Menu.DisplayHeader($"Open Movie Database API : Details for Episode {ep.Title}");
            Console.WriteLine($"Title    : {ep.Title}");
            Console.WriteLine($"Year     : {ep.Year}");
            Console.WriteLine($"Released : {ep.Released}");
            Console.WriteLine($"Runtime  : {ep.Runtime}");
            Console.WriteLine($"Genre    : {ep.Genre}");
            Console.WriteLine($"Director : {ep.Director}");
            Console.WriteLine($"Writer   : {ep.Writer}");
            Console.WriteLine($"Actors   : {ep.Actors}");

            Menu.ReadKey();
        }
    }
}
