using CalisanTakip.BusinessEngine.Contracts;
using CalisanTakip.Common.PagingListModels;
using CalisanTakip.Common.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CalisanTakip.Controllers
{
    public class WorkOrderController : Controller
    {
        private readonly IWorkOrderBusinessEngine _workOrderBusinessEngine;

        public WorkOrderController(IWorkOrderBusinessEngine workOrderBusinessEngine)
        {
            _workOrderBusinessEngine = workOrderBusinessEngine;
        }

        public IActionResult Index(int pageNumber = 1)
        {
            var data = _workOrderBusinessEngine.GetAllWorkOrders();
            if (data.IsSuccess)
            {
                var model = PaginatedList<WorkOrderVM>.Create(data.Data, pageNumber, 1);
                return View(model);
            }
            else
                return View();

        }

        public IActionResult Create(WorkOrderVM model)
        {
            return View();
        }
    }
}
