using System;

namespace Sample.NetCoreNorhwind.Entities
{
    public class Entity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTimeOffset CreatedAt { get; set; } = DateTime.Now;
        public DateTimeOffset? ChangedAt { get; set; }
    }
}
