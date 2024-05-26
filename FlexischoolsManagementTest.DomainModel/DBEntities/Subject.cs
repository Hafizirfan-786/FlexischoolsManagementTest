using FlexischoolsManagement.Domain.Common;

namespace FlexischoolsManagement.Domain.Entities
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; }
        public List<Lecture> Lectures { get; set; } = new List<Lecture>();
        public List<Student> EnrolledStudents { get; set; }

        public Subject() => EnrolledStudents = new List<Student>();

        public bool CanEnroll(Student student)
        {
            if (Lectures.Count != 0 && !Lectures.Exists(lecture => lecture.LectureTheatre.CapacityExceeds()))
            {
                int totalMinutes = student.EnrolledSubjects.Sum(s => s.Lectures.Sum(l => l.Schedules.DurationInMinutes));
                if (totalMinutes + Lectures.Sum(l => l.Schedules.DurationInMinutes) > (10 * 60))
                {
                    return false;
                }

                return true;
            }

            return false;
        }
    }
}
