namespace StudentListing
{
    public class Professor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public List<Student> Students { get; set; }
    }
}
