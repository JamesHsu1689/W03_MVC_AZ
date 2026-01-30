using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace W02_EF.Pages;

public class IndexModel : PageModel
{
    public void OnGet()
    {
        ViewData["Name"] = "James Hsu";
    }
}
