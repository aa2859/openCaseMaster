//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace openCaseMaster.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class M_publicTaskScript
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string script { get; set; }
        public int taskID { get; set; }
    
        public virtual M_publicTask M_publicTask { get; set; }
    }
}