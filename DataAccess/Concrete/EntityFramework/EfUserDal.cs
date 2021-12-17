using System.Collections.Generic;
using System.Linq;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Core.Entities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using OperationClaim = Core.Entities;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, DurusOtomasyonuContext>, IUserDal
    {
        public List<OperationClaim.OperationClaim> GetClaims(User user)
        {
            using (var context = new DurusOtomasyonuContext())
            {
                
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim.OperationClaim
                             {
                                 Id = operationClaim.Id,
                                 Name = operationClaim.Name
                             };
                return result.ToList();
            };


        }
    }
}