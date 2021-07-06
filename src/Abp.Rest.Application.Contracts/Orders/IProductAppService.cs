﻿using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Rest.Orders
{
    public interface IProductAppService :
        ICrudAppService<ProductDto, Guid, PagedAndSortedResultRequestDto, ProductEditDto>
    {
    }
}