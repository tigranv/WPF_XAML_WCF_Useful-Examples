//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArmWater.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class BS_STANDARD_REPORTS_BUILDER
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string XML_DOCUMENT { get; set; }
        public Nullable<int> USERID { get; set; }
        public Nullable<System.DateTime> LASTMODIFIED { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> DESTROYDATE { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<int> STANDARD_REPORT_ID { get; set; }
    }
}
