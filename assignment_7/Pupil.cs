namespace assignment_7
{
    public class Pupil
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Teacher> Teacher { get; set; }

    }
}
