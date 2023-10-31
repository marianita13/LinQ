using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test1.Clases
{
    public class LinQ1
    {
        List<string> Books = new List<string>(){
            "Vb.Net Tutorial",
            "C# Tutorial",
            "TypeScript e-book"
        };

        public IEnumerable<string> ListBooksByName(string criterio){
            return Books.Where(x => x.Contains(criterio));
        }

        public void PrintData(){
            Console.WriteLine("Ingrese el criterio de busqueda: ");
            string Criterio = Console.ReadLine();
            IEnumerable<string> data = ListBooksByName(Criterio);
            
            Console.Clear();
            foreach (string item in data)
            {
                Console.WriteLine($"Se encontro : {item}");
            }
        }

        public void Query(){
            Console.WriteLine("Ingrese el criterio de busqueda: ");
            string Criterio = Console.ReadLine();
            var expre = from libro in Books where Books.Contains(Criterio) select libro;
            List<string> result = expre.ToList();
            result.ForEach(s => Console.WriteLine($"Se encontro : {s}"));
        }
    }
}