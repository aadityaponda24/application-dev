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
    class Snake:Animal
    {
        public Snake()
        {
            Species = "Snake";
            _treat = "rat";
        }

        public override string MakeNoise()
        {
            return "Snake makes Hiss sound";
        }
    }
}
