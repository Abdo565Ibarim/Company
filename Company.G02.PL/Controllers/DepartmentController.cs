using Company.G02.PL.Dtos;
using Company.GO2.BLL.Interfaces;
using Company.GO2.BLL.Repositories;
using Company.GO2.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Company.G02.PL.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public IActionResult Index()
        {
            var departments = _departmentRepository.GetALL();
            return View(departments);
        }

        [HttpGet]
        public IActionResult Create ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateDepartmentDto model)
        {
            if(ModelState.IsValid)
            {
                var department = new Depratment()
                {
                    Code = model.Code,
                    Name = model.Name,
                    CreateAt = model.CreateAt,
                };
                 var conut = _departmentRepository.Add(department);
                if(conut > 0)
                {
                    return RedirectToAction("Index");
                }
            }

            return View(model);
        }
    }
}
