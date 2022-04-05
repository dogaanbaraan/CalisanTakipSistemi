using CalisanTakip.BusinessEngine.Contracts;
using CalisanTakip.Common.ConstantsModel;
using CalisanTakip.Common.SessionOperations;
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
    }
}
