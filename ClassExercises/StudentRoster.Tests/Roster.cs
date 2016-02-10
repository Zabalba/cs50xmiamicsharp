using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public string Gender { get; set; }
}
public class Roster
{
    public List<Student> Students { get; set; }

    public Roster()
    {
        Students = new List<Student>();
    }
    public void Add(Student stu)
    {
        Students.Add(stu);
    }
}
