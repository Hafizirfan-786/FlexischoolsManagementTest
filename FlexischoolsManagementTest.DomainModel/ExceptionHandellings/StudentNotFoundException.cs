using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexischoolsManagement.Domain.Exceptions
{
    public sealed class StudentNotFoundException : NotFoundException
    {
        public StudentNotFoundException(int id)
            : base($"The student with the id {id} was not found.")
        {
        }
    }
}
