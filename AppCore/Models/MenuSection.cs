﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace AppCore.Models
{
    public partial class MenuSection
    {
        public MenuSection()
        {
            MenuItems = new HashSet<MenuItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}