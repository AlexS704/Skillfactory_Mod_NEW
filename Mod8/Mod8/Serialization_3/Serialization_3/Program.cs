using System;
using System.IO;
using System.Text;
using System.Text.Json;
using Google.Protobuf;
//using Platform.Serialization_3.Serialization_3;

namespace Serialization_3lization_3;
{
    class Program
    {
        static void Main(string[] args)
        {
            ////объект для сериализации
            //var pet = new Pet("Rex", 2);
            //Console.WriteLine("Объект создан");

            ////Сериализация
            //var options = new JsonSerializerOptions
            //{
            //    WriteIndented = true
            //};

            //var jsonString = JsonSerializer.Serialize(pet, options);
            //File.WriteAllText("myPets.json", jsonString);
            //Console.WriteLine("Объект сериализован");

            ////Дессериализация
            //jsonString = File.ReadAllText("myPets.json");
            //var newPet = JsonSerializer.Deserialize<Pet>(jsonString);
            //Console.WriteLine("Объект десериализован");
            //Console.WriteLine($"Имя: {newPet.Name} ----------Возраст: {newPet.Age}");

            ////------------------------------------------------------------------------


        }
    }

    public class CalculationService
    {
        public CalculationService() { }

        public string GetCalculationResult(string expression)
        {
            var contact = new Contact
            {
                Name = "John Doe",
                PhoneNumber = 1234566,
                Email = "fafagah.com"
            };
            using (var output = File.CreateText("contact.bin"))
            {
                const.WriteTo(output);
            }

            return contact.ToString();
        }
    }
}
