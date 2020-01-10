using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebModel.Models;

namespace WebData
{
    public class WebBanHangDBContext : DbContext
    {
        public WebBanHangDBContext() : base("WebBanHang")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        //public vi
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }

        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<ProductCategory> ProductCategorys { set; get; }
    }
}
