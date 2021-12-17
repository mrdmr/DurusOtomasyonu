using System.Collections.Generic;
using Core.DataAccess;
using Core.Entities;

namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}