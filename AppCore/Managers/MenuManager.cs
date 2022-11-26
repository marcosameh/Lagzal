using AppCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Managers
{
    public class MenuManager
    {
        private readonly AppCoreContext context;

        public MenuManager(AppCoreContext context)
        {
            this.context = context;
        } 
        public IQueryable<MenuSection> GetMenuSections()
        {
            return context.MenuSections.Where(x=>x.Active.Value).OrderBy(x=>x.DisplayOrder).Include(x=>x.MenuItems.OrderBy(x =>x.DisplayOrder));
        }
        public IQueryable<MenuItem> GetMenuItems()
        {
            return context.MenuItems.Where(x => x.Active.Value).OrderBy(x => x.DisplayOrder).Include(x => x.Section);
        }
    }
}
