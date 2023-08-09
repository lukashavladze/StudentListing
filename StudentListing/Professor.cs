using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace StudentListing
{
    public class Professor
    {
        
        public int? Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }  
        
        //public IList<Student> Students { get; set; }
    }
}
