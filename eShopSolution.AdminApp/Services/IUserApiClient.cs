﻿using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);

        Task<ApiResult<PageResult<UserVm>>> GetUsersPagings(GetUserPagingRequest request);
        Task<ApiResult<bool>> RegisterUser(RegisterRequest registerRequest);

        Task<ApiResult<bool>> UpdateUser(Guid id, UserUpdateRequest request);
        Task<ApiResult<UserVm>> GetById(Guid id);

    }
}
