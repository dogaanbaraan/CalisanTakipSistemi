using CalisanTakip.BusinessEngine.Contracts;
using CalisanTakip.Common.ConstantsModel;
using CalisanTakip.Common.SessionOperations;
using CalisanTakip.Common.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Linq;

namespace CalisanTakip.Controllers
{
    public class EmployeeLeaveRequestController : Controller
    {
        private readonly IEmployeeLeaveRequestBusinessEngine _employeeLeaveRequestBusinessEngine;
        private readonly IEmployeeLeaveTypeBusinessEngine _employeeLeaveTypeBusinessEngine;

        public EmployeeLeaveRequestController(IEmployeeLeaveRequestBusinessEngine employeLeaveRequestBusinessEngine, IEmployeeLeaveTypeBusinessEngine employeeLeaveTypeBusinessEngine)
        {
            _employeeLeaveRequestBusinessEngine = employeLeaveRequestBusinessEngine;
            _employeeLeaveTypeBusinessEngine = employeeLeaveTypeBusinessEngine;
        }
        public IActionResult Index()
        {
            var user = JsonConvert.DeserializeObject<SessionContext>(HttpContext.Session.GetString(ResultConstant.LoginUserInfo));

            var requestModel = _employeeLeaveRequestBusinessEngine.GetAllLeaveRequestByUserId(user.LoginId);
            ViewBag.EpmloyeeLeaveType = _employeeLeaveTypeBusinessEngine.GetAllEmployeeLeaveType();

            if (requestModel.IsSuccess)
            {
                return View(requestModel.Data);
            }

            return View(user);
        }


        public IActionResult Create()
        {
            ViewBag.EmployeeLeaveTypes = _employeeLeaveTypeBusinessEngine.GetAllEmployeeLeaveType().Data;
            //ViewBag.EmployeeLeaveTypes = data.Data.Select(q=>new SelectListItem
            //{
            //    Text = q.Name,
            //    Value = q.Id.ToString(),
            //});
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeLeaveRequestVM model, int? id)
        {
            var user = JsonConvert.DeserializeObject<SessionContext>(HttpContext.Session.GetString(ResultConstant.LoginUserInfo));
            if (id > 0)
            {
                var data = _employeeLeaveRequestBusinessEngine.EditEmployeeLeaveRequest(model, user);
                return RedirectToAction("Index");
            }
            else
            {
                var data = _employeeLeaveRequestBusinessEngine.CreateEmployeeLeaveRequest(model, user);

                if (data.IsSuccess)
                {
                    return RedirectToAction("Index");
                }

                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            ViewBag.EmployeeLeaveTypes = _employeeLeaveTypeBusinessEngine.GetAllEmployeeLeaveType().Data;
            if (id > 0)
            {
                var data = _employeeLeaveRequestBusinessEngine.GetAllLeaveRequestById((int)id);
                return View(data.Data);
            }
            else
                return View();
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return Json(new { success = false, message = "Silmek için bir kayıt seçiniz" });

            var data = _employeeLeaveRequestBusinessEngine.RemoveEmployeeLeaveRequest(id);
            if (data.IsSuccess)
            {
                return Json(new { success = data.IsSuccess, message = data.Message });

            }
            else
            {
                return Json(new { success = data.IsSuccess, message = data.Message });
            }


        }
    }
}
