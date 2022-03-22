using System;

namespace AddressBook
{
    class Program
    {

        //creating a new contact
        public List<Contact> person = new List<Contact>();

        private void NewPerson()
        {
            Contact contact = new Contact();

            Console.WriteLine("Enter the FirstName : ");
            contact.firstname = Console.ReadLine();

            Console.WriteLine("Enter the lastName : ");
            contact.lastname = Console.ReadLine();

            Console.WriteLine("Enter the address : ");
            contact.address = Console.ReadLine();

            Console.WriteLine("Enter the city : ");
            contact.city = Console.ReadLine();

            Console.WriteLine("Enter the state : ");
            contact.state = Console.ReadLine();

            Console.WriteLine("Enter the zipcode : ");
            contact.zipcode = Console.ReadLine();

            Console.WriteLine("Enter the email : ");
            contact.email = Console.ReadLine();

            Console.WriteLine("Enter the phoneNumber : ");
            contact.phoneNumber = Console.ReadLine();
            person.Add(contact);
            Console.WriteLine(contact);
        }

        //details of address book
        private void Print(Contact contact)
        {
            Console.WriteLine("-----Address book details-----");
            Console.WriteLine("First Name: " + contact.firstname);
            Console.WriteLine("Last Name: " + contact.lastname);
            Console.WriteLine("Address: " + contact.address);
            Console.WriteLine("City: " + contact.city);
            Console.WriteLine("State: " + contact.state);
            Console.WriteLine("Zip: " + contact.zipcode);
            Console.WriteLine("Email: " + contact.email);
            Console.WriteLine("phone Number: " + contact.phoneNumber);
        }

        static void Main(String[] args)
        {
            Console.WriteLine("Welcome To Address Book");
            Program names = new Program();
            names.NewPerson();
        }


    }
}