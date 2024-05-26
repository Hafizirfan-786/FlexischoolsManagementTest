
using FlexischoolsManagement.Domain.Common;
using System.ComponentModel.DataAnnotations;


namespace FlexischoolsManagement.Domain.Entities
{
    public class Lecture : BaseEntity
    {
        public Schedule Schedules { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public int LectureTheatreId { get; set; }
        public LectureTheatre LectureTheatre { get; set; }
    }

    public struct Schedule
    {
        public DayOfWeek DayOfWeek { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm:ss}")]
        public string StartTime { get; set; }
        public int DurationInMinutes { get; set; }
    }
}
