using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test1.Clases
{
    public class LinQ2
    {
        List<Student> _student = new List<Student>(){
            new(){Id = 1234, Name = "Batman", Age = 25},
            new(){Id = 2345, Name = "Arrow", Age = 30},
            new(){Id = 3456, Name = "Flash", Age = 28},
            new(){Id = 4567, Name = "Superman", Age = 33}
        };

        public void PrintData(){
            var Teenagers = _student.Where(s => s.Age > 12 && s.Age <28).ToList<Student>();
            Teenagers.ForEach(TP => Console.WriteLine($"{TP.Name}"));
        }

        public void ConsultaQuery(){
            var Student = (from estudiante in _student where estudiante.Age > 20 && estudiante.Age <33 select (estudiante.Id, estudiante.Name)).ToList();
            // foreach (var estudiant in Student)
            // {
            //     Console.WriteLine($"Estudiante = {estudiant}");
                
            // }
            Student.ForEach(item => Console.WriteLine($"Id = {item.Id}, Name = {item.Name}"));
        }

        public void ConsultIndexEvenNumber(){
            var Estudiantes = _student.Where((s, i) =>{
                if (i%2 == 0){
                    return true;
                }
                return false;
            }).ToList();
            Estudiantes.ForEach(x => Console.WriteLine($"{x.Name}"));
        }

        public void OrderByUser(){
            Console.WriteLine($"1. Ascendente\n2. Descendente\nElije una opción para ordenar los estudiantes : ");
            var result = Console.ReadLine();
            if (result == "1"){
                var Ascendente = (from s in _student orderby s.Name select s).ToList();
                Ascendente.ForEach(s => Console.WriteLine($"{s.Name}"));
            }
            else if (result == "2"){
                var Descendente = (from k in _student orderby k.Name descending select k).ToList();
                Descendente.ForEach(s => Console.WriteLine($"{s.Name}"));
            }
            else
            {
                Console.WriteLine($"No Escogiste ninguna de las opciones");
                
            }
        }
    }
}