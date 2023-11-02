using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace menucsharp.Module
{
    public class Curso
    {
        public string Name { get; set; }

        public List<Person> Students { get; set; }

        public void AddStudent(Person student)
        {
            Students.Add(student);
        }

        public int GetNumberOfStudents()
        {
            int size = Students.Count;
            return size;
        }
        public bool RemoveStudent(Person student)
        {
            return Students.Remove(student);
        }

        public void ListingStudents (){
            Console.WriteLine($"Alunos do curso de : {Name}");

            for (int i = 0; i >= Students.Count; i++)
            {
                Console.WriteLine($"N {i+1} - {Students[i].FullName}");
            }

        }
    }
}