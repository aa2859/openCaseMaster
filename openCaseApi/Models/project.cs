//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace openCaseApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public project()
        {
            this.Framework4Project = new HashSet<Framework4Project>();
            this.M_DevProMapping = new HashSet<M_DevProMapping>();
            this.M_testCaseSteps = new HashSet<M_testCaseSteps>();
            this.M_testDemand = new HashSet<M_testDemand>();
            this.project_app = new HashSet<project_app>();
        }
    
        public int ID { get; set; }
        public string Pname { get; set; }
        public Nullable<bool> zidonghua { get; set; }
        public Nullable<int> userID { get; set; }
    
        public virtual admin_user admin_user { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Framework4Project> Framework4Project { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<M_DevProMapping> M_DevProMapping { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<M_testCaseSteps> M_testCaseSteps { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<M_testDemand> M_testDemand { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<project_app> project_app { get; set; }
    }
}
