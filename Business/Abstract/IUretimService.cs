using System.Collections.Generic;
using Core.Utilities.Results;
using Entities;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IUretimService
    {
        IDataResult<List<UretimForTable>> GetUretimForTable();
        IDataResult<Uretim> GetById(int id);
        IDataResult<List<Uretim>> GetAll();
        IResult Add(Uretim uretim);
        IResult Update(Uretim uretim);
        IResult Delete(Uretim uretim);
    }
}