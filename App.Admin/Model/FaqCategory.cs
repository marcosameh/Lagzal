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
    
    public partial class FaqCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FaqCategory()
        {
            this.Faqs = new HashSet<Faq>();
            this.FaqCategoryLocalizeds = new HashSet<FaqCategoryLocalized>();
        }
    
        public int Id { get; set; }
        public string UrlName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Faq> Faqs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FaqCategoryLocalized> FaqCategoryLocalizeds { get; set; }
    }
}
