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
    
    public partial class TAWDBOLDDUTYRESCNTCALC
    {
        public int ID { get; set; }
        public Nullable<int> CALCINTERVAL { get; set; }
        public Nullable<short> CALCULATED { get; set; }
        public Nullable<decimal> DUTYEND { get; set; }
        public Nullable<decimal> DUTYSTART { get; set; }
        public Nullable<decimal> FSM { get; set; }
        public Nullable<int> KEYOBJECT { get; set; }
        public Nullable<System.DateTime> LASTMODIFIED { get; set; }
        public Nullable<decimal> CREDITCOVEREDBYAMOUNT { get; set; }
        public Nullable<decimal> CREDITCOVEREDBYFSM { get; set; }
        public Nullable<int> CONTRACTCALC { get; set; }
        public Nullable<int> BRANCH { get; set; }
        public Nullable<decimal> CREDITINCREMENTBYFSM { get; set; }
        public Nullable<decimal> DEBETCOVEREDBYFSM { get; set; }
        public Nullable<decimal> DEBETCOVEREDBYNEWCREDIT { get; set; }
        public Nullable<decimal> DEBETINCREMENTBYFSM { get; set; }
    }
}
