using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICalismaSaatService
    {
        IDataResult<CalismaSaat> GetById(int id);
        IDataResult<List<CalismaSaat>> GetAll();
        IResult Add(CalismaSaat calismaSaat);
        IResult Update(CalismaSaat calismaSaat);
        IResult Delete(CalismaSaat calismaSaat);
    }
}