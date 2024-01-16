using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnimalShelter
{
    public class Customer
    {
        public string FirstName;
        public string LastName;
        private DateTime _Birthday;
        //age에 따라 조건이 생성되기 때문에 private로 변수에 접근을 하지 못하게 만든다.
        //cus.IsQulified = true로 생성이 될 수 있다.(public 사용 시)
        private bool _IsQulified;
        public string Address;
        public string Description;

        private List<Cat> _MyCats = new List<Cat>();
        public List<Cat> MyCats
        {
            get { return _MyCats; }
        }

        public bool Adopt(Cat cat)
        {
            if (_IsQulified)
            {
                _MyCats.Add(cat);
                return true;
            }
            else
            {
                return false;
            }
        }

        private List<Dog> _MyDogs = new List<Dog>();
        public List<Dog> MyDogs
        {
            get { return _MyDogs; }
        }

        public bool Adopt(Dog dog)
        {
            if (_IsQulified)
            {
                _MyDogs.Add(dog);
                return true;
            }
            else
            {
                return false;
            }
        }


        public Customer(string firstName, string lastName, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this._Birthday = birthday;

            this._IsQulified = Age >= 18;

        }

        public DateTime Birthday
        {
            get { return _Birthday; }
            set { _Birthday = value;
                _IsQulified = Age >= 18;
            }
        }


        //속성 get메소드에는 매개변수 x set메소드에는 저장하는 필드의 데이터와 같아야한다.
        public int Age
        {
            get {  return DateTime.Now.Year - _Birthday.Year;}
        }


        //속성 = get만 호출(읽기 전용)
        public bool IsQulified
        {
            get { return _IsQulified; }
        }


        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }


        /*
        public int GetAge()
        {
            return _Age;
        }

        public void SetAge(int age)
        {
            _Age = age;
            _IsQulified = age >= 18;
        }

        public bool GetIsQulified()
        {
            return _IsQulified;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName; 
        }*/


    }
}
