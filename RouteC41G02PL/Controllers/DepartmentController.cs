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
           // var department = _departmentRepo;
            return View();
        }
    }
}
