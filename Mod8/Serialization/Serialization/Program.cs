// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
namespace Serialization
{
    [Serializable]
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Pet(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //объект для сериализации
            var pet = new Pet("Rex", 2);
            Console.WriteLine("Объект создан");

            //Сериализация
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var jsonString = JsonSerializer.Serialize(pet, options);
            File.WriteAllText("myPets.json", jsonString);
            Console.WriteLine("Объект сериализован");

            //Дессериализация
            jsonString = File.ReadAllText("myPets.json");
            var newPet = JsonSerializer.Deserialize<Pet>(jsonString);
            Console.WriteLine("Объект десериализован");
            Console.WriteLine($"Имя: {newPet.Name} ----------Возраст: {newPet.Age}");

            //------------------------------------------------------------------------

            Contact contact = new Contact("Иван", 79995554563, "sd@gmail.com");
            Console.WriteLine("Объект contact создан");

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("Contact.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, contact);
                Console.WriteLine("Объект contact сериализован");
            }


            using(FileStream fs = new FileStream("contact.dat", FileMode.Open.Opencrea))
            {

            }

        }
    }

    [Serializable]
    public class Contact
    {
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string name, long phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }


}