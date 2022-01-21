using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAjaxWithRazor.Models;


namespace TestAjaxWithRazor.Data
{
  public class TestDbContext
  {
     public DbSet<Product> DbProducts { get; set; }
  }
}
