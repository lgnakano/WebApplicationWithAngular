using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DataAccess;
using Microsoft.EntityFrameworkCore;



namespace WebApplication1.Controllers
{
    public class DbController : Controller
    {
        public ApplicationDbContext dbContext;

        public DbController(ApplicationDbContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
