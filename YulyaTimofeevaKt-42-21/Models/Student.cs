using System.Text.Json.Serialization;

namespace YulyaTimofeevaKt_42_21.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Middlename { get; set; }
        public int GroupID { get; set; }
        [JsonIgnore]
        public Group? Group { get; set; }
    }
}