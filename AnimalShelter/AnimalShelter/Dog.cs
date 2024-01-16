using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{

    public enum DogBreed {Mixed, Bulldog, Yorkshire, Jindo}
    public class Dog : Pet
    {
        public DogBreed Breed;

        public Dog(int petId, string name, string color, string gender, DogBreed breed) 
            : base(petId, name, color, gender)
        {
            //Breed는 Dog 클래스 고유의 값
            Breed = breed;
        }

        public override string MakeSound()
        {
            return "멍멍";
        }

        public string Bite()
        {
            return "물어뜯기";
        }

    }
}
