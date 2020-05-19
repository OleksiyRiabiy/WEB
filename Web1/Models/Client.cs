using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web1.Models
{
    [Table("client", Schema = "public")]
    public class Client
    {
        [Key] public int id { get; set; }
        [Required] public string firstname { get; set; }
        [Required] public string lastname { get; set; }
        [Required] public string email { get; set; }
        [Required] public string password { get; set; }
        [Required] public string role { get; set; }

        public Client()
        {
            
        }
        public Client(int id, string firstname, string lastname, string email, string password, string role)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.password = password;
            this.role = role;
        }
    }
}