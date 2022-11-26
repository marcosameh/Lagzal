﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace AppCore.Models
{
    public partial class Album
    {
        public Album()
        {
            AlbumLocalizeds = new HashSet<AlbumLocalized>();
            AlbumPhotos = new HashSet<AlbumPhoto>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<AlbumLocalized> AlbumLocalizeds { get; set; }
        public virtual ICollection<AlbumPhoto> AlbumPhotos { get; set; }
    }
}