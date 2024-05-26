namespace FlexischoolsManagement.Domain.Exceptions
{
    public class CapacityExceedingException : Exception
    {
        public CapacityExceedingException(int id)
            : base($"The capacity of lecture theatre has exceed the limit. You cannot add students to the lecture with the id {id}.")
        {
        }
    }
}
