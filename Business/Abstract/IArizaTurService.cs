using System.Collections.Generic;
using Core.Utilities.Results;
using Entities;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IArizaTurService
    {
        IDataResult<ArizaTur> GetById(int arizaTurId);
    }
}