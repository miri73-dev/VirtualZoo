using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class Cat : Animal, ILand
    {
        private readonly int numberOfLegs = 4;
        public Cat() : base(true, true, 0)
        {

        }

        public Cat(bool mammals, bool carnivorous, int mood) : base(true, true, mood)
        {

        }

        public int GetNumberOfLegs()
        {
            return numberOfLegs;
        }

        public override void SayHello()
        {
            if (mood == MOOD_HAPPY)
            {
                Console.WriteLine("purr, purr");
                return;
            }
            if (mood == MOOD_SCARE)
            {
                Console.WriteLine("hiss");
                return;
            }

            Console.WriteLine("~ meow ~");
        }

        public override void SayHello(int mood)
        {
            this.mood = mood;
            SayHello();
        }
    }
}
