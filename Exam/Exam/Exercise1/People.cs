namespace Exam.Exercise1;

public class People
{
    public string Name { get; set; } 
    public bool Gender { get; set; } 
    public int Age { get; set; } 
    
    public People(string name, bool gender, int age)
    {
        Name = name;
        Gender = gender;
        Age = age;
    }
    
    public void DisplayDetails()
    {
        string genderString = Gender ? "Male" : "Female";
        Console.WriteLine($"Person details: Name = {Name}, Gender = {genderString}, Age = {Age}");
    }
    
    public void IncrementAge(int years)
    {
        Age += years;
    }
}
public class Program
{
    public static void Main()
    {
        People person = new People("Trung", true, 25);
        person.DisplayDetails();
        person.IncrementAge(10);
        person.DisplayDetails();
    }
}