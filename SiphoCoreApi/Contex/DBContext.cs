using Microsoft.EntityFrameworkCore;
using SiphoCoreApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiphoCoreApi.Contex
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions<DBContext> options):base(options) 
        { 
        }
        public DbSet<StockItemModel> StockItem { get; set; }
        public DbSet<ImagesModel> Image { get; set; }
        public DbSet<StockAccessoryModel> StockAccessory { get; set; }
        
    }
}
