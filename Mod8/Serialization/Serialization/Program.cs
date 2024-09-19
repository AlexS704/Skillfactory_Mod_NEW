// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text;
using System.Runtime.CompilerServices;
using Serialization;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

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
            Contact contact = new Contact("Ivan", 89991112254,"dadad@faf.com");
            BinarySerializer serializer = new BinarySerializer();

            byte[] bytes = serializer.Serialize(contact);
            Contact deserializedContact = serializer.Deserialize(bytes);

            Console.WriteLine($"Name: {deserializedContact.Name}");
            Console.WriteLine($"PhoneNumber: {deserializedContact.PhoneNumber}";
            Console.WriteLine($"Email: {deserializedContact.Email}");
            

        }
    }
        
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

    public class BinarySerializer : IBinaryFormatter<Contact>
    {
        public byte[] Serialize(Contact contact)
        {
            using MemoryStream stream = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter(stream);

            writer.Write(contact.Name);
            writer.Write(contact.PhoneNumber);
            writer.Write(contact.Email);
            
            return stream.ToArray();
        }

        public Contact Deserialize(byte[] bytes)
        {
            using MemoryStream stream = new MemoryStream(bytes);
            using BinaryReader reader = new BinaryReader(stream);

            string name = reader.ReadString();
            long phoneNumber = reader.Readlong();
            string email = reader.ReadString();

            return new Contact(name, phoneNumber, email);
        }
    }

}


   

