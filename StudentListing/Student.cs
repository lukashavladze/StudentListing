using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace StudentListing
{
    public class Student
    {
        
        public int? Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        [ForeignKey(nameof(ProfessorId))]
        public int ProfessorId { get; set; }
     
        public Professor professor { get; set; }
    }

}
