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
    
    public partial class BS_PRIVILEGE_CLASS
    {
        public int ID { get; set; }
        public Nullable<int> TEXT_ID { get; set; }
        public string COMMENT { get; set; }
        public string table_name { get; set; }
        public Nullable<int> has_priv { get; set; }
        public Nullable<int> has_query { get; set; }
        public Nullable<int> enum_id { get; set; }
        public string query { get; set; }
        public Nullable<int> has_changes { get; set; }
        public Nullable<int> has_search { get; set; }
        public Nullable<int> change_text_id { get; set; }
        public Nullable<int> note_id { get; set; }
        public Nullable<int> has_user_action_log { get; set; }
    }
}
