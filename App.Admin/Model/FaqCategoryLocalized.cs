//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class FaqCategoryLocalized
    {
        public int CategoryId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
    
        public virtual FaqCategory FaqCategory { get; set; }
        public virtual Language Language { get; set; }
    }
}
