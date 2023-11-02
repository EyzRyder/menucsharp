using System.Reflection;
using menucsharp.Module;

string studentName, studentLastName;
string select;
bool showMenu = true;
Curso cursoDio = new Curso();
cursoDio.Name = "Dio";
cursoDio.Students = new List<Person>();

while (showMenu)
{
  Console.Clear();
  Console.WriteLine("Digite a sua opção: ");
  Console.WriteLine("1 - Somar");
  Console.WriteLine("2 - Subtrair");
  Console.WriteLine("3 - Dividir");
  Console.WriteLine("4 - Multiplicar");
  Console.WriteLine("5 - Adicionar Estudante");
  Console.WriteLine("6 - Remover Estudante");
  Console.WriteLine("7 - Listar Estudante");
  Console.WriteLine("0 - Sair");

  select = Console.ReadLine();

  switch (select)
  {
    case "1":
      Calc.sum();
      break;
    case "2":
      Calc.sub();
      break;
    case "3":
      Calc.divid();
      break;
    case "4":
      Calc.mult();
      break;
    case "5":
      Console.WriteLine("Escreva nome do estudante:");
      studentName = Console.ReadLine();
      Console.WriteLine("Escreva sobrenome do estudante:");
      studentLastName = Console.ReadLine();
      Person newStudent = new Person(name: studentName, lastName: studentLastName);
      newStudent.Age = 18;
      Console.WriteLine(newStudent.FullName);

      cursoDio.AddStudent(newStudent);
      Console.Read();
      break;
    case "6":
      Console.WriteLine("Escreva nome do estudante:");
      studentName = Console.ReadLine();
      Console.WriteLine("Escreva sobrenome do estudante:");
      studentLastName = Console.ReadLine();
      Person student = new Person(name: studentName, lastName: studentLastName);
      cursoDio.RemoveStudent(student);

      Console.Read();

      break;
    case "7":
      cursoDio.ListingStudents();
      Console.Read();
      break;
    case "0":
      Console.WriteLine("Encerrar");
      showMenu = false;
      // Environment.Exit(0);
      break;
    default:
      Console.WriteLine("Invalid inputs");
      break;
  }
}