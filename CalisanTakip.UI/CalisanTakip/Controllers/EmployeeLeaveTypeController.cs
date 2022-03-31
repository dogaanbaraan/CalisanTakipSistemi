using CalisanTakip.BusinessEngine.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CalisanTakip.Controllers
{
    public class EmployeeLeaveTypeController : Controller
    {
        private readonly IEmployeeLeaveTypeBusinessEngine _employeeLeaveTypeBusinessEngine;

        public EmployeeLeaveTypeController(IEmployeeLeaveTypeBusinessEngine employeeLeaveTypeBusinessEngine)
        {
            _employeeLeaveTypeBusinessEngine = employeeLeaveTypeBusinessEngine;
        }
        public IActionResult Index()
        {
            var data = _employeeLeaveTypeBusinessEngine.GetAllEmployeeLeaveType();
            if(data.IsSuccess)
            {
                var result = data.Data;
                return View(result);
            }
            return View();
        }
    }
}
