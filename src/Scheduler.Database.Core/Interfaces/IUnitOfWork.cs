using System;

namespace Scheduler.Database.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //ICourseRepository Leagues { get; }
        //IAuthorRepository Authors { get; }
        int Complete();
    }
}
