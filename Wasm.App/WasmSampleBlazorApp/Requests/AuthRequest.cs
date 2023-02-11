using System.ComponentModel.DataAnnotations;

namespace WasmSampleBlazorApp.Requests
{
    /// <summary>
    /// The auth request.
    /// </summary>
    public class AuthRequest
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        [EmailAddress(ErrorMessage = "Please, insert an valid email address.")]
        [Required(ErrorMessage = "Please inform the a your email.")]
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        [MinLength(8, ErrorMessage = "Please, isert a minimun of {1}.")]
        [MaxLength(20, ErrorMessage = "Please, insert a maximum of {1}.")]
        [Required(ErrorMessage = "Please, isert the password.")]
        public string? Password { get; set; }
    }
}
