namespace GraphQL_Demo.Schema;

// Define a schema for graphql
public class CourseType
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public IEnumerable<StudentType> Students { get; set; }
    public InstructorType Instructor { get; set; }
}