namespace StudentListing
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public Professor professor { get; set; }
    }

}
