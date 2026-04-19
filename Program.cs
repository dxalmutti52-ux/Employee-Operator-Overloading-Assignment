using System;

namespace OperatorOverloadAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create first Employee object and assign values
            Employee emp1 = new Employee();
            emp1.Id = 1;
            emp1.FirstName = "John";
            emp1.LastName = "Smith";

            // Create second Employee object and assign values
            Employee emp2 = new Employee();
            emp2.Id = 1;
            emp2.FirstName = "Jane";
            emp2.LastName = "Doe";

            // Compare the two Employee objects using overloaded operators
            bool equalResult = emp1 == emp2;     // Uses overloaded ==
            bool notEqualResult = emp1 != emp2;  // Uses overloaded !=

            // Display results in the console
            Console.WriteLine("emp1 == emp2: " + equalResult);
            Console.WriteLine("emp1 != emp2: " + notEqualResult);

            Console.ReadLine(); // Pause console
        }
    }
}
