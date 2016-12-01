using System;

namespace StatlerWaldorfCorp.PetLostAndFound.Persistence
{
    public class Incident
    {
        public Guid PetID { get; set; }
        public DateTime Lost {get; set; }
        public DateTime Found {get; set; }
    }
}