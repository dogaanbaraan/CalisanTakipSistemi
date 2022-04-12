using AutoMapper;
using CalisanTakip.BusinessEngine.Contracts;
using CalisanTakip.DataAccess.Contracts;
using System;
using System.Collections.Generic;
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
    }
}
