using System.Collections;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        /*public Customer[] CustomerArray = new Customer[10];
        public int CustomerArrayIndex = 0;
        */

        public List<Customer> Customers = new List<Customer>();


        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            /*
            int numberOne = 1;
            int[] numberArray = new int[5];
            numberArray[0] = 1;
            numberArray[1] = 2;
            numberArray[2] = 3;
            numberArray[3] = 4;
            numberArray[4] = 5;

            int[] numberArray2 = new int[] { 1, 2, 3, 4, 5 };
            int[] numberArray3 = { 1, 2, 3, 4, 5 };


            Customer customerOne;
            Customer[] customerArray = new Customer[5];
            customerArray[0] = new Customer("first", "last", new DateTime(2000, 1, 1));
            customerArray[1] = new Customer("first", "last", new DateTime(2000, 1, 1));
            customerArray[2] = new Customer("first", "last", new DateTime(2000, 1, 1));
            customerArray[3] = new Customer("first", "last", new DateTime(2000, 1, 1));
            customerArray[4] = new Customer("first", "last", new DateTime(2000, 1, 1));

            Customer[] customerArray2 =
            {
                new Customer("first", "last", new DateTime(2000, 1, 1)),
                new Customer("first", "last", new DateTime(2000, 1, 1)),
                new Customer("first", "last", new DateTime(2000, 1, 1)),
                new Customer("first", "last", new DateTime(2000, 1, 1)),
                new Customer("first", "last", new DateTime(2000, 1, 1))

             };
            */

            /*
            int sum = 0;
            for(int index = 1; index <= 10; index = index + 1)
            {
                sum += index;
            }

            int numberOne = 1;
            int numberTwo = 0;

            //������ �ǰ� ������ �ȴ�. ���� Two = 2 One = 2
            numberTwo = ++numberOne;
            //������ �ǰ� ������ �ȴ�. ���� Two = 1 One = 2
            numberTwo = numberOne++;
            */

            Customer cus = new Customer(CusNewFirstName.Text, CusNewLastName.Text,
                DateTime.Parse(CusNewBirthday.Text));

            cus.Address = CusNewAddress.Text;
            cus.Description = CusNewDescription.Text;

            CusList.Rows.Add(cus.FirstName, cus.Age, cus.IsQulified);

            Customers.Add(cus);

            CusNewFirstName.Text = "";
            CusNewLastName.Text = "";
            CusNewBirthday.Text = "";
            CusNewAddress.Text = "";
            CusNewDescription.Text = "";
        }


        private void ShowDetails(Customer cus)
        {
            CusFullName.Text = cus.FullName;
            CusAge.Text = cus.Age.ToString();
            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            CusIsQualified.Text = cus.IsQulified.ToString();

            CusPetInfo.Text = "";

            /*
           foreach(Cat cat in cus.MyCats)
               CusPetInfo.Text += cat.Name + " : " + cat.MakeSound() + Environment.NewLine;

           foreach(Dog dog in cus.MyDogs)
               CusPetInfo.Text += dog.Name + " : " + dog.MakeSound() + Environment.NewLine;
           */
            foreach (Pet pet in cus.MyPets)
            {
                CusPetInfo.Text += pet.Name + " : " + pet.MakeSound();

                //is ������ = bool�� return �Ѵ�.
                if (pet is Cat)
                {
                    CusPetInfo.Text += " : " + (pet as Cat).Scratch();
                }
                else if(pet is Dog)
                {
                    CusPetInfo.Text += " : " + (pet as Dog).Bite();
                }

                CusPetInfo.Text += Environment.NewLine;

            }
        }

        private void CusList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string firstName = (string)CusList.Rows[e.RowIndex].Cells[0].Value;

            foreach (Customer cus in Customers)
            {
                if (cus.FirstName == firstName)
                {
                    ShowDetails(cus);
                    break;
                }
            }
            CusDetailPanel.Show();
            CusNewPanel.Hide();

            /*
            for (int index = 0; index < CustomerArrayIndex; index++)
            {
                if (CustomerArray[index].FirstName == firstName)
                {
                    ShowDetails(CustomerArray[index]);
                    break;
                }

            }*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CusListPanel.Dock = DockStyle.Fill;
            CusDetailPanel.Dock = DockStyle.Right;
            CusNewPanel.Dock = DockStyle.Right;

            Customer cus = new Customer("Ian", "Na", new DateTime(1990, 1, 2));
            Cat cat = new Cat(1, "Lucas", "White", "Male");
            cus.Adopt(cat);
            Cat cat2 = new Cat(3, "Ruby", "Brawn", "Male");
            cus.Adopt(cat2);

            Dog dog = new Dog(2, "Happy", "Black", "Male", DogBreed.Yorkshire);
            cus.Adopt(dog);

            Customers.Add(cus);
            CusList.Rows.Add(cus.FirstName, cus.Age, cus.IsQulified);

           

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CusNewPanel.Show();
            CusDetailPanel.Hide();

            /*
            //ũ�Ⱑ �־������Ѵٴ� ����
            Customer[] cusArray = new Customer[10];
            cusArray[0] = new Customer("First", "Last", new DateTime(2000, 2, 2));
        
            foreach ( Customer cus in cusArray) {
                string fullName = cus.FullName;
            }

            //����ȯ�� �Ͼ�ߵȴٴ� ����
            ArrayList cusArrayList = new ArrayList();
            cusArrayList.Add(new Customer("First", "Last", new DateTime(2000, 2, 2)));

            //���� ���� ���
            List<Customer> cusList = new List<Customer>();
            cusList.Add(new Customer("First", "Last", new DateTime(2000, 2, 2)));
            */

        }

    }
}
