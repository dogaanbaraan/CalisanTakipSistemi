using AutoMapper;
using CalisanTakip.BusinessEngine.Contracts;
using CalisanTakip.Common.ConstantsModel;
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
    public class EmployeeLeaveRequestBusinessEngine : IEmployeeLeaveRequestBusinessEngine
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public EmployeeLeaveRequestBusinessEngine(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public Result<List<EmployeeLeaveRequestVM>> GetAllLeaveRequestByUserId(string userId)
        {
            #region 1.yöntem

            //var data = _uow.employeeLeaveRequest.GetAll(u => u.RequestingEmployeeId == userId).ToList();

            //var leaveTypes = _mapper.Map<List<EmployeeLeaveRequest>, List<EmployeeLeaveRequestVM>>(data);
            //return new Result<EmployeeLeaveRequestVM>(true, ResultConstant.RecordFound);
            #endregion"
            var data = _uow.employeeLeaveRequest.GetAll(u => u.RequestingEmployeeId == userId, includeProperties: "EmployeeLeaveType,RequestingEmployee").ToList();
            if (data != null)
            {
                List<EmployeeLeaveRequestVM> result = new List<EmployeeLeaveRequestVM>();
                foreach (var item in data)
                {
                    result.Add(new EmployeeLeaveRequestVM()
                    {
                        Id = item.Id,
                        Approved = item.Approved,
                        Cancelled = item.Cancelled,
                        ApprovedEmployeeId = item.ApprovedEmployeeId,
                        DateRequested = item.DateRequested,
                        EmployeeLeaveTypeId = item.EmployeeLeaveTypeId,
                        LeaveTypeText = item.EmployeeLeaveType.Name,
                        EndDate=item.EndDate,
                        StartDate=item.StartDate,
                        RequestComments= item.RequestComments,
                        RequestingEmployeeId=item.RequestingEmployeeId
                    });
                }
                return new Result<List<EmployeeLeaveRequestVM>>(true, ResultConstant.RecordFound, result);
            }
            else
                return new Result<List<EmployeeLeaveRequestVM>>(false, ResultConstant.RecordNotFound);
        }
    }
}
