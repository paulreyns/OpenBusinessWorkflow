using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Embedded.Models;

namespace Embedded.Pages;

public class IndexModel : PageModel
{
    private readonly ClaimStore _store = new ClaimStore();
    public List<Claim> _claims = new List<Claim>();

    public void OnGet()
    {
        _claims = _store.List();
    }
}

