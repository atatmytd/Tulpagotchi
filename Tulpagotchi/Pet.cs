using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulpagotchi
{
    public class Pet
    {
        public override string ToString() {return petAge + " " + petColor + " " + petType;}
        public string imagePath;
        private string GetImageLocation()
        {
            string filepath = "";

            filepath += Environment.CurrentDirectory + "/";
            filepath += string.Format("{0}/{1}_{2}_{3}.png", petGroup, petAge, petColor, petType);

            return filepath;
        }

        /*PET DESCRIPTORS*/
        public enum PetAge { Mystery, Baby, Teenager, Adult, };
        public PetAge petAge;
        public enum PetColor { Basic, Black, White, Brown, Red, Orange, Yellow, Green, Blue, Purple };
        public PetColor petColor;
        public enum PetType { Wolf, Tiger, Pig, Lion, Koala, Fox, Duck, Dragon, Bear, };
        public PetType petType;
        public enum Grouping { gen1, gen2, gen3, milestone, boss }; // gen 1 - standards; gen 2 - magic pets; gen 3 - quest pets
        public Grouping petGroup;

        public int level;
        public int GetBattleThreshold(Random random)
        {
            int threshold = 0;
            switch(petGroup)
            {
                case Grouping.gen1:
                case Grouping.gen2:
                case Grouping.gen3:
                    switch(petAge)
                    {
                        case PetAge.Mystery: threshold += 100; break;
                        case PetAge.Baby: threshold += 150; break;
                        case PetAge.Teenager: threshold += random.Next(300, 750); break;
                        case PetAge.Adult: threshold += Utilities.ReturnNextLevelCeiling(level, 1000); break;
                        default: break;
                    }
                    break;
                /*these two do not have a baby or teenage form, only an adult form; but they're not MVP, so these calculations will wait*/ 
                case Grouping.milestone: 
                case Grouping.boss:
                    break;
                default: return threshold;
            }

            return threshold;
        }
    }
}
