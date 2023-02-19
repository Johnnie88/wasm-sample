using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace WasmSampleBlazorApp.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateUserRequest
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <param name="Name">The name of user to add.</param>
        [MinLength(8, ErrorMessage = "Please, isert a minimun of {1}.")]
        [MaxLength(150, ErrorMessage = "Please, insert a maximum of {1}.")]
        [Required(ErrorMessage = "Please inform the a your name.")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <param name="Email">The email of user to add.</param>
        [EmailAddress(ErrorMessage = "Please, insert an valid email address.")]
        [Required(ErrorMessage = "Please inform the a your email.")]
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <param name="Password">The password of user to add.</param>
        [MinLength(8, ErrorMessage = "Please, isert a minimun of {1}.")]
        [MaxLength(20, ErrorMessage = "Please, insert a maximum of {1}.")]
        [Required(ErrorMessage = "Please, isert the password.")]
        public string? Password { get; set; }

        /// <summary>
        /// Gets or sets the password confirm.
        /// </summary>
        /// <param name="PasswordConfirm">The password of user to add.</param>
        [Compare("Password", ErrorMessage = "The password not match.")]
        [MinLength(8, ErrorMessage = "Please, isert a minimun of {1}.")]
        [MaxLength(20, ErrorMessage = "Please, insert a maximum of {1}.")]
        [Required(ErrorMessage = "Please, isert the password.")]
        public string? PasswordConfirm { get; set; }
    }
}
