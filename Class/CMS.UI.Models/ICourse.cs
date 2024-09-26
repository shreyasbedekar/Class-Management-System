namespace CMS.UI.Models
{
    public interface ICourse
    {
        void AddSubject(CourseSubject subject);
        void RemoveSubject(CourseSubject subject);
        void AddSubject(List<CourseSubject> subjectName);

    }
}