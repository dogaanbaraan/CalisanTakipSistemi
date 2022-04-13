using AutoMapper;
using CalisanTakip.BusinessEngine.Contracts;
using CalisanTakip.Common.ConstantsModel;
using CalisanTakip.Common.Extentsion;
using CalisanTakip.Common.ResultModels;
using CalisanTakip.Common.ViewModels;
using CalisanTakip.DataAccess.Contracts;
using CalisanTakip.DataAccess.DbModels;
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

        public Result<WorkOrderVM> CreateWorkOrder(WorkOrderVM model)
        {
            if (model != null)
            {
                try
                {
                    WorkOrder wOrder = new WorkOrder();
                    wOrder.CreateDate = DateTime.Now;
                    wOrder.WorkOrderDescription = model.WorkOrderDescription;
                    wOrder.WorkOrderNumber = DateTime.Now.ToString();
                    wOrder.WorkOrderPoint = model.WorkOrderPoint;
                    wOrder.WorkOrderStatus = (int)EnumWorkOrderStatus.WorkOrder_Created;

                    _uow.workOrderRepository.Add(wOrder);
                    _uow.Save();

                    return new Result<WorkOrderVM>(true, ResultConstant.AddedOk);
                }
                catch (Exception ex)
                {

                    return new Result<WorkOrderVM>(false, ResultConstant.AddedNotOk + "=>" + ex.Message.ToString());
                }
            }

            else
            {
                return new Result<WorkOrderVM>(false, "Model ekleme işlemi yapılamadı");
            }
        }

        public Result<WorkOrderVM> EditWorkOrder(WorkOrderVM editModel)
        {
            if (editModel.Id > 0)
            {
                var data = _uow.workOrderRepository.Get(editModel.Id);
                if (data != null)
                {
                    data.ModifiedDate = DateTime.Now;
                    data.WorkOrderDescription = editModel.WorkOrderDescription;
                    data.WorkOrderPoint = editModel.WorkOrderPoint;
                    data.WorkOrderStatus = (int)editModel.WorkOrderStatus != 0 ? 2:1 ;
                    data.AssignEmployeeId = editModel.AssignEmployeeId;
                    _uow.workOrderRepository.Update(data);
                    _uow.Save();
                    return new Result<WorkOrderVM>(true, ResultConstant.UpdateOk);
                }
                else
                    return new Result<WorkOrderVM>(false, "Lütfen Güncelleme İşlemi İçin Data Seçiniz");
            }
            else
                return new Result<WorkOrderVM>(false, "Lütfen Güncelleme İşlemi İçin Data Seçiniz");
        }

        public Result<List<WorkOrderVM>> GetAllWorkOrders()
        {
            var data = _uow.workOrderRepository.GetAll(includeProperties: "AssignEmployee").ToList();
            #region 1.Yontem
            if (data != null)
            {
                List<WorkOrderVM> returnData = new List<WorkOrderVM>();
                foreach (var item in data)
                {
                    returnData.Add(new WorkOrderVM()
                    {
                        Id = item.Id,
                        AssignEmployeeId = item.AssignEmployeeId,
                        AssignEmployeeName = item.AssignEmployee != null ? item.AssignEmployee.Email : string.Empty,
                        CreateDate = item.CreateDate,
                        ModifiedDate = item.ModifiedDate,
                        WorkOrderDescription = item.WorkOrderDescription,
                        WorkOrderNumber = item.WorkOrderNumber,
                        WorkOrderPoint = item.WorkOrderPoint,
                        WorkOrderStatus = EnumWorkOrderStatus.WorkOrder_Created,
                        WorkOrderStatusText = EnumExtentsion<EnumWorkOrderStatus>.GetDisplayValue((EnumWorkOrderStatus)item.WorkOrderStatus)
                    });
                }
                return new Result<List<WorkOrderVM>>(true, ResultConstant.RecordFound, returnData.OrderByDescending(x => x.CreateDate).ToList());
            }
            else
                return new Result<List<WorkOrderVM>>(false, ResultConstant.RecordNotFound);
            #endregion
        }

        public Result<WorkOrderVM> GetWorkOrder(int id)
        {
            if (id > 0)
            {
                var workOrder = _uow.workOrderRepository.GetFirstOfDefault(u => u.Id == id, includeProperties: "AssignEmployee");
                if (workOrder != null)
                {
                    WorkOrderVM wOrder = new WorkOrderVM();
                    wOrder.AssignEmployeeId = workOrder.AssignEmployeeId;
                    wOrder.AssignEmployeeName = workOrder.AssignEmployee != null ? workOrder.AssignEmployee.Email : string.Empty;
                    wOrder.CreateDate = workOrder.CreateDate;
                    wOrder.Id = workOrder.Id;
                    wOrder.ModifiedDate = workOrder.ModifiedDate;
                    wOrder.WorkOrderNumber = workOrder.WorkOrderNumber;
                    wOrder.WorkOrderDescription = workOrder.WorkOrderDescription;
                    wOrder.WorkOrderPoint = workOrder.WorkOrderPoint;
                    wOrder.WorkOrderStatus = (EnumWorkOrderStatus)workOrder.WorkOrderStatus;
                    wOrder.WorkOrderStatusText = EnumExtentsion<EnumWorkOrderStatus>.GetDisplayValue((EnumWorkOrderStatus)workOrder.WorkOrderStatus);
                    return new Result<WorkOrderVM>(true, ResultConstant.UpdateOk, wOrder);
                }

                else
                    return new Result<WorkOrderVM>(false, ResultConstant.UpdateNotOk);
            }
            else
                return new Result<WorkOrderVM>(false, ResultConstant.UpdateNotOk);

        }

        public Result<bool> RemoveWorkOrder(int id)
        {
            var data = _uow.workOrderRepository.Get(id);
            if(data!=null)
            {
                _uow.workOrderRepository.Remove(data);
                _uow.Save();
                return new Result<bool>(true, ResultConstant.DeleteOk); 
            }

            else
                return new Result<bool>(false, ResultConstant.DeleteNotOk);

        }
    }
}
