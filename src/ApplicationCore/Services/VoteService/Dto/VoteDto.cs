using System;

namespace Microsoft.Nnn.ApplicationCore.Services.VoteService.Dto
{
    public class VoteDto
    {
        public long Id { get; set; }
        public string User { get; set; }
        public string VoterName { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string Survivor { get; set; }
        public string Series { get; set; } 
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