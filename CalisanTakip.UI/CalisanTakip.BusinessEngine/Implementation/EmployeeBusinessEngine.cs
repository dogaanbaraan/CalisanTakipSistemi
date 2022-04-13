using AutoMapper;
using CalisanTakip.BusinessEngine.Contracts;
using CalisanTakip.Common.ConstantsModel;
using CalisanTakip.Common.ResultModels;
using CalisanTakip.Common.ViewModels;
using CalisanTakip.DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalisanTakip.BusinessEngine.Implementation
{
    public class EmployeeBusinessEngine : IEmployeeBusinessEngine
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _map;

        public EmployeeBusinessEngine(IUnitOfWork uow, IMapper map)
        {
            _uow = uow;
            _map = map;
        }
        public Result<List<EmployeeVM>> GetAllEmployee()
        {
            var data = _uow.employeeRepository.GetAll();
            if(data!=null)
            {
                List<EmployeeVM> listData = new List<EmployeeVM>();
                foreach(var item in data)
                {
                    listData.Add(new EmployeeVM
                    {
                        Email = item.Email,
                        FirstName = item.FirstName,
                        LastName = item.LastName,
                        DateOfBirth = item.DateOfBirth,
                        PhoneNumber = item.PhoneNumber,
                        Id = item.Id,
                        TaxId = item.TaxId, 
                        UserName = item.UserName,
                        
                    });
                }

                return new Result<List<EmployeeVM>>(true, ResultConstant.RecordFound, listData);
            }

            else
                return new Result<List<EmployeeVM>>(false, ResultConstant.RecordNotFound, null);
        }
    }
}
