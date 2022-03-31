using CalisanTakip.BusinessEngine.Contracts;
using CalisanTakip.Common.ResultModels;
using CalisanTakip.DataAccess.Contracts;
using CalisanTakip.DataAccess.DbModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CalisanTakip.Common.ConstantsModel;
using AutoMapper;
using CalisanTakip.Common.ViewModels;

namespace CalisanTakip.BusinessEngine.Implementation
{
    public class EmployeeLeaveTypeBusinessEngine : IEmployeeLeaveTypeBusinessEngine
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeLeaveTypeBusinessEngine(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Result<List<EmployeeLeaveTypeVM>> GetAllEmployeeLeaveType()
        {
            var data = _unitOfWork.employeeLeaveType.GetAll().ToList();
            #region 1.Yöntem
            //if (data != null)
            //{
            //    List<EmployeeLeaveType> result = new List<EmployeeLeaveType>();
            //    foreach (var item in data)
            //    {
            //        result.Add(new EmployeeLeaveType()
            //        {
            //            Id = item.Id,
            //            Name = item.Name,
            //            DateCreated = item.DateCreated,
            //            DefaultDays = item.DefaultDays
            //        });
            //    }
            //    return new Result<List<EmployeeLeaveType>>(true, ResultConstant.RecordFound, result);
            //}
            //else
            //    return new Result<List<EmployeeLeaveType>>(false, ResultConstant.RecordNotFound);
            #endregion

            #region 2.Yöntem
            var leaveType = _mapper.Map<List<EmployeeLeaveType>, List<EmployeeLeaveTypeVM>>(data);
            return new Result<List<EmployeeLeaveTypeVM>>(true, ResultConstant.RecordFound, leaveType);
            #endregion
        }
    }
}
