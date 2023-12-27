using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginAndRegistrationPage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }
        public IActionResult OnPostSignUp()
        {
            // Redirect to the signup page
            return RedirectToPage("/signup");
        }
    }
}