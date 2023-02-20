using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories
{
    public interface IEntityRepo<TEntity>
    {
        IList<TEntity> GetAll();
        TEntity? GetById(int Id);
        void Add(TEntity entity);
        void Update(int Id, TEntity entity);
        void Delete(int Id);
    }
}