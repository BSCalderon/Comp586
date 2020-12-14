using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LittleListApp.Models;
using Microsoft.AspNetCore.Identity;

namespace LittleListApp.Services
{
    public interface ILListItemService
    {
        Task<LListItem[]> GetIncompleteItemsAsync( 
            IdentityUser user);

        Task<bool> AddItemAsync(LListItem newItem, IdentityUser user);

        Task<bool> MarkDoneAsync(Guid id, IdentityUser user);

        Task<bool>CheckMarkAsync(Guid id, IdentityUser user);
    }
}