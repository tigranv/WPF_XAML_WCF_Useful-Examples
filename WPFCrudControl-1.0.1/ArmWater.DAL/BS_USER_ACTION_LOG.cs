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
    
    public partial class BS_USER_ACTION_LOG
    {
        public System.Guid ID { get; set; }
        public string USER_GUID { get; set; }
        public string USER_IP_ADDRESS { get; set; }
        public Nullable<int> USERID { get; set; }
        public string USER_LOGIN { get; set; }
        public Nullable<System.DateTime> EVENTDATE { get; set; }
        public Nullable<System.DateTime> LASTMODIFIED { get; set; }
        public Nullable<int> ACTION_TYPE { get; set; }
        public Nullable<int> ACTION_TEXT_ID { get; set; }
        public Nullable<int> PARENT_TABLE_ENUM_ID { get; set; }
        public string PARENT_TABLE_NAME { get; set; }
        public Nullable<int> PARENT_OBJECT_ROW_ID { get; set; }
        public Nullable<int> CHILD_TABLE_ENUM_ID { get; set; }
        public string CHILD_TABLE_NAME { get; set; }
        public Nullable<int> CHILD_OBJECT_ROW_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<int> CURRENTINTERVAL { get; set; }
    }
}