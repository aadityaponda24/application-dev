using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponda_aaditya_Interfaces
{
    class Sheep : Animal
    {
        public Sheep()
        {
            Species = "Sheep";
            _treat = "plant";
        }

        public override string MakeNoise()
        {
            return "Sheep makes Baa sound";
        }

    }
}
