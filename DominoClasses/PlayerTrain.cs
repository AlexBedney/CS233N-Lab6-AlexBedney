using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoClasses
{
    public class PlayerTrain : Train
    {
        private Hand hand = new Hand();
        private bool isOpen;

        public PlayerTrain(Hand h) : base()
        {
            hand = h;
        }

        public PlayerTrain(Hand h, int engValue) : base(engValue) 
        {
            hand = h;
            engineValue = engValue;
        }

        public bool IsOpen
        {
            get
            {
                return isOpen;
            }
        }

        public void Close()
        {
            isOpen = false;
        }

        public void Open()
        {
            isOpen = true;
        }

        public override bool IsPlayable(Hand h, Domino d, out bool mustFlip)
        {
            foreach(Domino dom in h.dominos)
            {
                if (h.HasDomino(dom.side1) || h.HasDomino(dom.side2))
                {
                    mustFlip = true;
                    return mustFlip;
                }
            }

            if(isOpen)
            {
                mustFlip = true;
                return mustFlip;
            }
            else
            {
                mustFlip = false;
                return mustFlip;
            }
        }
    }
}
