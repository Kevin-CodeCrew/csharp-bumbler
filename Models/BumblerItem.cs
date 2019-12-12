namespace BumblerApi.Models
{
    // class for a single bumpler post entity
    public class BumblerItem
    {
        public long Id {get; set;}
        public string PostTimestamp {get; set;}
        public string PostUserName {get; set;}
        public string PostImageUrl {get; set;}
        public string PostTitle {get; set;}
        public string PostText {get; set;}
    }
}