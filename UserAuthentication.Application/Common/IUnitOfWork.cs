using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuthentication.Application.Common;
public interface IUnitOfWork : IDisposable, IAsyncDisposable
{
    Task<bool> SaveChangesAsync();
    bool SaveChanges();
}

