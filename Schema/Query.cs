using AutoFixture;

namespace GraphQL_Demo.Schema;

public class Query
{
    private Fixture _fixture = new Fixture();
    
    public IEnumerable<CourseType> GetCourses()
    {
        var fakeCourses = _fixture.Create<IEnumerable<CourseType>>();
        return fakeCourses;
    }

    public CourseType GetCourseById(Guid courseId)
    {
        var fakeCourse = _fixture.Create<CourseType>();
        return fakeCourse;
    }
        
    [GraphQLDeprecated("Deprecated Query")]
    public string Instructions => "Some Instructions";
}