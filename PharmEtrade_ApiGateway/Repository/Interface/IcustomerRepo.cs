﻿using BAL.ViewModels;

namespace PharmEtrade_ApiGateway.Repository.Interface
{
    public interface IcustomerRepo
    {
        Task<loginViewModel> CustomerLogin(string username, string password);
    }
}
