﻿using CalisanTakip.Common.ResultModels;
using CalisanTakip.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalisanTakip.BusinessEngine.Contracts
{
    public interface IEmployeeLeaveAssignBusinessEngine
    {
        Result<bool> ApprovedEmployeeRequest(int id);
    }
}