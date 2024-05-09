using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Embedded.Models;

namespace Embedded.Pages;

public class EditModel : PageModel
{
    // Services
    private readonly ClaimStore store = new ClaimStore();
    
    // Properties
    [BindProperty]
    public Guid Id { get; set; } = Guid.Empty;

    [BindProperty]
    public string Name { get; set; } = string.Empty;

    public void OnGet(Guid id)
    {
        var claim = store.Get(id);
        if (claim != null)
        {
            Id = claim.Id;
            Name = claim.Name;
        }
    }

    public IActionResult OnPost()
    {
        var claim = store.Get(Id);
        claim.Name = Name;
        store.Set(claim);
        return Redirect("/");
    }
}

