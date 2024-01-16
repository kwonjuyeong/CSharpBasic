using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Pet
    {
        //유니크한 펫 고유의 아이디 => 필드를 각각 호출이 아닌 상속을 해준다
        public int PetId;
        public string Name;
        public string Color;
        public string Gender;
        public string Description;

        public Pet(int petId, string name, string color, string gender)
        {
            PetId = petId;
            Name = name;
            Color = color;
            Gender = gender;
        }


        //virtual : 필요하면 재정의 하라는 뜻
        public virtual string MakeSound()
        {
            return "";
        }


    }
}
