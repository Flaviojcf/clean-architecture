using System;
using System.Collections.Generic;

namespace CleanArch.Domain.Entities
{
    public sealed class Category
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Category(string name)
        {
            Name = name;
        }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public ICollection<Product> Products { get; set; }
    }
}
