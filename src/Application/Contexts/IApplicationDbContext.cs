using Domain.Categories;
using Domain.Expenses;
using Microsoft.EntityFrameworkCore;

namespace Application.Contexts;

public interface IApplicationDbContext
{
    DbSet<Category> Categories { get; set; }
    DbSet<Expense> Expenses { get; set; }
}