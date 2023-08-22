using AutoMapper;
using CleanArch.Application.DTOs;
using CleanArch.Application.Interfaces;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var productsEntity = await _productRepository.GetProducts();
            return _mapper.Map<IEnumerable<ProductDTO>>(productsEntity);
        }

        public async Task<ProductDTO> GetById(int id)
        {
            var productEntity = await _productRepository.GetById(id);
            return _mapper.Map<ProductDTO>(productEntity);
        }

        public async Task Add(ProductDTO productDTO)
        {
            var productEntity = _mapper.Map<Product>(productDTO);
            await _productRepository.CreateProduct(productEntity);
        }

        public async Task Update(ProductDTO productDTO)
        {
            var productEntity = _mapper.Map<Product>(productDTO);
            await _productRepository.UpdateProduct(productEntity);
        }

        public async Task Delete(int id)
        {
            var productEntity = _productRepository.GetById(id).Result;
            await _productRepository.DeleteProduct(productEntity);
        }
    }
}
