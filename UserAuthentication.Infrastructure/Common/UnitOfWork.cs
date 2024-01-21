using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAuthentication.Application.Common;

namespace UserAuthentication.Infrastructure.Common;
public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
    }
    public void Dispose() => _context.Dispose();
    

    public async ValueTask DisposeAsync() => await _context.DisposeAsync();
    

    public bool SaveChanges() => _context.SaveChanges()>0;
    

    public async Task<bool> SaveChangesAsync() => await _context.SaveChangesAsync()>0;
    
}

