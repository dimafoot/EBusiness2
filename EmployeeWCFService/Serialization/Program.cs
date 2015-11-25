using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Serialization
{
    [DataContract]
    public class Person
    {
        [DataMember(Name ="FName",Order =1)]
        public string Nom { get; set; }
        [DataMember(Name = "LName",Order =2)]
        public string Prenom { get; set; }
        [DataMember(Name = "Age",Order =3)]
        public int Age { get; set; }
    }


    class Program
    {
        static void Main()
        {
            var moi = new Person
            {
                Nom = "LAMGHARI",
                Prenom = "Mohammed",
                Age = 27
            };

            var serializer = new DataContractSerializer(moi.GetType());
            var someRam = new MemoryStream();
            serializer.WriteObject(someRam, moi);
            someRam.Seek(0, SeekOrigin.Begin);


            Console.WriteLine(Encoding.ASCII.GetString(someRam.GetBuffer()));
            Console.WriteLine(
                XElement.Parse(
                    Encoding.ASCII.GetString(someRam.GetBuffer()).Replace("\0", "")));
            Console.Read();
        }
    }
}
