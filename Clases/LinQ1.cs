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

        List<Student> _students = new List<Student>(){
            new(){Id = 1234, Name = "Batman", Age = 25, StandardId = 1},
            new(){Id = 2345, Name = "Arrow", Age = 30, StandardId = 1},
            new(){Id = 3456, Name = "Flash", Age = 28, StandardId = 2},
            new(){Id = 4567, Name = "Superman", Age = 33}
        };
        List<Standard> _Standard = new(){
            new(){StandardId = 1, StandardName = "Standard 1"},
            new(){StandardId = 2, StandardName = "Standard 2"},
            new(){StandardId = 3, StandardName = "Standard 3"}
        };

        public void JoinList(){
            // var InnerJoin = _students.Join(
            //     _Standard,
            //     student => student.StandardId,
            //     standard => standard.StandardId,
            //     (student, standard) => new {
            //         Name = student.Name,
            //         StandardName = standard.StandardName
            //     }
            // );
            var innerQuery = (from s in _students
                            join st in _Standard
                            on s.StandardId equals st.StandardId
                            select  new {
                                Name = s.Name,
                                StandardName = st.StandardName
                            }).ToList();
            innerQuery.ForEach(x => Console.WriteLine($"{new{x.Name, x.StandardName}}"));
        }
    }
}