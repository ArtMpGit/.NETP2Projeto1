using GestaoGastos.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoGastos.Data
{
    public class DataContext: DbContext
    {
       public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }
       public DbSet<Gasto> Gasto { get; set; }
    }

}
