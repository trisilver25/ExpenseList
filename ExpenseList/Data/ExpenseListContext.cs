using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExpenseList.Models;

namespace ExpenseList.Data
{
    public class ExpenseListContext : DbContext
    {
        public ExpenseListContext (DbContextOptions<ExpenseListContext> options)
            : base(options)
        {
        }

        public DbSet<ExpenseList.Models.Expense> Expense { get; set; } = default!;
    }
}
