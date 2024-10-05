using System.Diagnostics;
using System.Text.Json.Serialization;

namespace YulyaTimofeevaKt_42_21.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int GroupId { get; set; }
        [JsonIgnore]
        public Group? Group { get; set; }
    }
}
