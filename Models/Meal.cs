using System.ComponentModel.DataAnnotations;

namespace MowAPI
{
    public class Meal
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }


    }
}
