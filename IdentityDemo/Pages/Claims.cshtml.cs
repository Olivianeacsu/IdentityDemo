using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IdentityDemo.Pages
{
    [Authorize]
    public class ClaimsModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
