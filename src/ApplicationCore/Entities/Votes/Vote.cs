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
        public string Survivor { get; set; }
        public string Series { get; set; } // guvenilir
        public string Netflix { get; set; }
        public string Singer { get; set; }
        public string Instrument { get; set; }
        public string CarModel { get; set; }
        public string Startup { get; set; }
        public string MusicType { get; set; }
        public string Football { get; set; }
        public string YesilCam { get; set; }
    }   
}