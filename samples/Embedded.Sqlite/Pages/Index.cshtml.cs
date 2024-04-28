using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Embedded.Sqlite.Models;

namespace Embedded.Sqlite.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public readonly List<Claim> _claims;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        _claims = new List<Claim>();
        _claims.Add(new Claim());
    }

    public void OnGet()
    {
    }
}

