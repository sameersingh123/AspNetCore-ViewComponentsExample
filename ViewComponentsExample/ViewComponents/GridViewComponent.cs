﻿using Microsoft.AspNetCore.Mvc;
using ViewComponentsExample.Models;

namespace ViewComponentsExample.ViewComponents
{
    public class GridViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(PersonGridModel grid)
        {

            return View(grid);  //invokes a partial view at Views/Shared/Components/Grid/Default.cshtml
        }
    }
}
