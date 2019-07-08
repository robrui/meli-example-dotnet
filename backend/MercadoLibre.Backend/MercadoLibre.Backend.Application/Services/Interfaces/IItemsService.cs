﻿using System.Threading.Tasks;
using MercadoLibre.Backend.Domain.Models.Items;

namespace MercadoLibre.Backend.Application.Services.Interfaces
{
    public interface IItemsService
    {
        Task<Search> Search(string query);

        Task<Detail> DetailWithDescription(string id);
    }
}