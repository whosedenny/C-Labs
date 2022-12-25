using System;
using System.Security.Cryptography.X509Certificates;

namespace LW11_2;
class Program
{
    public delegate bool StudentPredicateDelegate(Student student);
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>{
            new Student("Anton", "Antonko", 1),
            new Student("Vova", "Vovko", 14),
            new Student("Kolya", "Kol'ko", 43),
            new Student("Dima", "Dimko", 22),
            new Student("Denis", "Denko", 31),
            new Student("Vlad", "Vladko", 15),
            new Student("Alex", "Alko", 61),
            new Student("Misha", "Mishko", 32),
            new Student("Kostya", "Kostko", 62),
            new Student("Vitalik", "Vitko", 20)
        };

        Student student = new Student();

        StudentPredicateDelegate studentPredicateDelegate_FirstName = student.CheckFirstName;
        StudentPredicateDelegate studentPredicateDelegate_LastName = student.CheckLastName;
        StudentPredicateDelegate studentPredicateDelegate_Age = student.CheckAge;

        List<Student> ResultList_FirstName = students.FindStudent(studentPredicateDelegate_FirstName);
        List<Student> ResultList_LastName = students.FindStudent(studentPredicateDelegate_LastName);
        List<Student> ResultList_Age = students.FindStudent(studentPredicateDelegate_Age);

        foreach (var item in ResultList_FirstName)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Age);
        }
        Console.WriteLine("\n--------------------------------\n");

        foreach (var item in ResultList_LastName)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Age);
        }
        Console.WriteLine("\n--------------------------------\n");

        foreach (var item in ResultList_Age)
        {
            Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Age);
        }
    }
}