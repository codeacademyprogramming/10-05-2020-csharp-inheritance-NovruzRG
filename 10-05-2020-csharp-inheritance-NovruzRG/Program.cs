using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10_05_2020_csharp_inheritance_NovruzRG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose mode - basic, pro, expert");
            string mode = Console.ReadLine().ToLower();

            DocumentProgram docProgram = new DocumentProgram();
            switch (mode)
            {
                case "basic":
                    docProgram = new DocumentProgram();
                    docProgram.OpenDocument();
                    docProgram.EditDocument();
                    docProgram.SaveDocument();
                    break;
                case "pro":
                    docProgram = new ProDocumentProgram();
                    docProgram.OpenDocument(); 
                    docProgram.EditDocument();
                    docProgram.SaveDocument();
                    break;
                case "expert":
                    docProgram = new ExpertDocument();
                    docProgram.OpenDocument();
                    docProgram.EditDocument();
                    docProgram.SaveDocument();
                    break;
                default:
                    Console.WriteLine("Wrong mode");
                    break;
            }

        }



        class DocumentProgram
        {
            public void OpenDocument()
            {
                Console.WriteLine("Document Opened");
            }
            public virtual void EditDocument()
            {
                Console.WriteLine("Can Edit in Pro and Expert versions");
            }
            public virtual void SaveDocument()
            {
                Console.WriteLine("Can Save in Pro and Expert versions");
            }
        }

        class ProDocumentProgram : DocumentProgram
        {
            public sealed override void EditDocument()
            {
                Console.WriteLine("Document Edited");
            }

            public override void SaveDocument()
            {
                Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
            }
        }

        class ExpertDocument : ProDocumentProgram
        {
            public override void SaveDocument()
            {
                Console.WriteLine("Document Saved in pdf format");
            }
        }

    }
}
