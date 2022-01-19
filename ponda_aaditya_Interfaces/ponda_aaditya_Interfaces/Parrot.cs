using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponda_aaditya_Interfaces
{
    class Parrot : Animal
    {
        public Parrot()
        {
            Species = "Parrot";
            _treat = "fruit";
        }

        public override string MakeNoise()
        {
            return "Parrot makes chatter sound";
        }

    }
}
