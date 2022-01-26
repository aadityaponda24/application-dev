/*
 * Name : Aaditya Ponda
 * Date : 19 Jan 2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ponda_aaditya_Interfaces
{
    class Fish : Animal
    {
        public Fish()
        {
            Species = "Fish";
            _treat = "worm";
        }

        public override string MakeNoise()
        {
            return "fish makes hum sound";
        }
    }
}
