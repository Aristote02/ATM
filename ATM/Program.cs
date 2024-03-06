namespace Atm
{
    class Program
    {
        static void Main(string[] args)
        {
            void PrintOptions()
            {
                Console.WriteLine("Please choose one of the following options ...");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show balance");
                Console.WriteLine("4. Exit");
            }
            void Deposit(CardHolder currentUser)
            {
                Console.WriteLine("How much $$ would you like to deposit : ");
                double deposit = Double.Parse(Console.ReadLine());
                currentUser.setBalance(currentUser.getBalance() + deposit);
                Console.WriteLine("Thank you for your $$ . Your new balance is : " + currentUser.getBalance());
            }
            void Withdraw(CardHolder currentUser)
            {
                Console.WriteLine("How much $$ would you like to Withdraw :");
                double withdrawl = Double.Parse(Console.ReadLine());
                // Check if the user has enough money
                if (currentUser.getBalance() < withdrawl)
                {
                    Console.WriteLine("Insufficient Balance :( ");
                }
                else
                {
                    currentUser.setBalance(currentUser.getBalance() - withdrawl);
                    Console.WriteLine("You are good to go! Thank you :) ");
                }
            }
            void Balance(CardHolder currentUser)
            {
                Console.WriteLine("Current Balance : " + currentUser.getBalance());
            }
            List<CardHolder> cardHolders = new List<CardHolder>();
            cardHolders.Add(new CardHolder("1202200013001611", 0212, "Aristote", "Dilomba", 150.02));
            cardHolders.Add(new CardHolder("9143562092666576", 8952, "Daniel", "Grealish", 300.004));
            cardHolders.Add(new CardHolder("4856753049049983", 6754, "Bula", "Tolisso", 280.50));
            cardHolders.Add(new CardHolder("1234634377492384", 5783, "Joe", "Mbomba", 680));
            cardHolders.Add(new CardHolder("4787634377493785", 9385, "Gedeon", "Mbungu", 500));
            cardHolders.Add(new CardHolder("4377634377492092", 1230, "Josh", "Ndayi", 600));
            cardHolders.Add(new CardHolder("4377634377494938", 8743, "Athanas", "Apotre", 450.50));
            cardHolders.Add(new CardHolder("4377634377452723", 2201, "Caleb", "Ndayi", 1000));
            cardHolders.Add(new CardHolder("4377634377491111", 0645, "Christian", "Kama", 120));
            cardHolders.Add(new CardHolder("4377634377492123", 0458, "Nastia", "DVD", 890));
            cardHolders.Add(new CardHolder("4377634377496493", 2015, "Jacob", "Jacob", 900));
            cardHolders.Add(new CardHolder("4377634377497832", 2001, "Andre", "Dilomba", 699));
            cardHolders.Add(new CardHolder("4377634377493235", 1998, "Cedrick", "Bosantu", 1600));
            cardHolders.Add(new CardHolder("4377634377490932", 2004, "Benjamin", "Dilomba", 140.02));
            cardHolders.Add(new CardHolder("43776343774938745", 2006, "Rosy", "Rosy", 200.67));
            cardHolders.Add(new CardHolder("43776343774977433", 2002, "Nathan", "Musoko", 999.99));

            //prompt user
            Console.WriteLine("Welcome To Belarus Simple ATM");
            Console.WriteLine("Please insert your debit Card : ");
            string debitCardNumber = " ";
            CardHolder currentUser;

            while (true)
            {
                try
                {
                    debitCardNumber = Console.ReadLine();
                    //check again our DB
                    currentUser = cardHolders.FirstOrDefault(a => a.CardNumber == debitCardNumber);
                    if (currentUser != null) { break; }
                    else { Console.WriteLine("Card not recognized. Please try again"); }
                }
                catch { Console.WriteLine("Card not recognized. Please try again"); }
            }
            Console.WriteLine("Enter your pin :");
            int userPin = 0;

            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());

                    if (currentUser.getPin() == userPin) { break; }
                    else { Console.WriteLine("Incorrect Pin. Please try again"); }
                }
                catch { Console.WriteLine("Incorrect Pin. Please try again"); }
            }

            Console.WriteLine("Welcome " + currentUser.getFirstName() + " :) ");
            int option = 0;
            do
            {
                PrintOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { }
                if (option == 1) { Deposit(currentUser); }
                else if (option == 2) { Withdraw(currentUser); }
                else if (option == 3) { Balance(currentUser); }
                else if (option == 4) { break; }
                else { option = 0; }
            }

            while (option != 4);
            { Console.WriteLine("Thank you. have a nice day :) "); }
        }
    }
    public class CardHolder
    {
        public string CardNumber;
        int Pin;
        string FirstName;
        string LastName;
        double Balance;

        public CardHolder(string cardNumber, int pin, string firstName, string lastName, double balance)
        {
            CardNumber = cardNumber;
            Pin = pin;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }
        public string getNum()
        {
            return CardNumber;
        }
        public int getPin()
        {
            return Pin;
        }
        public string getFirstName()
        {
            return FirstName;
        }
        public string getLastName()
        {
            return LastName;
        }
        public double getBalance()
        {
            return Balance;
        }
        public void setNum(string newcardnumber)
        {
            CardNumber = newcardnumber;
        }
        public void setPin(int newPin)
        {
            Pin = newPin;
        }
        public void setFirstName(string newfirstName)
        {
            FirstName = newfirstName;
        }
        public void setLastName(string newlastName)
        {
            LastName = newlastName;
        }
        public void setBalance(double newbalance)
        {
            Balance = newbalance;
        }
    }
}