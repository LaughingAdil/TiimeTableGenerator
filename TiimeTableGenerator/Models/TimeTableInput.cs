namespace TiimeTableGenerator.Models
{
    public class TimeTableInput
    {
        public int Id { get; set; }
        public int NumberOfClassRooms { get; set; }
        public int NumberOfPeriods { get; set; }
        public int NumberOfSubjects { get; set; } = 0;
        public List<Subject> Subjects { get; set; } = new List<Subject>();
    }
}
