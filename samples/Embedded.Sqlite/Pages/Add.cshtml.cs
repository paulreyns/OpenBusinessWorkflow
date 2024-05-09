using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Embedded.Models;

namespace Embedded.Pages;

public class AddModel : PageModel
{
    private readonly ClaimStore _store = new ClaimStore();
    public Claim _claim = new Claim();

    public void OnGet()
    {
    }
}

