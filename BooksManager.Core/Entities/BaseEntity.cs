﻿namespace BooksManager.Core.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity() { }
        public int Id { get; set; }
        public bool Active { get; set; }

        public void Delete()
        {
            Active = false;
        }
    }
}
