using System;
using System.Collections.Generic;
using System.Text;

namespace CalisanTakip.DataAccess.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
