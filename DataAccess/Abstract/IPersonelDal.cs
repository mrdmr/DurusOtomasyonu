using System.Collections.Generic;
using Core.DataAccess;
using Core.Utilities.Results;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IPersonelDal : IEntityRepository<Personel>
    {
        public List<Personel> GetPersonelAll();
    }
}