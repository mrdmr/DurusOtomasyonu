using System.Collections.Generic;
using System.Reflection.Metadata;
using Core.Entities;

namespace Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccesToken CreateToken(User user,List<OperationClaim> operationClaims);


    }
}