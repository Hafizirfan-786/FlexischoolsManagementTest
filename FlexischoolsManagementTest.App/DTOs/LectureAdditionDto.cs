using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexischoolsManagement.Application.DTOs
{
    public class LectureAdditionDto
    {
        public int Id { get; set; }
        public required WeeklyScheduleDto WeeklySchedule { get; set; }
        public int SubjectId { get; set; }
        public int LectureTheatreId { get; set; }
    }
}
