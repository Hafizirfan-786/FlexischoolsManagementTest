using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexischoolsManagement.Application.DTOs
{
    public class StudentAdditionDto
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
    }
}
