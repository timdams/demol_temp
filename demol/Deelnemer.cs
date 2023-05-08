using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demol
{
    internal class Deelnemer
    {
        protected static Random rng = new Random();
        public virtual double NeemDeelAanProef()
        {
            return rng.Next(1, 101);
        }
    }


}
