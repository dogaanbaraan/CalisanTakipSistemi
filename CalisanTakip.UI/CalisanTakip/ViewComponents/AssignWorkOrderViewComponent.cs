using AutoMapper;
using CalisanTakip.BusinessEngine.Implementation;
using CalisanTakip.Common.ConstantsModel;
using CalisanTakip.Common.PagingListModels;
using CalisanTakip.Common.ViewModels;
using CalisanTakip.DataAccess.Contracts;
using CalisanTakip.DataAccess.DbModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CalisanTakip.ViewComponents
{
    public class AssignWorkOrderViewComponent : ViewComponent
    {
        #region Variables
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public AssignWorkOrderViewComponent(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        #endregion

        #region CustomMethod

        /// <summary>
        /// Employee Id Ve Status ıle Is Emrı Getırme(Atanmıs)
        /// </summary>
        /// <returns></returns>
        public async Task<IViewComponentResult> InvokeAsync(int pageNumber = 1)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claims = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var userFromDb = _uow.employeeRepository.GetFirstOfDefault(u => u.Id == claims.Value);
            var employeeId = userFromDb.Id;
            var workOrderStatus = (int)EnumWorkOrderStatus.Assigned;

            var data = _uow.workOrderRepository
                            .GetAll(u => u.AssignEmployeeId == employeeId && u.WorkOrderStatus == workOrderStatus).ToList();


            if (data != null)
            {
                List<WorkOrderVM> returnData = new List<WorkOrderVM>();
                foreach (var item in data)
                {
                    returnData.Add(new WorkOrderVM
                    {
                        AssignEmployeeName = item.AssignEmployee.Email,
                        WorkOrderNumber = item.WorkOrderNumber,
                        WorkOrderPoint = item.WorkOrderPoint,
                        WorkOrderDescription = item.WorkOrderDescription,
                        CreateDate = item.CreateDate,
                        ModifiedDate = item.ModifiedDate,
                        Id = item.Id,
                        AssignEmployeeId = item.AssignEmployeeId
                    });
                }
                var model = PaginatedList<WorkOrderVM>.CreateAsync(returnData, pageNumber, 1);
                return View(model);


            }
            //var mappingData = _mapper.Map<List<WorkOrder>, List<WorkOrderVM>>(data);
            return View();
        }
        #endregion
    }
}