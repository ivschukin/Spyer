using System;

namespace Spyer.Contracts
{
    public class Capture
    {
        public string Id { get; set; }

        public byte[] Bytes { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
