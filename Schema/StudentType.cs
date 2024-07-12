namespace GraphQL_Demo.Schema;

public class StudentType
{
    public Guid Id { get; set; }
    public string? FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public double GPA { get; set; }
}   