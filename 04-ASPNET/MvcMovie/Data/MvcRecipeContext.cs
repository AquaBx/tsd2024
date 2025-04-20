using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcRecipe.Models;

namespace MvcRecipe.Data
{
    public class MvcRecipeContext : DbContext
    {
        public MvcRecipeContext (DbContextOptions<MvcRecipeContext> options)
            : base(options)
        {
        }

        public DbSet<MvcRecipe.Models.Recipe> Recipe { get; set; } = default!;
    }
}
