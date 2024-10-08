﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class Frog : Animal, IWater, ILand
    {
        private readonly int numberOfLegs = 4;
        public Frog() : base(false, false, 0)
        {

        }

        public Frog(bool mammals, bool carnivorous, int mood) : base(false, false, mood)
        {

        }

        public int GetNumberOfLegs()
        {
            return numberOfLegs;
        }

        public bool HasGills()
        {
            return false;
        }

        public bool HasLaysEggs()
        {
            return true;
        }

        public override void SayHello(int mood)
        {
            if (mood == MOOD_HAPPY)
            {
                Console.WriteLine("quack quack");
                return;
            }
            if (mood == MOOD_SCARE)
            {
                Console.WriteLine("plop into the water");
                return;
            }
        }
    }
}
