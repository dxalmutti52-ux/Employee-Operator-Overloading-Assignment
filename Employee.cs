using System;

namespace OperatorOverloadAssignment
{
    // Employee class with three properties
    public class Employee
    {
        public int Id { get; set; }          // Employee ID
        public string FirstName { get; set; } // Employee first name
        public string LastName { get; set; }  // Employee last name

        // Overload == operator to compare Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, they are equal
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;

            // If one is null and the other is not, they are not equal
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare Id values
            return emp1.Id == emp2.Id;
        }

        // Overload != operator (must be paired with ==)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals to match operator behavior
        public override bool Equals(object obj)
        {
            if (obj is Employee other)
                return this.Id == other.Id;

            return false;
        }

        // Override GetHashCode when overriding Equals
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
