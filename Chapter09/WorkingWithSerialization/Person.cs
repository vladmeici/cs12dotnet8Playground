using System.Xml.Serialization; // To use [XmlAttribute].

namespace Packt.Shared;

public class Person
{
    // A parameterless constructor is required for serialization.
    public Person() { }

    public Person(decimal initialiSalary)
    {
        Salary = initialiSalary;
    }

    [XmlAttribute("fname")]
    public string? FirstName { get; set; }
    [XmlAttribute("lname")]
    public string? LastName { get; set; }
    [XmlAttribute("dob")]
    public DateTime DateOfBirth { get; set; }
    public HashSet<Person>? Children { get; set; }
    protected decimal Salary { get; set; }
}