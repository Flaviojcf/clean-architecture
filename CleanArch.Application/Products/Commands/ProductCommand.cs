using CleanArch.Domain.Entities;
using MediatR;

namespace CleanArch.Application.Products.Commands
{
    public abstract class ProductCommand : IRequest<Product>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Price { get; set; }

        public string Stock { get; set; }

        public string Image { get; set; }
        
        public string CategoryId { get; set; }
    }
}
