using System;


namespace DevFreela.Core.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {

        }

        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; private set; }
        public DateTime? UpdatedAt { get; private set; }

    }
}
