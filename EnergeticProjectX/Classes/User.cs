using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace UserControl
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Column("User_Id")]
        public long User_Id { get; set; }
        [Column("Login")]
        public string? Login { get; set; }
        [Column("Password")]
        public string? Password { get; set; }
        [Column("UserRole")]
        public string? UserRole { get; set; }
    }
}
