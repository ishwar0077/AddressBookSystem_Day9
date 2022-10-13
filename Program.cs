namespace AddressBookSystemProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBook person = new AddressBook();
            person.CreateAddressBook("Ishwar", "Rathod","Telgaon", "Wadwani", "Maharastra", "4321131", "9146422222", "ishwar.demo@gmail.com");
        }
    }
}