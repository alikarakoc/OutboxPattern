﻿namespace OutboxPattern.Domain.Entities
{
    public class Outbox
    {
        public long Id { get; set; }
        public string? EventId { get; set; }
        public string? Body { get; set; }
        public int StatusId { get; set; }
        public DateTime PickedDate { get; set; }
        public DateTime DeliveredDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
