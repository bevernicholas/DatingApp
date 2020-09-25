using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForLoginDto
    {
        public string UserName {get; set;}
        public string PassWord{get; set;}
    }
}