namespace YulyaTimofeevaKt_42_21.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Middlename { get; set; }
        public int GroupID { get; set; }
        public Group Group { get; set; }
    }
}