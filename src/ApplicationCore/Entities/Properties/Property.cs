using Microsoft.Nnn.ApplicationCore.Entities.Votes;
using Microsoft.Nnn.ApplicationCore.Interfaces;

namespace Microsoft.Nnn.ApplicationCore.Entities.Properties
{
    public class Property:BaseEntity,IAggregateRoot
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public long VoteId { get; set; }
        public Vote Votes { get; set; }
    }
}