using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IPersonelService
    {
        IDataResult<Personel> GetById(int id);
        IDataResult<List<Personel>> GetAll();
        IResult Add(Personel personel);
        IResult Update(Personel personel);
        IResult Delete(Personel personel);
    }
}