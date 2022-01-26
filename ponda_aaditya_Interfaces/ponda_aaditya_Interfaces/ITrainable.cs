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
    interface ITrainable
    {
        Dictionary<string, string> Behaviors { get; set; }
        string Perform(string signal);
        string Train(string signal, string behavior);
    }
}
