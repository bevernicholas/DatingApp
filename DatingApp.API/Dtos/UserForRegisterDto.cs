using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName {get; set;}
        [Required]
        [StringLength(8, MinimumLength=4, ErrorMessage="Please specify password between 4 and 8 characters")]
        public string PassWord{get; set;}
    }
}