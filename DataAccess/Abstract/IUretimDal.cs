using System.Collections.Generic;
using Core.DataAccess;
using Entities;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface IUretimDal : IEntityRepository<Uretim>
    {
        List<UretimForTable> GetUretimForTable();
    }
}