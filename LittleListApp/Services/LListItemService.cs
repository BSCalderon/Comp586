using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LittleListApp.Data;
using LittleListApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace LittleListApp.Services
{
    public class LListItemService : ILListItemService
    {
        private readonly ApplicationDbContext _context;

        public LListItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<LListItem[]> GetIncompleteItemsAsync(
            IdentityUser user)
        {
            return await _context.Items.Where(x => x.IsDone == false && x.UserId == user.Id).ToArrayAsync();
        }

        public async Task<bool> AddItemAsync(LListItem newItem, IdentityUser user)
        {
            newItem.Id = Guid.NewGuid();
            newItem.IsDone = false;
            newItem.Checked = false;
            newItem.DueAt = DateTimeOffset.Now;
            newItem.UserId = user.Id;

            _context.Items.Add(newItem);

            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }

        public async Task<bool> MarkDoneAsync(Guid id, IdentityUser user)
        {
            var item = await _context.Items.Where(x => x.Id == id && x.UserId == user.Id).SingleOrDefaultAsync();

            if (item == null) return false;

            item.IsDone = true;

            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }

        public async Task<bool> CheckMarkAsync(Guid id, IdentityUser user)
        {
            var item = await _context.Items.Where(x => x.Id == id && x.UserId == user.Id).SingleOrDefaultAsync();

            if (item == null) return false;

            item.Checked = true;

            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }
    }
}