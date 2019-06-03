//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewsWindow
{
    using System;
    using System.Collections.Generic;
    
    public partial class News
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public News()
        {
            this.Comments = new HashSet<Comment>();
        }
        public int No { get; set; } = 0;
        public int Id { get; set; }
        public string Comment { get; set; }
        public string Header { get; set; }
        public System.DateTime CreateDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }

        public News Clone()
        {
            News news = new News()
            {
                 Comment=this.Comment,
                // Comments=this.Comments
                 CreateDate=this.CreateDate,
                  Header=this.Header,
                   Id=this.Id,
                    No=this.No
            };
            return news;
        }
    }
}
