using System.ComponentModel.DataAnnotations;

namespace MowAPI
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string address { get; set; } = string.Empty;
        public int age { get; set; } = int.MinValue;
        public string allergies { get; set; } = string.Empty; 
        public string conditions { get; set; } = string.Empty; 
        public int currentMeal { get; set; } = int.MinValue;
    }
}
