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
