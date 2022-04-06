using AutoMapper;
using CalisanTakip.BusinessEngine.Contracts;
using CalisanTakip.Common.ConstantsModel;
using CalisanTakip.Common.Extentsion;
using CalisanTakip.Common.ResultModels;
using CalisanTakip.Common.SessionOperations;
using CalisanTakip.Common.ViewModels;
using CalisanTakip.DataAccess.Contracts;
using CalisanTakip.DataAccess.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalisanTakip.BusinessEngine.Implementation
{
    public class EmployeeLeaveRequestBusinessEngine : IEmployeeLeaveRequestBusinessEngine
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public EmployeeLeaveRequestBusinessEngine(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public Result<EmployeeLeaveRequestVM> CreateEmployeeLeaveRequest(EmployeeLeaveRequestVM model, SessionContext user)
        {
            if (model != null)
            {
                try
                {
                    var leaveRequest = _mapper.Map<EmployeeLeaveRequestVM, EmployeeLeaveRequest>(model);
                    leaveRequest.RequestingEmployeeId = user.LoginId;
                    leaveRequest.Cancelled = false;
                    leaveRequest.DateRequested = DateTime.Now;
                    leaveRequest.Approved = (int)EnumEmployeeLeaveRequestStatus.Send_Approved;
                    _uow.employeeLeaveRequest.Add(leaveRequest);
                    _uow.Save();

                    return new Result<EmployeeLeaveRequestVM>(true, ResultConstant.AddedOk);
                }
                catch (Exception e)
                {

                    return new Result<EmployeeLeaveRequestVM>(false, ResultConstant.AddedNotOk + "=>" + e.Message.ToString());
                }
            }
            else
                return new Result<EmployeeLeaveRequestVM>(false, "Model bulunamadı");
        }

        public Result<EmployeeLeaveRequestVM> EditEmployeeLeaveRequest(EmployeeLeaveRequestVM model, SessionContext user)
        {
            if (model != null)
            {
                try
                {
                    var leaveRequest = _mapper.Map<EmployeeLeaveRequestVM, EmployeeLeaveRequest>(model);
                    leaveRequest.Approved = (int)model.ApprovedStatus;
                    leaveRequest.RequestingEmployeeId = user.LoginId;
                    _uow.employeeLeaveRequest.Update(leaveRequest);
                    _uow.Save();

                    return new Result<EmployeeLeaveRequestVM>(true, ResultConstant.UpdateOk);
                }
                catch (Exception e)
                {

                    return new Result<EmployeeLeaveRequestVM>(false, ResultConstant.UpdateNotOk + "=>" + e.Message.ToString());
                }

            }

            else
                return new Result<EmployeeLeaveRequestVM>(false, "Güncelleme işlemi yapılamadı");
        }

        public Result<EmployeeLeaveRequestVM> GetAllLeaveRequestById(int id)
        {
            var data = _uow.employeeLeaveRequest.Get(id);
            if (data != null)
            {
                var leaveRequest = _mapper.Map<EmployeeLeaveRequest, EmployeeLeaveRequestVM>(data);
                leaveRequest.ApprovedStatus = (EnumEmployeeLeaveRequestStatus)data.Approved;
                leaveRequest.ApprovedText = EnumExtentsion<EnumEmployeeLeaveRequestStatus>.GetDisplayValue((EnumEmployeeLeaveRequestStatus)data.Approved);
                return new Result<EmployeeLeaveRequestVM>(true, ResultConstant.RecordFound, leaveRequest);
            }

            else
            {
                return new Result<EmployeeLeaveRequestVM>(false, ResultConstant.RecordNotFound);
            }


        }

        public Result<List<EmployeeLeaveRequestVM>> GetAllLeaveRequestByUserId(string userId)
        {
            var data = _uow.employeeLeaveRequest.GetAll(
                u => u.RequestingEmployeeId == userId
                && u.Cancelled == false,
                includeProperties: "RequestingEmployee,EmployeeLeaveType").ToList();

            if (data != null)
            {
                List<EmployeeLeaveRequestVM> returnData = new List<EmployeeLeaveRequestVM>();
                foreach (var item in data)
                {
                    returnData.Add(new EmployeeLeaveRequestVM()
                    {
                        Id = item.Id,
                        ApprovedStatus = (EnumEmployeeLeaveRequestStatus)item.Approved,
                        ApprovedText = EnumExtentsion<EnumEmployeeLeaveRequestStatus>.GetDisplayValue((EnumEmployeeLeaveRequestStatus)item.Approved),
                        ApprovedEmployeeId = item.ApprovedEmployeeId,
                        Cancelled = item.Cancelled,
                        DateRequested = item.DateRequested,
                        EmployeeLeaveTypeId = item.EmployeeLeaveTypeId,
                        LeaveTypeText = item.EmployeeLeaveType.Name,
                        EndDate = item.EndDate,
                        StartDate = item.StartDate,
                        RequestComments = item.RequestComments,
                        RequestingEmployeeId = item.RequestingEmployeeId
                    });
                }
                return new Result<List<EmployeeLeaveRequestVM>>(true, ResultConstant.RecordFound, returnData);
            }
            else
                return new Result<List<EmployeeLeaveRequestVM>>(false, ResultConstant.RecordNotFound);

        }

        public Result<EmployeeLeaveRequestVM> RemoveEmployeeLeaveRequest(int id)
        {
            var data = _uow.employeeLeaveRequest.Get(id);
            if (data != null)
            {
                data.Cancelled = true;
                _uow.employeeLeaveRequest.Update(data);
                _uow.Save();
                return new Result<EmployeeLeaveRequestVM>(true, ResultConstant.DeleteOk);

            }

            else
                return new Result<EmployeeLeaveRequestVM>(false, ResultConstant.DeleteNotOk);
        }
    }
}
