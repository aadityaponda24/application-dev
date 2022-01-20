using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponda_aaditya_Interfaces
{
    class Monkey : Animal, ITrainable
    {
        private Dictionary<string, string> _behaviors;

        public Monkey()
        {
            Species = "Monkey";
            _treat = "fruit";
            _behaviors = new Dictionary<string, string>();
        }

        public override string MakeNoise()
        {
            return "Monkey makes grunting sound";
        }

        public Dictionary<string, string> Behaviors { get => _behaviors; set => _behaviors = value; }

        public string Perform(string signal)
        {
            string behavior;

            

            _behaviors.TryGetValue(signal, out behavior);

            if (_behaviors.ContainsKey(signal))
            { 
                behavior = _behaviors.GetValueOrDefault(signal);
                return $"After you signalled {signal} the {Species} perfoms {behavior}. Nie Work!";
            }
            else
            {
                return $"{Species} did not learn this signal yet.";
            }
        }

        public string Train(string signal, string behavior)
        {
            _behaviors.Add(signal, behavior);
            return $"The {Species} learned to {behavior} when you {signal}.";
        }
    }
}
