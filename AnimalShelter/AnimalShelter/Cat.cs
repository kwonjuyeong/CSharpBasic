using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    //pet클래스를 상속한다 : Pet
    public class Cat : Pet
    {
        //base를 사용함으로써 Pet 생성자에서 받아올 수 있다.
        public Cat(int petId, string name, string color, string gender) 
            : base(petId, name, color, gender)
        {
        }

        //override를 통해 virtual을 재정의한다.
        public override string MakeSound()
        {
            return "야옹";
        }

        public string Scratch()
        {
            return "할퀴기";
        }

    }
}
