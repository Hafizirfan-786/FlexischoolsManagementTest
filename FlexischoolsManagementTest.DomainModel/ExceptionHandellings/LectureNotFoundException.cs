
namespace FlexischoolsManagement.Domain.Exceptions
{
    public sealed class LectureNotFoundException : NotFoundException
    {
        public LectureNotFoundException(int id)
            : base($"The Lecture with the id {id} was not found.")
        {
        }
    }
}
