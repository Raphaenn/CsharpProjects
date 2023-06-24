using System;
using System.Xml.Serialization;
using Packet.Share;
using NfeEntity;
using System.Diagnostics;

namespace WorkingWithDeserializing
{
    public class XmlFile
    {
        public static void Deserializing(string path)
        {
            // create object that will format a list of Person as Xml
            XmlSerializer xs = new(typeof(List<Person>));
            using (FileStream xmlLoad = File.Open(path, FileMode.Open))
            {
                // deserialize and cast the object grath into a List
                List<Person>? loadPeople = xs.Deserialize(xmlLoad) as List<Person>;
                if (loadPeople is not null)
                {
                    foreach (Person p in loadPeople)
                    {
                        Console.WriteLine($"{p.FirstName} has {p.Children?.Count ?? 0}");
                    }
                }
            }
        }

        public static void DeserializeNfe(string path)
        {
            Stopwatch sw = Stopwatch.StartNew();
            XmlSerializer xs = new(typeof(NFe));

            using (FileStream reader = File.Open(path, FileMode.Open))
            {
                NFe? loadingNfe = xs.Deserialize(reader) as NFe;

                Console.WriteLine("Dados da Nota Fiscal:");
                Console.WriteLine("Número: " + loadingNfe?.infNFe.ide.nNF);
                Console.WriteLine("CNPJ Destinatário: " + loadingNfe?.infNFe.dest.CNPJ);
                Console.WriteLine("Nome Destinatário: " + loadingNfe?.infNFe.dest.xNome);
                Console.WriteLine("Nome produto: " + loadingNfe?.infNFe.det.prod.xProd);
            }

            sw.Stop();

            Console.WriteLine("Time taken: {0}ms", sw.Elapsed.TotalMilliseconds);
        }
    }
}

