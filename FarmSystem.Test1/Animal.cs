using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    public class Animal
    {
        private string _id;
        private int _noOfLegs = 4;
        public int _ordinal;

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }



        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = 4;
            }
        }


        public virtual void Talk()
        {
            Console.WriteLine("Animal makes noise!");
        }
    }
}
