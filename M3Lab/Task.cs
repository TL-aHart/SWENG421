using System;
/*
 * File: Task.cs
 * Course: SWENG 421
 * Due: 1/29/26
 *
 * Description: defines a work task with an id, due date, and employee description
 */
public class Task
{
    private int id;
    private DateTime dueDate;
    private string description;

    public Task(int id, DateTime dueDate, string description) {
        this.id = id;
        this.dueDate = dueDate;
        this.description = description;
    }

    public int Id => id;
    public string Description => description;
}
