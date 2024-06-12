using Assignment.Api.Interfaces.Inventory;
using Assignment.Api.Models.Inventory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.Repository.Inventory
{
    public class InCategoryRepository :IDBInCategoryRepository
    {
       
            private readonly RaidenDBContext _dBContext;

            public InCategoryRepository(RaidenDBContext dBContext)
            {
                _dBContext = dBContext;
            }

            public async Task<IEnumerable<InCategory>> GetCategoriesAsync()
            {
                return await _dBContext.InCategory.ToListAsync();
            }

            public async Task<InCategory> GetCategoryByIdAsync(int categoryId)
            {
                return await _dBContext.InCategory.FindAsync(categoryId);
            }

            public async Task AddCategoryAsync(InCategory category)
            {
                var newCategory = new InCategory { CategoryName = category.CategoryName };
                _dBContext.InCategory.Add(newCategory);
                await _dBContext.SaveChangesAsync();
            }

            public async Task UpdateCategoryAsync(int categoryId, InCategory updatedCategory)
            {
                var existingCategory = await _dBContext.InCategory.FindAsync(categoryId);
                if (existingCategory != null)
                {
                    existingCategory.CategoryName = updatedCategory.CategoryName;
                    await _dBContext.SaveChangesAsync();
                }
            }

            public async Task DeleteCategoryAsync(int categoryId)
            {
                var category = await _dBContext.InCategory.FindAsync(categoryId);
                if (category != null)
                {
                    _dBContext.InCategory.Remove(category);
                    await _dBContext.SaveChangesAsync();
                }
            }
        }
    }

