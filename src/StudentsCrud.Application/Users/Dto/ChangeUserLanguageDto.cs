using System.ComponentModel.DataAnnotations;

namespace StudentsCrud.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}