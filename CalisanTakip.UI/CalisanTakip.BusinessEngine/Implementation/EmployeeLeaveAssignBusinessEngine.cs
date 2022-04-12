using AutoMapper;
using CalisanTakip.BusinessEngine.Contracts;
using CalisanTakip.Common.ConstantsModel;
using CalisanTakip.Common.ResultModels;
using CalisanTakip.DataAccess.Contracts;
using CalisanTakip.DataAccess.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalisanTakip.BusinessEngine.Implementation
{
    public class EmployeeLeaveAssignBusinessEngine : IEmployeeLeaveAssignBusinessEngine
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public EmployeeLeaveAssignBusinessEngine(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public Result<bool> ApprovedEmployeeRequest(int id)
        {
            if(id>0)
            {
                try
                {
                    var data = _uow.employeeLeaveRequest.GetFirstOfDefault(u => u.Id == id);
                    if(data!=null)
                    {
                        EmployeeLeaveAllocation createModel = new EmployeeLeaveAllocation();
                        createModel.DateCreated = DateTime.Now;
                        createModel.EmployeeId = data.RequestingEmployeeId;
                        createModel.EmployeeLeaveTypeId = data.EmployeeLeaveTypeId;
                        var day = (data.StartDate.Day - data.EndDate.Day);
                        createModel.NumberOfDays = day < 0 ? -day : day;
                        createModel.Period = 1;
                        _uow.employeeLeaveAllocation.Add(createModel);
                    }

                    data.Approved = (int)EnumEmployeeLeaveRequestStatus.Approved;
                    _uow.employeeLeaveRequest.Update(data);
                    _uow.Save();
                    return new Result<bool>(true, ResultConstant.UpdateOk);
                }
                catch (Exception ex)
                {

                    return new Result<bool>(false, ResultConstant.UpdateNotOk + "=>" + ex.Message.ToString());
                }
            }

            else
                return new Result<bool>(false, ResultConstant.UpdateNotOk);
        }
    }
}
