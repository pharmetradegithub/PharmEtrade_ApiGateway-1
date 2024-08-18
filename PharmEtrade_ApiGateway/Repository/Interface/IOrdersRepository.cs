﻿using BAL.Models;
using BAL.RequestModels;
using BAL.ResponseModels;
namespace PharmEtrade_ApiGateway.Repository.Interface
{
    public interface IOrdersRepository
    {
        Task<OrderResponse> AddOrder(OrderRequest orderRequest);
        Task<Response<Order>> GetOrdersByCustomerId(string customerId);
    }
}