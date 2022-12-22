using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAsp.Pages
{
    public class ContenedorModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public ContenedorModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}