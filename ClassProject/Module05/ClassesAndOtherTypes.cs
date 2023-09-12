namespace ClassesAndOtherTypes;

public static class CalculationUtility
{
    public static double EstimateGradeAverage(double gradeA, double gradeB)
    {
        Console.WriteLine("\nThe student's average grade is: ");
        return (gradeA + gradeB) / 2;
    }
}

public class AcademicSupplies
{
    private int Id;
    public string Description {get; set;}
    public int Quantity {get;}

    public AcademicSupplies(string description)
    {
        Id = 1;
        Description = description;
        Quantity = 3;
    }

    public void DisplayEducationalSuppliesInfo()
    {
        Console.WriteLine("\nAcademic Supplies Info");
        Console.WriteLine($"Id = {GetId()} | Description = {Description} | Quantity = {Quantity}");
    }

    public void SetId(int id)
    {
        Id = id;
    }
    public int GetId()
    {
        return Id;
    }
}

public class AddressInfo
{
    public required string Address {get; set;}
    public required string City {get; set;} 
    public required string Country {get; set;}
    
    public void DisplayAddressInfo()
    {
        Console.WriteLine("Address: " + Address);
        Console.WriteLine("City: " + City);
        Console.WriteLine("Country: " + Country);
    }
}

public class Student : AddressInfo
{
    public int StudentId {get; set;}
    public required string Name {get; set;}
    public string Email {get; set;}
    public string PhoneNumber {get; set;}

    public void DisplayIndividual()
    {
        Console.WriteLine("Student Id: " + StudentId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Phone Number:" + PhoneNumber);
    }
}

public class Employee : AddressInfo
{
    public required string EmployeeId {get; set;}
    public required string EmployeeName {get; set;}
    public required string Department {get; set;}
    public double Salary {get; set;}

    public void DisplayEmployee()
    {
        Console.WriteLine("Employee Id: " + EmployeeId);
        Console.WriteLine("Department: " + EmployeeName);
        Console.WriteLine("Department: " + Department);
        Console.WriteLine("Salary: US$" + Salary);
    }
}

public sealed class UniversityWebsite
{
    public required string WebsiteTitle {get; set;}
}

public abstract class TeamMascot
{
    public required string MascotName {get; set;}
    public required string Animal {get; set;}

    public abstract string GetInformations();

    public void DisplayMascotDetails()
    {
        Console.WriteLine("Name: " + MascotName);
        Console.WriteLine("Animal: " + Animal);
        Console.WriteLine("Informations: " + GetInformations());
    }
}

public class Basketball : TeamMascot
{
    public override string GetInformations()
    {
        return "Jack is the mascot of the basketball team.";
    }

    public new virtual void DisplayMascotDetails()
    {

        base.DisplayMascotDetails();
        Console.WriteLine("The team mascot can jump very high.");
    }
}

public record Course(int CourseId, string Description);

public class Professor
{
    public int ProfessorId {get; set;}
    public required string ProfessorName {get; set;}
}

public interface INotification
{
    string Description {get; set;}
    void Notify();
}

public class StudentNotification : INotification
{
    public string Description { get; set; }

    public void Notify()
    {
        Console.WriteLine("Notifying student.");
    }
}

public class ProfessorNotification : INotification
{
    public string Description { get; set; }

    public void Notify()
    {
        Console.WriteLine("Notifying professor.");
    }

    public void NotifyEveryone()
    {
        Console.WriteLine("Notifying everyone.\n");
    }
}