using System;


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
