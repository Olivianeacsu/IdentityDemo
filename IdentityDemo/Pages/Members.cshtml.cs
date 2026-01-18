using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IdentityDemo.Pages
{
    [Authorize]
    public class MembersModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
