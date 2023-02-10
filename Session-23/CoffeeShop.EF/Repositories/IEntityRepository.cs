﻿using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repositories
{
    public interface IEntityRepository<IEntity>
        where IEntity : class
    {
        IList<IEntity> GetAll();

        IEntity? GetById(int id);

        void Create (IEntity entity);

        void Update(int id, IEntity entity);

        void Delete(int id);

    }
}
