using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDataBase.Domain.Entities
{
    public enum TypeOfUsers
    {
        admin,
        doctor,
        user
    }
    public class users: Person
    {
        
        [Required(ErrorMessage = "Please enter your Username")]
        public string username { get; set; }
        [Required(ErrorMessage = "Please enter your Password")]
        public string password { get; set; }
        public TypeOfUsers userType { get; set; }
    }
}
