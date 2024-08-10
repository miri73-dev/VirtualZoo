﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class Dog : Animal, ILand
    {
        private readonly int numberOfLegs = 4;

        public Dog() : base(true, true, 0)
        {

        }

        public Dog(bool mammals, bool carnivorous, int mood) : base(true, true, mood)
        {

        }
        public int GetNumberOfLegs()
        {
            return numberOfLegs;
        }

        public override void SayHello()
        {
            if(mood == MOOD_HAPPY)
            {
                Console.WriteLine("bark loudly");
                return;
            }
            if (mood == MOOD_SCARE)
            {
                Console.WriteLine("whooping");
                return;
            }
            Console.WriteLine("wagging the tail");
        }
        public override void SayHello(int mood)
        {
            this.mood = mood;
            SayHello();
        }
    }

}
