using Microsoft.AspNetCore.Mvc.RazorPages;

namespace repro_omnisharp_crash
{
    public class DashboardPageModel : PageModel
    {
        public string Stats { get; set; }
    }

    public class SomeOtherClass
    {
        public string Singer { get; set; }
    }
}
