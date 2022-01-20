using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponda_aaditya_Interfaces
{
    class Sheep : Animal, ITrainable
    {
        private Dictionary<string, string> _behaviors;

        public Sheep()
        {
            Species = "Sheep";
            _treat = "plant";
        }

        public override string MakeNoise()
        {
            return "Sheep makes Baa sound";
        }

        public Dictionary<string, string> Behaviors { get => _behaviors; set => _behaviors = value; }

        public string Perform(string signal)
        {
            string behavior;
            _behaviors.TryGetValue(signal, out behavior);

            if (behavior == "")
                return $"{Species} did not learn this signal yet.";
            else
                return $"After you signalled {signal} the {Species} perfoms {behavior}. Nie Work!";
        }

        public string Train(string signal, string behavior)
        {
            _behaviors.Add(signal, behavior);
            return $"The {Species} learned to {behavior} when you {signal}.";
        }

    }
}
