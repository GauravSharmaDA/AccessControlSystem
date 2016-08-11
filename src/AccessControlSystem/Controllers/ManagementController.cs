using AccessControlSystem.Core;
using AccessControlSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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
            var model = new ServerModel();
            model.AccessPolicies = _dbContext.Policies.ToList();
            model.Departments = _dbContext.Departmetns.ToList();
            model.ServerTypes = _dbContext.ServerTypes.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddServer(ServerModel serverModel)
        {
            return RedirectToAction("Index", "Home");
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
