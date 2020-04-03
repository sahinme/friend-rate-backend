namespace Microsoft.Nnn.ApplicationCore.Services.VoteService.Dto
{
    public class VoteDto
    {
        public long Id { get; set; }
        public string User { get; set; }
        public string VoterName { get; set; }
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