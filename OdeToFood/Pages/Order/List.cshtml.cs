using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace OdeToFood.Pages.Order
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;

        public string Message { get; set; }
        public string MessageFromAppsettings { get; set; }

        public ListModel(IConfiguration config)
        {
            this.config = config;
        }
        public void OnGet()
        {
            Message = "Hello, world!";
            MessageFromAppsettings = config["Message"];
        }
    }
}
