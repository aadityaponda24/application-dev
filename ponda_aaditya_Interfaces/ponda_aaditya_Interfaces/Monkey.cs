using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponda_aaditya_Interfaces
{
    class Monkey : Animal
    {
        private Dictionary<string, string> _Behaviors;

        public Monkey()
        {
            Species = "Monkey";
            _treat = "fruit";
        }

        public override string MakeNoise()
        {
            return "Monkey makes grunting sound";
        }

    }
}
