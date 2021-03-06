using System.Collections.Generic;

#nullable disable

namespace Core.Entities
{
    public partial class User : IEntity
    {
        public User()
        {
            UserOperationClaims = new HashSet<UserOperationClaim>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public bool? Status { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
