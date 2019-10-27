using System;
using System.Collections.Generic;
using System.Text;

namespace LoginManagementRepository.Interfaces
{
    public interface IUnitOfWork
    {
        int Commit();
        void Dispose(bool disposing);
    }
}
