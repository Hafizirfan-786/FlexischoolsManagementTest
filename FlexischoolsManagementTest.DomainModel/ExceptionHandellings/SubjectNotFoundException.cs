using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexischoolsManagement.Domain.Exceptions
{
    public sealed class SubjectNotFoundException : NotFoundException
    {
        public SubjectNotFoundException(int id)
            : base($"The Subject with the id {id} was not found.")
        {
        }
    }
}
