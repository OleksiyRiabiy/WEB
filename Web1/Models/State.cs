using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web1.Models
{  [Table("state", Schema = "public")]
    public class State
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public int area { get; set; }
        [Required]
        public string population { get; set; }
        [Required]
        public string language { get; set; }

        public State()
        {
            
        }

        public State(int id, string name, int area, string population, string language)
        {
            this.id = id;
            this.name = name;
            this.area = area;
            this.population = population;
            this.language = language;
        }

        public override string ToString()
        {
            return $"{nameof(id)}: {id}, {nameof(name)}: {name}, {nameof(area)}: {area}, {nameof(population)}: {population}, {nameof(language)}: {language}";
        }
    }
    
}