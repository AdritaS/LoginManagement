using LoginManagement.Data;
using LoginManagementRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace LoginManagementRepository.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private LoginManagementDbContext _context;

        public UnitOfWork(LoginManagementDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Dispose(bool disposing)
        {
            if (!disposing) return;
            if (_context == null) return;
            _context.Dispose();
            _context = null;
        }

    }
}
