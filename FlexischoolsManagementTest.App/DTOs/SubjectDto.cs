using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexischoolsManagement.Application.DTOs
{
    public class SubjectDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<LectureDto> Lectures { get; set; } = new List<LectureDto>();
    }
}
