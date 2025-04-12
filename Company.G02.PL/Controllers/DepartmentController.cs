using Company.G02.PL.Dtos;
using Company.GO2.BLL.Interfaces;
using Company.GO2.BLL.Repositories;
using Company.GO2.DAL.Models;
using Microsoft.AspNetCore.Http.HttpResults;
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

        [HttpGet]
        public IActionResult Datails(int? id)
        {
            if (id is null) return BadRequest("Invalid Id"); //400
            var department = _departmentRepository.Get(id.Value);
            if (department is null) return NotFound(new { StatusCode = 404, message = $"Department With Id :{id} is not fount" });
            return View(department);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id is null) return BadRequest("Invalid Id"); //400
            var department = _departmentRepository.Get(id.Value);
            if (department is null) return NotFound(new { StatusCode = 404, message = $"Department With Id :{id} is not fount" });
            return View(department);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([FromRoute] int id ,Depratment depratment)
        {
            if (ModelState.IsValid)
            {
                if (id != depratment.Id) return BadRequest();
                var count = _departmentRepository.Update(depratment);
                if (count > 0)
                {
                    return RedirectToAction(nameof (Index));
                }
            }
            return View(depratment);
        }

        [HttpGet]
        public IActionResult Delele(int? id)
        {
            if (id is null) return BadRequest("Invalid Id"); //400

            var department = _departmentRepository.Get(id.Value);

            if (department is null) return NotFound(new { StatusCode = 404, message = $"Department With Id :{id} is not fount" });

            return View(department);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delele([FromRoute] int id, Depratment depratment)
        {
            if (ModelState.IsValid)
            {
                if (id != depratment.Id) return BadRequest();
                var count = _departmentRepository.Delete(depratment);
                if (count > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(depratment);
        }
    }
}
