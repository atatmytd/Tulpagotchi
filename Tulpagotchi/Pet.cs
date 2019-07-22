using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulpagotchi
{
    public class Pet
    {
        public enum PetType { Wolf, Tiger, Pig, Lion, Koala, Fox, Duck, Dragon, Bear, };
        public PetType petType;

        public enum PetColor { Basic, Black, White, Brown, Red, Orange, Yellow, Green, Blue, Purple };
        public PetColor petColor;
    }
}
