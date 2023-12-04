using System;

namespace OOP_Generic_in_C_sharp
{
    public class Employee
    {
        // properties for employees
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }


        // employee object constructor
        public Employee(int id, string name, string gender, double salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        /*

        By overriding the ToString() method in Employee class, it can define how
        an instance of the Employee class should be represented as a string.
        In this case, the overridden ToString() method returns a string that
        includes the ID, Name, Gender, and Salary of the employee formatted in
        a specific way.
         
        */
        public override string ToString()
        {
            return $"ID = {Id}, Name = {Name}, Gender = {Gender}, Salary = {Salary}";
        }
    }

}