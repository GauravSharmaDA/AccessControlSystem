using AccessControlSystem.Core;
using Microsoft.AspNetCore.Mvc;

namespace AccessControlSystem.Controllers
{
    public class ManagementController : Controller
    {
        private AccessControlSystemContext _dbContext;

        public ManagementController(AccessControlSystemContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult AddServer()
        {
            return View();
        }

        public IActionResult AddAccessPolicy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAccessPolicy(AccessPolicy accessPolicy)
        {
            _dbContext.Policies.Add(accessPolicy);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }


        public IActionResult AddServerType()
        {
            return View();
        }
    }
}
