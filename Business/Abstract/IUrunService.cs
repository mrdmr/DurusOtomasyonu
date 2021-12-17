using System.Collections.Generic;
using Core.Utilities.Results;
using Entities;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUrunService
    {
        IDataResult<Urun> GetById(int id);
        IDataResult<List<Urun>> GetAll();
        IResult Add(Urun urun);
        IResult Update(Urun urun);
        IResult Delete(Urun urun);
    }
}