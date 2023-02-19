using System.ComponentModel.DataAnnotations;

namespace WasmSampleBlazorApp.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class PasswordRecoveryRequest
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <param name="Email">The email of user to add.</param>
        [EmailAddress(ErrorMessage = "Please, imput a valid email.")]
        [Required(ErrorMessage = "Please, imput your email.")]
        public string? Email { get; set; }
    }
}
