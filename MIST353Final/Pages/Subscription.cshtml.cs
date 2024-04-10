using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MIST353Final.Pages
{
    public class SubscriptionModel : PageModel
    {
        private readonly ILogger<SubscriptionModel> _logger;

        public SubscriptionModel(ILogger<SubscriptionModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
