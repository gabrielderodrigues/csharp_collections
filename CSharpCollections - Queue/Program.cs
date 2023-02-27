using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections___Queue
{
    public class Program
    {
        static Queue<string> pedagio = new Queue<string>();

        public static void Main(string[] args)
        {
            // Entrou: van
            string van = "van";
            string kombi = "kombi";
            string guincho = "guincho";

            pedagio.Enqueue(van);
            pedagio.Enqueue(kombi);
            pedagio.Enqueue(guincho);

            pedagio.Dequeue();


            foreach (var item in pedagio)
            {
                Console.WriteLine("Fila: " + item); 
            }

            Console.ReadLine();
        }
    }
}
