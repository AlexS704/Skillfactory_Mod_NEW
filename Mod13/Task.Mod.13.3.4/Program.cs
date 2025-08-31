using System.Diagnostics;

namespace Task.Mod._13._3._4
{
    internal class Program
    {
        //  Объявим словарь с двумя значениями
        private static SortedDictionary<string, Contact> PhoneBook = new()
        {
            ["Игорь"] = new Contact(79990000000, "igor@example.com"),
            ["Андрей"] = new Contact(79990000001, "andrew@example.com"),
        };
        static void Main(string[] args)
        {
            //List<Contact> phoneBook = new List<Contact>()
            //{
            //   new Contact ("Иванов", 1, "A123" ),
            //};

            //Console.WriteLine("Введите Имя: ");
            //string userName = Console.ReadLine();

            //Console.WriteLine("Введите Телефон: ");
            //int userPhone = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите Почту: ");
            //var userMail = Console.ReadLine();

            //Contact contact = new Contact(userName, userPhone, userMail);

            ////List<Contact> phoneBook;

            //AddUnique(contact, phoneBook);

            // Покажем весь список
            Console.WriteLine("Текущий список контактов: ");
            WriteAllContacts();

            // Попробуем добавить новый контакт, если такого ещё нет
            PhoneBook.TryAdd("Диана", new Contact(79160000002, "diana@example.com"));

            //  Выведем обновлённый список
            Console.WriteLine("Обновленный список контактов: ");
            WriteAllContacts();

            //  Попробуем достать контакт для изменения данных
            if (PhoneBook.TryGetValue("Диана", out Contact contact))
                contact.PhoneNumber = 79990000001;

            // И покажем результат после изменения
            Console.WriteLine("Список после изменения: ");
            WriteAllContacts();

            var stopWatch = Stopwatch.StartNew();

            PhoneBook.Add("Максим", new Contact(83456738377, "MAX342@MAIL.COM")); //Время выполнения: 0,263 для обычного словаря, для сортировочного 0,2707

            Console.WriteLine($"Время выполнения: {stopWatch.Elapsed.TotalMilliseconds}");

            Console.WriteLine("Обновленный список контактов: ");
            WriteAllContacts();
        }

        // Метод для вывода словаря на консоль
        public static void WriteAllContacts()
        {
            foreach (var contact in PhoneBook)
                Console.WriteLine(contact.Key + ": " + contact.Value.PhoneNumber);
            Console.WriteLine();
        }

    
        //private static void AddUnique(Contact newContact, List<Contact> phoneBook)
        //{
        //    bool alreadyExists = false;

        //    foreach (var contact in phoneBook)
        //    {
        //        if (contact.Name == newContact.Name
        //            & contact.PhoneNumber == newContact.PhoneNumber
        //            & contact.Email == newContact.Email)
        //        {
        //            alreadyExists = true;
        //            break;
        //        }                
        //    }

        //    if (!alreadyExists)
        //        phoneBook.Add(newContact);

        //    phoneBook.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));

        //    foreach (var contact in phoneBook)
        //    {
        //        Console.WriteLine(contact.Name + ": " + contact.PhoneNumber + ": "
        //            + contact.Email + ": ");
        //    }
        //}

        
    }
}
