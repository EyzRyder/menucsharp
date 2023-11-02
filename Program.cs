using System.Reflection;
using System.Globalization;
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
  Console.WriteLine("################################");
  Console.WriteLine("# Digite a sua opção:          #");
  Console.WriteLine("# 1 - Somar                    #");
  Console.WriteLine("# 2 - Subtrair                 #");
  Console.WriteLine("# 3 - Dividir                  #");
  Console.WriteLine("# 4 - Multiplicar              #");
  Console.WriteLine("# 5 - Adicionar Estudante      #");
  Console.WriteLine("# 6 - Remover Estudante        #");
  Console.WriteLine("# 7 - Listar Estudante         #");
  Console.WriteLine("# 8 - Ler Arquivo Surpresa     #");
  Console.WriteLine("# 0 - Sair                     #");
  Console.WriteLine("################################");

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
      break;
    case "8":
      try
      {
        string[] rows = File.ReadAllLines("Arquivo/text.txt");
        foreach (string row in rows)
        {
          Console.WriteLine(row);
        }
      }
      catch (FileNotFoundException ex)
      {
        Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo nao encontrado. {ex.Message}");
      }
      catch (DirectoryNotFoundException ex)
      {
        Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Pasta nao encontrado. {ex.Message}");
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
      }
      finally
      {
            Console.WriteLine("end of search");
      }
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
    Console.WriteLine("Pressione uma tecla para continuar");
  Console.ReadLine();
}
