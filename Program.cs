using Basics.OOPS.AbstractClass;
using Basics.OOPS.Encapsulation;
using Basics.OOPS.Inheritance;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //Encapulation 
            /*
            Document document; Console.WriteLine("Enter Doc Name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Doc Type");
            var type  = Console.ReadLine();
            Console.WriteLine("Enter Doc Content");
            var content = Console.ReadLine();
            document = new Document(name, type, content);
            document.GetDocument();
            Console.WriteLine("Enter new Content");
            var newcontent = Console.ReadLine();
            document.SetDocument(newcontent);
            */


            //Inheritance
            /*   Console.WriteLine("Enter Doc Name");
  var name = Console.ReadLine();
  Console.WriteLine("Enter Doc Type");
  var type = Console.ReadLine();
  Console.WriteLine("Enter Doc Content");
  var content = Console.ReadLine();
  Basics.OOPS.Inheritance.Document document=new OOPS.Inheritance.WordDoc(name,type,content);
  document.DisplayDoc(name);
  Basics.OOPS.Inheritance.Document Pdocument=new OOPS.Inheritance.PDFDoc(name,type,content);
  Pdocument.DisplayDoc(name);
*/

            //ABstract Class
            //Console.WriteLine("Enter Doc Name");
            //var name = Console.ReadLine();
            //Console.WriteLine("Enter Doc Content");
            //var content = Console.ReadLine();
            //Basics.OOPS.AbstractClass.Document doc = new Basics.OOPS.AbstractClass.WordDoc();
            //doc.PrintDocument("hi word");
            //doc = new Basics.OOPS.AbstractClass.PDFDoc();
            //doc.PrintDocument("hi pdf");
            Console.WriteLine("Enter Doc Name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Doc Content");
            var content = Console.ReadLine();
            /* Basics.OOPS.Interfaces.WordDoc doc = new OOPS.Interfaces.WordDoc(name);
             Basics.OOPS.Interfaces.pdfDoc pdoc = new OOPS.Interfaces.pdfDoc(name);
             doc.OpenDoc(name);
             doc.EditDoc("new");
             doc.CloseDoc();

             pdoc.OpenDoc(name);
             pdoc.SaveAs("new path");
             pdoc.CloseDoc();
            */
            //Abstraction
            /* OOPS.Abstraction.Document document = new OOPS.Abstraction.WordDoc();
             OOPS.Abstraction.Document pdocument = new OOPS.Abstraction.PdfDoc();
             document.Display();
             pdocument.Display();
            */

            //Serialization
            /*Basics.Serialization.Document document = new Basics.Serialization.Document("Test","content");
            var formatter = new BinaryFormatter();

            using (var stream = new FileStream("document.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, document);
                Console.WriteLine("Document serialized successfully.");
            }

            //Deserialiaze
            Basics.Serialization.Document deserializedDocument;
            using (var stream = new FileStream("document.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                deserializedDocument = (Basics.Serialization.Document)formatter.Deserialize(stream);
                Console.WriteLine("Document deserialized successfully.");
                Console.WriteLine($"Title: {deserializedDocument.Title}, Content: {deserializedDocument.Content}");
            }
            */


            //Reflection
            /* Type documentType = typeof(Basics.Reflection.Document);

             // Create an instance of the Document class
             Basics.Reflection.Document doc = (Basics.Reflection.Document)Activator.CreateInstance(documentType, "My Reflection Document");

             // Invoke the Display method on the Document instance
             MethodInfo displayMethod = documentType.GetMethod("Display");
             displayMethod.Invoke(doc, null);

             // Get the Title property value
             PropertyInfo titleProperty = documentType.GetProperty("Title", BindingFlags.Public | BindingFlags.Instance);
             string title = (string)titleProperty.GetValue(doc);

             Console.WriteLine($"Retrieved title through reflection: {title}");
            */

            //BoxingUnBoxing
            /*
            // Example of boxing
            int licenseCount = 5; // Value type
            object boxedLicenseCount = licenseCount; // Boxing: converting int to object
            Console.WriteLine($"Boxed licenseCount: {boxedLicenseCount}");

            // Storing in a non-generic collection
            ArrayList mixedData = new ArrayList();
            mixedData.Add(boxedLicenseCount); // Adding boxed value to the collection
            mixedData.Add("DMS Document"); // Adding a reference type directly

            // Example of unboxing
            int unboxedLicenseCount = (int)mixedData[0]; // Unboxing: converting object back to int
            Console.WriteLine($"Unboxed licenseCount: {unboxedLicenseCount}");
            */


            //RefOut

            int licenseCount = 5;

            Console.WriteLine($"Original license count: {licenseCount}");

            UpdateLicenseCount(ref licenseCount); // Passing by reference
            Console.WriteLine($"Updated license count: {licenseCount}");

            GetLicenseCount(out licenseCount); // No need to initialize licenseCount
            Console.WriteLine($"License count: {licenseCount}");

        }

        public static void GetLicenseCount(out int count)
        {
            count = 20; // Directly assigning a value
        }


        public static void UpdateLicenseCount(ref int count)
        {
            count += 10; // Modifying the passed argument
        }
    }

}
 
