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
            new(){Id = 4567, Name = "Superman", Age = 33},
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
    }
}