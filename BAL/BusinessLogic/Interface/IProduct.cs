﻿using BAL.ViewModel;
using System.Threading.Tasks;
using BAL.ViewModels;
using Microsoft.AspNetCore.Http;
using BAL.Models;
using BAL.ResponseModels;
using BAL.RequestModels;

namespace BAL.BusinessLogic.Interface
{
    public interface IProductHelper
    {
        Task<BAL.ResponseModels.Response<ProductResponse>> AddProduct(Product product);
        Task<BAL.ResponseModels.Response<ProductInfo>> AddUpdateProductInfo(ProductInfo productInfo);
        Task<BAL.ResponseModels.Response<ProductPrice>> AddUpdateProductPrice(ProductPrice productPrice);
        Task<BAL.ResponseModels.Response<ProductGallery>> AddUpdateProductGallery(ProductGallery productGallery);
        Task<UploadResponse> UploadImage(IFormFile image, string sellerId);
        Task<BAL.ResponseModels.Response<ProductResponse>> GetAllProducts(string productId = null);
        Task<BAL.ResponseModels.Response<ProductResponse>> GetProductsBySpecification(int categorySpecificationId);
        Task<BAL.ResponseModels.Response<ProductResponse>> GetRecentSoldProducts(int numberOfProducts);
        Task<Response<ProductResponse>> GetProductsBySeller(string sellerId);
        Task<Response<ProductResponse>> GetProductsByCriteria(ProductCriteria criteria);
        Task<BAL.ResponseModels.Response<ProductSize>> AddUpdateProductSize(ProductSize productSize);
        Task<string> InsertProductsFromExcel(Stream excelFileStream);

        Task<BAL.ResponseModels.Response<SpecialOffersResponse>> GetSpecialOffers();

    }
}