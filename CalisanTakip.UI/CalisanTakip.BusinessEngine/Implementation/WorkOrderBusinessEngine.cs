using AutoMapper;
using CalisanTakip.BusinessEngine.Contracts;
using CalisanTakip.Common.ConstantsModel;
using CalisanTakip.Common.Extentsion;
using CalisanTakip.Common.ResultModels;
using CalisanTakip.Common.ViewModels;
using CalisanTakip.DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalisanTakip.BusinessEngine.Implementation
{
    public class WorkOrderBusinessEngine : IWorkOrderBusinessEngine
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _map;

        public WorkOrderBusinessEngine(IUnitOfWork uow, IMapper map)
        {
            _uow = uow;
            _map = map;
        }

        public Result<List<WorkOrderVM>> GetAllWorkOrders()
        {
            var data = _uow.workOrderRepository.GetAll(includeProperties: "AssignEmployee").ToList();

            if(data!=null)
            {
                List<WorkOrderVM> result = new List<WorkOrderVM>();
                foreach(var item in data)
                {
                    result.Add(new WorkOrderVM()
                    {
                        Id = item.Id,
                        AssignEmployeeId = item.AssignEmployeeId,
                        AssignEmployeeName=item.AssignEmployee.Email,
                        CreateDate = item.CreateDate,
                        ModifiedDate = item.ModifiedDate,
                        WorkOrderDescription = item.WorkOrderDescription,
                        WorkOrderNumber = item.WorkOrderNumber,
                        WorkOrderPoint = item.WorkOrderPoint,
                        WorkOrderStatus = (EnumWorkOrderStatus)item.WorkOrderStatus,
                        WorkOrderStatusText = EnumExtentsion<EnumWorkOrderStatus>.GetDisplayValue((EnumWorkOrderStatus)item.WorkOrderStatus),
                    });
                }

                return new Result<List<WorkOrderVM>>(true, ResultConstant.RecordFound, result);
            }

            return new Result<List<WorkOrderVM>>(false, ResultConstant.RecordNotFound);
        }
    }
}
