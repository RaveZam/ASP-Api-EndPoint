using System.ComponentModel.DataAnnotations;
namespace MauiApi.Models
{
    public class StudentGrade
    {
        public int Id { get; set; } 
        public string fName { get; set; }
        public string lName { get; set; }
        public string middleName { get; set; }
        public int Grade { get; set; } 
    }
}
