using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EmployeeApp.Models
{
    public class LoginModel
    {
        [Required]
        [JsonPropertyName("Username")]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}
