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
    
    public partial class TAWDBPAYMENT
    {
        public int ID { get; set; }
        public Nullable<decimal> AMOUNT { get; set; }
        public Nullable<int> BANK { get; set; }
        public string BANKACCOUNT { get; set; }
        public Nullable<int> BILLINGCYCLEVISIT { get; set; }
        public Nullable<int> CONTRACT { get; set; }
        public Nullable<System.DateTime> EVENTDATE { get; set; }
        public Nullable<short> IMPORTED { get; set; }
        public Nullable<short> ISCORRECTION { get; set; }
        public Nullable<System.DateTime> LASTMODIFIED { get; set; }
        public string NUMBER { get; set; }
        public Nullable<short> PYMTYPE { get; set; }
    }
}
