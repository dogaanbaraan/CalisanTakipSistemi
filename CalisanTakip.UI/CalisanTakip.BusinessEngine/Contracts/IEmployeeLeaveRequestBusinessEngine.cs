﻿using CalisanTakip.Common.ResultModels;
using CalisanTakip.Common.SessionOperations;
using CalisanTakip.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalisanTakip.BusinessEngine.Contracts
{
    public interface IEmployeeLeaveRequestBusinessEngine
    {
        Result<List<EmployeeLeaveRequestVM>> GetAllLeaveRequestByUserId(string userId);

        Result<EmployeeLeaveRequestVM> CreateEmployeeLeaveRequest(EmployeeLeaveRequestVM model, SessionContext user);
    }
}
