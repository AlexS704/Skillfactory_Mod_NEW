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
            

        }
    }
        
    

}


   

