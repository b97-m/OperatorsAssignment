using System;

// Define the Employee class
class Employee
{
    // Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the "==" operator to compare employees based on Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        return emp1.Id == emp2.Id;
    }

    // Overload the "!=" operator to complement the "==" operator
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }
}

class Program
{
    static void Main()
    {
        // Create two Employee objects
        Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee employee2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Doe" };

        // Check if the employees are equal using the overloaded "=="
        if (employee1 == employee2)
        {
            Console.WriteLine("Employees are equal.");
        }
        else
        {
            Console.WriteLine("Employees are not equal.");
        }

        // Check if the employees are not equal using the overloaded "!="
        if (employee1 != employee2)
        {
            Console.WriteLine("Employees are not equal.");
        }
        else
        {
            Console.WriteLine("Employees are equal.");
        }
    }
}