using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestAjaxWithRazor.Models;

namespace TestAjaxWithRazor.Pages.SalesPage
{
   //Code Sampled from:
   // https://learningprogramming.net/net/asp-net-core-razor-pages/ajax-in-asp-net-core-razor-pages/
  public class IndexModel : PageModel
  {
    public void OnGet()
    {
    }

    public IActionResult OnGetDemo1()
    {
      return new JsonResult("Hello");
    }

    public IActionResult OnGetDemo2(string fullName)
    {
      return new JsonResult("Hi " + fullName);
    }

    public IActionResult OnGetDemo3()
    {
      var product = new Product
      {
        Id = "p01",
        Name = "name 1",
        Price = 4.5
      };
      return new JsonResult(product);
    }

    public IActionResult OnGetDemo4()
    {
      var products = new List<Product>
            {
                new Product {
                    Id = "p01",
                    Name = "name 1",
                    Price = 4.5
                },
                new Product {
                    Id = "p02",
                    Name = "name 2",
                    Price = 7
                },
                new Product {
                    Id = "p03",
                    Name = "name 3",
                    Price = 9
                }
            };
      return new JsonResult(products);
    }
  }
}
