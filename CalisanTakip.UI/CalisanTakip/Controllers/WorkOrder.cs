using CalisanTakip.BusinessEngine.Contracts;
using CalisanTakip.Common.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CalisanTakip.Controllers
{
    public class WorkOrder : Controller
    {
        private readonly IWorkOrderBusinessEngine _workOrderBusinessEngine;

        public WorkOrder(IWorkOrderBusinessEngine workOrderBusinessEngine)
        {
            _workOrderBusinessEngine = workOrderBusinessEngine;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(WorkOrderVM model)
        {
            return View();
        }
    }
}
