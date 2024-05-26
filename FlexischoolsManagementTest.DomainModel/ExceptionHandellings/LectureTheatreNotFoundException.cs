using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexischoolsManagement.Domain.Exceptions
{
    public sealed class LectureTheatreNotFoundException : NotFoundException
    {
        public LectureTheatreNotFoundException(int id)
            : base($"The Lecture Theatre with the id {id} was not found.")
        {
        }
    }
}
