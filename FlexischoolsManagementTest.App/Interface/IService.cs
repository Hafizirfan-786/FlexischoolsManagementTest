namespace FlexischoolsManagement.Application.Contract
{
    public interface IService
    {
        IStudentService StudentService { get; }
        ISubjectService SubjectService { get; }
        ILectureService LectureService { get; }
        ILectureTheatreService LectureTheatreService { get; }
    }
}
