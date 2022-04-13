using CalisanTakip.BusinessEngine.Contracts;
using CalisanTakip.Common.PagingListModels;
using CalisanTakip.Common.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CalisanTakip.Controllers
{
    public class WorkOrderController : Controller
    {
        private readonly IWorkOrderBusinessEngine _workOrderBusinessEngine;
        private readonly IEmployeeBusinessEngine _employeeBusinessEngine;

        public WorkOrderController(IWorkOrderBusinessEngine workOrderBusinessEngine, IEmployeeBusinessEngine employeeBusinessEngine)
        {
            _employeeBusinessEngine = employeeBusinessEngine;
            _workOrderBusinessEngine = workOrderBusinessEngine;
        }

        public IActionResult Index(int pageNumber = 1)
        {
            var data = _workOrderBusinessEngine.GetAllWorkOrders();
            if (data.IsSuccess)
            {
                var model = PaginatedList<WorkOrderVM>.Create(data.Data, pageNumber, 3);
                return View(model);
            }
            else
                return View();

        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            ViewBag.EmployeeList = _employeeBusinessEngine.GetAllEmployee().Data;
            var data = _workOrderBusinessEngine.GetWorkOrder(id).Data;
            return View(data);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Edit(WorkOrderVM editModel)
        {
            var data = _workOrderBusinessEngine.EditWorkOrder(editModel);
            if (data.IsSuccess)
                return RedirectToAction("Index");
            return View();
        }

        [HttpPost]
        public IActionResult Create(WorkOrderVM model)
        {
            var result = _workOrderBusinessEngine.CreateWorkOrder(model);

            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            else
                return View();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return Json(new { success = false, message = "Silmek için Kayıt Seçiniz" });

            var data = _workOrderBusinessEngine.RemoveWorkOrder(id);
            if(data.IsSuccess)
                return Json(new {success = data.IsSuccess, message =data.Message});
            else
                return Json(new {success = data.IsSuccess, message = data.Message});

        }
    }
}
