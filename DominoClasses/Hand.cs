using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoClasses
{
    public class Hand
    {
        public List<Domino> dominos = new List<Domino>();

        public Hand() { }

        public Hand(BoneYard b, int numDomino)
        {
            for (int i = 0; i < numDomino; i++)
                dominos.Add(b[i]);
        }

        public int NumDomino
        {
            get
            {
                return dominos.Count;
            }
        }

        public void AddDomino(Domino d)
        {
            dominos.Add(d);
        }

        public Domino GetDomino(int index)
        {
            return dominos[index];
        }

        public bool HasDomino(Domino d)
        {
            if (IndexOf(d) > -1)
                return true;
            else
                return false;
        }

        public bool HasDomino(int side1)
        {
            if (IndexOfSide1(side1) > -1)
                return true;
            else
                return false;
        }

        public bool HasDomino(int side1, int side2)
        {
            if (IndexOf(side1, side2) > -1)
                return true;
            else
                return false;
        }

        public Domino DiscardDomino(int index)
        {
            Domino output = dominos[index];
            return output;
        }

        public int IndexOf(Domino d)
        {
            for (int i = 0; i < dominos.Count; i++)
                if (dominos[i] == d)
                    return i;
            return -1;
        }

        public int IndexOfSide1(int side1)
        {

            for (int i = 0; i < dominos.Count; i++)
                if (dominos[i].Side1 == side1)
                    return i;
            return -1;

        }
        public int IndexOfSide2(int side2)
        {

            for (int i = 0; i < dominos.Count; i++)
                if (dominos[i].Side2 == side2)
                    return i;
            return -1;
        }

        public int IndexOf(int side1, int side2)
        {
            for (int i = 0; i < dominos.Count; i++)
                if (dominos[i].Side1 == side1 && dominos[i].Side2 == side2)
                    return i;
            return -1;
        }

        public override string ToString()
        {
            string output = "";
            foreach (Domino d in dominos)
                output += d.ToString() + "\n";
            return output;
        }
    }
}