using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoClasses
{
    public class MexicanTrain : Train
    {
        public MexicanTrain() : base() { }

        public MexicanTrain(int engValue) : base(engValue) { }

        public override bool IsPlayable(Hand h, Domino d, out bool mustFlip)
        {
            mustFlip = IsPlayable(d, out mustFlip);

            return mustFlip;
        }
    }
}
