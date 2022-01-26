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
    abstract class Animal
    {
        public string Species;
        private int _foodConsumed = 0;
        protected string _treat;

        public string Eat()
        {
            _foodConsumed++;
            if(_foodConsumed == 4)
            {
                Poop();
                _foodConsumed = 0;
            }
            return $"The {Species} ate a {_treat}";
        }

        public virtual string MakeNoise()
        {
            return "Default Animal Noise, should be implemented in sub class";
        }

        private void Poop()
        {
            Menu.DisplayContent($"The {Species} pooped!");
        }
    }
}
