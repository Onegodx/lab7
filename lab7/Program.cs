// Миньков Владимир 22исп2-1 Базовый уровень
public class Program
{
    public static void Main()
    {
        List<Employee> employees = new List<Employee>() {
            new Employee() { LastName = "Eddie", Age = 32, Position = "Junior Dev.", Degree = Employee.Education.Master  },
            new Employee() { LastName = "Andrew", Age = 27, Position = "Middle Dev.", Degree = Employee.Education.Master  },
            new Employee() { LastName = "Maria", Age = 35, Position = "Middle Dev.", Degree = Employee.Education.None  },
            new Employee() { LastName = "Thomas", Age = 40, Position = "Middle Dev.", Degree = Employee.Education.None  },
            new Employee() { LastName = "Alexandra", Age = 23, Position = "Junior Dev.", Degree = Employee.Education.None  }
        };

        var query = from e in employees where e.Age > 30 && e.Degree == Employee.Education.None select e;
        foreach (var item in query)
        {
            Console.WriteLine(string.Format("Last Name = {0} \t Position = {1} \t Age = {2} \t Degree = {3}", item.LastName, item.Position, item.Age, item.Degree));
        }
    }
}

struct Employee
{
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
    public Education Degree { get; set; }

    public enum Education { None, Bachelor, Master }
}
