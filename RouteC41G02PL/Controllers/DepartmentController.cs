using Microsoft.AspNetCore.Mvc;
using RouteC41G02.BLL.interfaces;
using RouteC41G02.DAL.Models;

namespace RouteC41G02PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepo;

        public DepartmentController(IDepartmentRepository departmentRepo) 
        {
            _departmentRepo = departmentRepo;
        }
        public IActionResult Index()
        {
           var departments = _departmentRepo.GetAll();
            return View(departments);

        }
        [HttpGet]
        public IActionResult Create() { 
        
         return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
          if(ModelState.IsValid)
            {
                var Count = _departmentRepo.Add(department);
                    if(Count > 0)
                    return RedirectToAction(nameof(Index));

            }
          return View(department);
        }
    }
}
