using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace demol
{
    internal class Mol: Deelnemer
    {
        // er mag maar 1 mol zijn

        //PRO: singleton pattern
        
        public override double NeemDeelAanProef()
        {
            return rng.Next(0,60) ;
        }

        public void MolStem()
        {
            Console.WriteLine("Ik ben de mol");
        }
    }
}
