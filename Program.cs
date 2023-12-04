using System;
using System.Collections.Generic;


namespace OOP_Generic_in_C_sharp;

class Program
{
    static void Main(string[] args)
    {
        // Part 1: Stack
        Stack<Employee> employeeStack = new Stack<Employee>();

        // Pushing five objects into the stack
        Employee emp1 = new Employee(1, "John", "Male", 5000);
        employeeStack.Push(emp1);

        Employee emp2 = new Employee(2, "Saroshee", "Female", 6000);
        employeeStack.Push(emp2);

        Employee emp3 = new Employee(3, "Jane", "Female", 5500);
        employeeStack.Push(emp3);

        Employee emp4 = new Employee(4, "Salam", "Male", 10000);
        employeeStack.Push(emp4);

        Employee emp5 = new Employee(5, "Beth", "Female", 15000);
        employeeStack.Push(emp5);


        // printing all objects from stack
        Console.WriteLine("Stack objects: ");
        foreach (var employee in employeeStack)
        {
            Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary}");
            Console.WriteLine($"Items left in the stack: {employeeStack.Count}");
        }

        // popping all objects from stack
        Console.WriteLine("\nPopped objects: ");
        while (employeeStack.Count > 0)
        {
            var poppedEmployee = employeeStack.Pop();
            Console.WriteLine($"Id: {poppedEmployee.Id}, Name: {poppedEmployee.Name}, Gender: {poppedEmployee.Gender}, Salary: {poppedEmployee.Salary}");
            Console.WriteLine($"Items left in the stack: {employeeStack.Count}");
        }

        // Pushing objects again
        employeeStack.Push(emp1);
        employeeStack.Push(emp2);
        employeeStack.Push(emp3);
        employeeStack.Push(emp4);
        employeeStack.Push(emp5);


        // Peeking objects using peek method
        Console.WriteLine("\nPeeking two objects: ");
        for (int i = 0; i < 2; i++)
        {
            Employee employee = employeeStack.Peek();
            Console.WriteLine(employee);
            Console.WriteLine($"Items left in stack: {employeeStack.Count}");
        }

        // Checking whether object 3 is in the stack or not

        var targetEmployee = emp3;
        Console.WriteLine($"\nChecking if employee 3, {emp3.Name}, object exists in the stack or not:");
        if (employeeStack.Contains(targetEmployee))
        {
            Console.WriteLine($"{targetEmployee.Name} object exists in the stack");
        }
        else
        {
            Console.WriteLine($"{targetEmployee.Name} object does not exist in the stack");
        }



        // Part 2 - List
        List<Employee> employeeList = new List<Employee>
        {
            emp1, emp2, emp3, emp4, emp5
        };

        // Checking if Employee no 2 object exists in the list
        var containsEmp2 = employeeList.Contains(emp2);
        Console.WriteLine($"\nEmployee 2 {(containsEmp2 ? "exists" : "does not exist")} in the list");

        // Finding the first item in the list with Gender = "Male", using Find() method
        var firstMaleEmployee = employeeList.Find(e => e.Gender == "Male");
        Console.WriteLine($"\nFirst male Employee in the list: Id: {firstMaleEmployee.Id}, Name: {firstMaleEmployee.Name}, Gender: {firstMaleEmployee.Gender}, Salary: {firstMaleEmployee.Salary}");

        // Finding all items in the list with Gender = "Male", using FindAll() method
        var maleEmployees = employeeList.FindAll(e => e.Gender == "Male");
        Console.WriteLine("\nAll male Employees in the list: ");
        foreach (var maleEmployee in maleEmployees)
        {
            Console.WriteLine($"Id: {maleEmployee.Id}, Name: {maleEmployee.Name}, Gender: {maleEmployee.Gender}, Salary: {maleEmployee.Salary}");
        }

        Console.ReadLine();
    }
}
