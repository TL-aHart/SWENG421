/*
 * File: Owner.cs
 * Course: SWENG 421
 * Due: 1/29/26
 *
 * Description: represents the company owner, which communicates with and evaluates employees
 */
using System;
using System.Collections.Generic;

public class Owner : Person {
    public Owner(string name, int age) : base(name, age, "Owner") { }

    private void send(string message, IEnumerable<Employee> employees) {
        foreach (var e in employees) {
            Console.WriteLine($"Owner sends '{message}' to {e.Name}");
        }
    }

    public void SendMessage(string message, IEnumerable<Employee> employees) {
        send(message, employees);
    }

    public void Evaluate(Employee employee, int score) {
        Console.WriteLine($"Owner evaluates {employee.Name} with score {score}");
    }
}
