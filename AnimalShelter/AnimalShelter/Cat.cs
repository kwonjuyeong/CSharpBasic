using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Cat
    {
        //유니크한 펫 고유의 아이디
        public int PetId;
        public string Name;
        public string Color;
        public string Gender;
        public string Description;

        public Cat(int petId,string name, string color, string gender)
        {
            PetId = petId;  
            Name = name;
            Color = color;
            Gender = gender;
        }

        public string MakeSound()
        {
            return "야옹";
        }

        public string Scratch()
        {
            return "할퀴기";
        }

    }
}
