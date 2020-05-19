using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web1.Models

{   [Table("state_client", Schema = "public")]
    public class StateClient
    {
        [Key]
        public int id { get; set; }
        
        public int client_id { get; set; }
        
        public int state_id { get; set; }
    }
}