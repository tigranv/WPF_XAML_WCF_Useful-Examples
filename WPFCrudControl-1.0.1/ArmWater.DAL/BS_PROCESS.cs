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
    
    public partial class BS_PROCESS
    {
        public System.Guid ID { get; set; }
        public string USER_GUID { get; set; }
        public string USER_IP_ADDRESS { get; set; }
        public string USER_LOGIN { get; set; }
        public string ACTION_GUID { get; set; }
        public string USER_CONTRACT_NAME { get; set; }
        public string SP_NAME { get; set; }
        public Nullable<int> SP_SPID { get; set; }
        public Nullable<System.DateTime> SP_START_TIME { get; set; }
    }
}