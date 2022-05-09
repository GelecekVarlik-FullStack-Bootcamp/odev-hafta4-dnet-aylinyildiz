using BusinessManagementSystem.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Dal.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        //genericteki crud işlemlerini de savechange yapabilmek için kullanılır 
        IGenericRepository<T> GetRepository<T>() where T : EntityBase;

        bool BeginTransaction();
        bool RollBackTransaction(); // hata durumunda sürecin geri alınmasını sağlar.
        int SaveChanges();
    }
}
