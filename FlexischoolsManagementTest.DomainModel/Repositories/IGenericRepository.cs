
namespace FlexischoolsManagement.Domain.Repositories
{
    public interface IGenericRepository
    {
        IStudentRepository StudentRepository { get; }
        ISubjectRepository SubjectRepository { get; }
        ILectureRepository LectureRepository { get; }
        ILectureTheatreRepository LectureTheatreRepository { get; }
        IUnitOfWork UnitOfWork { get; }
    }
}
