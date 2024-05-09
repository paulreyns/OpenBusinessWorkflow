using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Embedded.Models;

namespace Embedded.Pages;

public class AddModel : PageModel
{
    // Services
    private readonly ClaimStore store = new ClaimStore();

    // Properties
    [BindProperty]
    public Guid Id { get; set; } = Guid.Empty;

    [BindProperty]
    public string Name { get; set; } = string.Empty;

    public void OnGet()
    {
        var claim = new Claim();
        Id = claim.Id;
        Name = claim.Name;
    }

    public IActionResult OnPost()
    {
        var claim = new Claim()
        {
            Id = Id,
            Name = Name
        };
        store.Set(claim);
        return Redirect("/");
    }
}

