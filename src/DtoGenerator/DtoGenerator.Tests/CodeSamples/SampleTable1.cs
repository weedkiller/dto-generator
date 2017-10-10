//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DtoGenerator.Tests.CodeSamples
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    
    public partial class SampleTable1 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SampleTable1()
        {
            this.SampleTable3 = new HashSet<SampleTable3>();
        }
    
    
        [Required]
        public int Id { get; set; }
    
        [StringLength(10)]
        [Required]
        public string Title { get; set; }
    
        [StringLength(200),Required]
        public string Description { get; set; }
    
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual SampleTable2 SampleTable2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SampleTable3> SampleTable3 { get; set; }
    }
}
