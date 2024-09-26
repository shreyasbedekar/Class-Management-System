namespace CMS.UI.Models
{
    public interface ICourse
    {
        int TotalDurationInDays {get; set;}
        int TotalSubjects 
        {
            get
            {
                return Subjects.Count;
            }
        }

        List<CourseSubject> Subjects { get;}
        void AddSubject(CourseSubject subject);
        void RemoveSubject(CourseSubject subject);
        void AddSubject(List<CourseSubject> subjectName);

        int GetTotalElectives()
        {
            return 0;
        }

    }
}