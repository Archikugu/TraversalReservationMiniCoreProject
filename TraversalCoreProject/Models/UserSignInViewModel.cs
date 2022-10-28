using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Please insert User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Please insert password")]
        public string Password { get; set; }
    }
}
