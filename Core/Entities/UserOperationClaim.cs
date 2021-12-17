#nullable disable

namespace Core.Entities
{
    public partial class UserOperationClaim : IEntity
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? OperationClaimId { get; set; }

        public virtual OperationClaim OperationClaim { get; set; }
        public virtual User User { get; set; }
    }
}
