using System;
using WorkingWithDeserializing;
using static System.Environment;
using static System.IO.Path;

namespace WorkingWithDeserializing;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // xml Person file
        //var inst = new XmlFile();
        //string pathDirectory = GetFolderPath(SpecialFolder.Personal);
        //string path = Combine(pathDirectory, "people.xml");
        //inst.Deserializing(path);

        // nf xml file
        var start = new XmlFile();
        string pathDirectory = GetFolderPath(SpecialFolder.Personal);
        string path = Combine(pathDirectory, "notaFiscal.xml");
        Console.WriteLine(path);
        XmlFile.DeserializeNfe(path);
    }
}

