using System.ComponentModel.DataAnnotations;

namespace PushDeck.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}