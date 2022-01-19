using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponda_aaditya_Interfaces
{
    class Lion:Animal
    {
        public Lion()
        {
            Species = "Lion";
            _treat = "deer";
        }

        public override string MakeNoise()
        {
            return "Lion makes roar sound";
        }
    }
}
