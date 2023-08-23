using CleanArch.Domain.Entities;
using MediatR;

namespace CleanArch.Application.Products.Queries
{
    public class GetProductsQueryById : IRequest<Product>
    {
        public int Id { get; set; }

        public GetProductsQueryById(int id)
        {
            Id = id;
        }
    }
}
