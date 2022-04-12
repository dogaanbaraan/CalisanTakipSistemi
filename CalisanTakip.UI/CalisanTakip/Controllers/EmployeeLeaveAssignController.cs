using CalisanTakip.BusinessEngine.Contracts;
using CalisanTakip.Common.ConstantsModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace CalisanTakip.Controllers
{
    [Authorize(Roles = ResultConstant.Admin_Role)]
    public class EmployeeLeaveAssignController : Controller
    {
       
        private readonly IEmployeeLeaveAssignBusinessEngine _employeeLeaveAssignBusinessEngine;
        private readonly IEmployeeLeaveRequestBusinessEngine _employeeLeaveRequestBusinessEngine;
       

        public EmployeeLeaveAssignController(IEmployeeLeaveAssignBusinessEngine employeeLeaveAssignBusinessEngine, IEmployeeLeaveRequestBusinessEngine employeeLeaveRequestBusinessEngine)
        {
                _employeeLeaveAssignBusinessEngine = employeeLeaveAssignBusinessEngine;
            _employeeLeaveRequestBusinessEngine = employeeLeaveRequestBusinessEngine;   
        }
        public IActionResult Index()
        {
            var data = _employeeLeaveRequestBusinessEngine.GetSendApprovedRequests();
            if(data.IsSuccess)
            {
                return View(data.Data);
            }
            return View();
        }

        public IActionResult Approved(int id)
        {
            if(id<=0)
            {
                return Json( new{ success = false, message = "Onaylamak için kayıt seçiniz"});
            }

            var data = _employeeLeaveAssignBusinessEngine.ApprovedEmployeeRequest(id);
            if(data.IsSuccess)
                return Json(new { success = data.IsSuccess, message =data.Message});
            else
                return Json(new { success = data.IsSuccess, message = data.Message});    
        }
    }
}
