using System.Collections.Generic;
using Microsoft.Nnn.ApplicationCore.Entities.Properties;
using Microsoft.Nnn.ApplicationCore.Entities.Users;
using Microsoft.Nnn.ApplicationCore.Interfaces;

namespace Microsoft.Nnn.ApplicationCore.Entities.Votes
{
    public class Vote:BaseEntity,IAggregateRoot
    {
        public long UserId { get; set; }
        public string VoterName { get; set; }
        public User User { get; set; }
        public int Honest { get; set; }
        public int Reliable { get; set; } // guvenilir
        public int Handsome { get; set; }
        public int Beautiful { get; set; }
        public int Clever { get; set; }
        public int Impressive { get; set; }
        public int Sympathetic { get; set; }
        public int ClothingStyle { get; set; }
        public int MakeUp { get; set; }
        public int Funny { get; set; }
        public int HairStyle { get; set; }
        public int TalkingStyle { get; set; }
    }   
}