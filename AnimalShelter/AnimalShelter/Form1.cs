namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        public Customer[] CustomerArray = new Customer[10];
        public int CustomerArrayIndex = 0;

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

            //증가가 되고 대입이 된다. 따라서 Two = 2 One = 2
            numberTwo = ++numberOne;
            //대입이 되고 증가가 된다. 따라서 Two = 1 One = 2
            numberTwo = numberOne++;
            */

            CustomerArray[CustomerArrayIndex] = new Customer(CusNewFirstName.Text, CusNewLastName.Text, DateTime.Parse(CusNewBirthday.Text));
            CustomerArray[CustomerArrayIndex].Address = CusNewAddress.Text;
            CustomerArray[CustomerArrayIndex].Description = CusNewDescription.Text;

            CustomerList.Items.Add(CustomerArray[CustomerArrayIndex].FirstName);

            CustomerArrayIndex++;

        }


        private void ShowDetails(Customer cus)
        {
            CusFullName.Text = cus.FullName;
            CusAge.Text = cus.Age.ToString();
            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            CusIsQualified.Text = cus.IsQulified.ToString();
        }

        private void CustomerList_Click(object sender, EventArgs e)
        {
            string firstName = CustomerList.SelectedItem.ToString();
            for(int index = 0; index < CustomerArrayIndex; index++)
            {
                if (CustomerArray[index].FirstName == firstName)
                {
                    ShowDetails(CustomerArray[index]);
                    break;
                }

            }
        }
    }
}
