﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DynamicData.Admin.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AdminEntities : DbContext
    {
        public AdminEntities()
            : base("name=AdminEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<AlbumLocalized> AlbumLocalizeds { get; set; }
        public virtual DbSet<AlbumPhoto> AlbumPhotoes { get; set; }
        public virtual DbSet<aspnet_Applications> aspnet_Applications { get; set; }
        public virtual DbSet<aspnet_Membership> aspnet_Membership { get; set; }
        public virtual DbSet<aspnet_Roles> aspnet_Roles { get; set; }
        public virtual DbSet<aspnet_SchemaVersions> aspnet_SchemaVersions { get; set; }
        public virtual DbSet<aspnet_Users> aspnet_Users { get; set; }
        public virtual DbSet<Banner> Banners { get; set; }
        public virtual DbSet<BannerLocalized> BannerLocalizeds { get; set; }
        public virtual DbSet<Career> Careers { get; set; }
        public virtual DbSet<CareerLocalized> CareerLocalizeds { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<CityLocalized> CityLocalizeds { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Faq> Faqs { get; set; }
        public virtual DbSet<FaqCategory> FaqCategories { get; set; }
        public virtual DbSet<FaqCategoryLocalized> FaqCategoryLocalizeds { get; set; }
        public virtual DbSet<FaqLocalized> FaqLocalizeds { get; set; }
        public virtual DbSet<Gallery> Galleries { get; set; }
        public virtual DbSet<HomeBanner> HomeBanners { get; set; }
        public virtual DbSet<HomeBannerLocalized> HomeBannerLocalizeds { get; set; }
        public virtual DbSet<InfoPage> InfoPages { get; set; }
        public virtual DbSet<InfoPageCategory> InfoPageCategories { get; set; }
        public virtual DbSet<InfoPageCategoryLocalized> InfoPageCategoryLocalizeds { get; set; }
        public virtual DbSet<InfoPageLocalized> InfoPageLocalizeds { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<MediaCollection> MediaCollections { get; set; }
        public virtual DbSet<MediaItem> MediaItems { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<MenuSection> MenuSections { get; set; }
        public virtual DbSet<MetaTag> MetaTags { get; set; }
        public virtual DbSet<MetaTagLocalized> MetaTagLocalizeds { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsletterSubscription> NewsletterSubscriptions { get; set; }
        public virtual DbSet<NewsLocalized> NewsLocalizeds { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<SettingCategory> SettingCategories { get; set; }
        public virtual DbSet<SitePage> SitePages { get; set; }
        public virtual DbSet<SocialLink> SocialLinks { get; set; }
        public virtual DbSet<TeamMember> TeamMembers { get; set; }
        public virtual DbSet<Testimonial> Testimonials { get; set; }
        public virtual DbSet<TestimonialSource> TestimonialSources { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
