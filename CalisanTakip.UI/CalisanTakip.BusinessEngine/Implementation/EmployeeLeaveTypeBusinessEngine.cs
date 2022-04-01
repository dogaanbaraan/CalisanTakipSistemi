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

        public Result<EmployeeLeaveTypeVM> CreateEmployeeLeaveType(EmployeeLeaveTypeVM model)
        {
            if (model != null)
            {
                try
                {
                    var leaveType = _mapper.Map<EmployeeLeaveTypeVM, EmployeeLeaveType>(model);
                    leaveType.DateCreated = DateTime.Now;
                    leaveType.IsActive = true;
                    _unitOfWork.employeeLeaveType.Add(leaveType);
                    
                    _unitOfWork.Save();
                    return new Result<EmployeeLeaveTypeVM>(true, ResultConstant.AddedOk);
                }
                catch (Exception e)
                {

                    return new Result<EmployeeLeaveTypeVM>(false, ResultConstant.AddedNotOk + "=>" + e.Message.ToString());
                }
            }
            else
            {
                return new Result<EmployeeLeaveTypeVM>(false, "Girilen değer boş olmamalıdır.");
            }
        }

        public Result<EmployeeLeaveTypeVM> EditEmployeeLeaveType(EmployeeLeaveTypeVM model)
        {
            if (model != null)
            {
                var leaveType = _mapper.Map<EmployeeLeaveTypeVM, EmployeeLeaveType>(model);
                _unitOfWork.employeeLeaveType.Update(leaveType);
                _unitOfWork.Save();
                return new Result<EmployeeLeaveTypeVM>(true, ResultConstant.UpdateOk);
            }

            else
                return new Result<EmployeeLeaveTypeVM>(false, ResultConstant.UpdateNotOk);
        }

        public Result<List<EmployeeLeaveTypeVM>> GetAllEmployeeLeaveType()
        {
            var data = _unitOfWork.employeeLeaveType.GetAll(e=>e.IsActive==true).ToList();
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

        public Result<EmployeeLeaveTypeVM> GetIdEmployeeLeaveType(int id)
        {
            var data = _unitOfWork.employeeLeaveType.Get(id);
            if (data != null)
            {
                var leaveType = _mapper.Map<EmployeeLeaveType, EmployeeLeaveTypeVM>(data);
                return new Result<EmployeeLeaveTypeVM>(true, ResultConstant.RecordFound, leaveType);
            }
            else
                return new Result<EmployeeLeaveTypeVM>(false, ResultConstant.RecordNotFound);
        }

        public Result<EmployeeLeaveTypeVM> RemoveEmployeeLeaveType(int id)
        {
            var data = _unitOfWork.employeeLeaveType.Get(id);
            if (data != null)
            {
                data.IsActive = false;
                _unitOfWork.employeeLeaveType.Update(data);
                _unitOfWork.Save();
                return new Result<EmployeeLeaveTypeVM>(false, ResultConstant.DeleteOk);

            }
            else
                return new Result<EmployeeLeaveTypeVM>(false, ResultConstant.DeleteNotOk);
        }
    }
}
