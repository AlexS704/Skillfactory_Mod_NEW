using System.Runtime.CompilerServices;
using System.Text;


[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

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

//public class BinarySerializer : IBinaryFormatter<Contact>
//{
//    public byte[] Serialize(Contact contact)
//    {
//        using MemoryStream stream = new MemoryStream();
//        using BinaryWriter writer = new BinaryWriter(stream);

//        writer.Write(contact.Name);
//        writer.Write(contact.PhoneNumber);
//        writer.Write(contact.Email);

//        return stream.ToArray();
//    }

//    public Contact Deserialize(byte[] bytes)
//    {
//        using MemoryStream stream = new MemoryStream(bytes);
//        using BinaryReader reader = new BinaryReader(stream);

//        string name = reader.ReadString();
//        long phoneNumber = reader.ReadInt64();
//        string email = reader.ReadString();

//        return new Contact(name, phoneNumber, email);
//    }
//}





namespace Serialization_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Contact contact = new Contact("Ivan", 89991112254, "dadad@faf.com");
            //BinarySerializer serializer = new BinarySerializer();

            //byte[] bytes = serializer.Serialize(contact);
            //Contact deserializedContact = serializer.Deserialize(bytes);

            //Console.WriteLine($"Name: {deserializedContact.Name}");
            //Console.WriteLine($"PhoneNumber: {deserializedContact.PhoneNumber}";
            //Console.WriteLine($"Email: {deserializedContact.Email}");

        }
    }

}





