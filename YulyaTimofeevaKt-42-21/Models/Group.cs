using System.Text.RegularExpressions;
using System.Text.Json.Serialization;

namespace YulyaTimofeevaKt_42_21.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        [JsonIgnore]
        public List<Subject>? Subject { get; set; }
        public bool IsValidGroupName()
        {
            return Regex.Match(GroupName, @"\D*-\d*-\d\d").Success;
        }
    }
}