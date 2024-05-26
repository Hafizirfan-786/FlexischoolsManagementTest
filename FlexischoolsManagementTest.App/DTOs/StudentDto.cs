using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexischoolsManagement.Application.DTOs
{
    public class StudentDto
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public List<SubjectDto> EnrolledSubjects { get; set; } = new List<SubjectDto>();
    }
}
