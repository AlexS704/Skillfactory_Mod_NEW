namespace Task.Mod._13._3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contact> phoneBook = new List<Contact>()
            {
               new Contact ("Иванов", 1, "A123" ),
            };

            Console.WriteLine("Введите Имя: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Введите Телефон: ");
            int userPhone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите Почту: ");
            var userMail = Console.ReadLine();

            Contact contact = new Contact(userName, userPhone, userMail);
           
            //List<Contact> phoneBook;

            AddUnique(contact, phoneBook);
            
        }

        private static void AddUnique(Contact newContact, List<Contact> phoneBook)
        {
            bool alreadyExists = false;

            foreach (var contact in phoneBook)
            {
                if (contact.Name == newContact.Name
                    & contact.PhoneNumber == newContact.PhoneNumber
                    & contact.Email == newContact.Email)
                {
                    alreadyExists = true;
                    break;
                }                
            }

            if (!alreadyExists)
                phoneBook.Add(newContact);

            phoneBook.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));

            foreach (var contact in phoneBook)
            {
                Console.WriteLine(contact.Name + ": " + contact.PhoneNumber + ": "
                    + contact.Email + ": ");
            }
        }
    }
}
