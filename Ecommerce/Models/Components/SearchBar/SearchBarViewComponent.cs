using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BaseApp.Models.Components.SearchBar
{
    
    public class SearchBarViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke(string placeholder = "")
        {
            var model = new SearchBarViewModel
            {
                Placeholder = placeholder
            };
            return View(model);
        }
    }
}