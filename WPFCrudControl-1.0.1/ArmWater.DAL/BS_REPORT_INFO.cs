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
    
    public partial class BS_REPORT_INFO
    {
        public int ID { get; set; }
        public string db_colname { get; set; }
        public Nullable<short> is_readonly { get; set; }
        public Nullable<short> is_visible { get; set; }
        public Nullable<short> is_mandatory { get; set; }
        public Nullable<short> is_prop_visible { get; set; }
        public string type { get; set; }
        public string db_type { get; set; }
        public Nullable<short> is_libvalue { get; set; }
        public string default_value { get; set; }
        public Nullable<short> is_added { get; set; }
        public Nullable<int> query_id { get; set; }
        public Nullable<short> has_format { get; set; }
        public string format { get; set; }
        public Nullable<short> is_sortable { get; set; }
        public Nullable<int> text_id { get; set; }
        public string table_name { get; set; }
        public Nullable<short> has_history { get; set; }
        public Nullable<int> selection_mode { get; set; }
        public Nullable<int> note_id { get; set; }
        public Nullable<int> min_value { get; set; }
        public Nullable<int> max_value { get; set; }
        public string lib_filter_colname { get; set; }
        public Nullable<short> is_multiedit { get; set; }
        public Nullable<short> has_property { get; set; }
        public Nullable<int> listindex { get; set; }
        public Nullable<short> is_search_visible { get; set; }
        public Nullable<short> is_search_prop_visible { get; set; }
        public string call_depended_sp { get; set; }
        public Nullable<short> readonly_depended_createddate { get; set; }
        public Nullable<short> is_sum_for_multiselection { get; set; }
        public string call_depended_sp_pre { get; set; }
        public Nullable<int> refresh_type { get; set; }
        public Nullable<short> is_imported { get; set; }
        public Nullable<short> is_cached { get; set; }
        public int sub_entity_type { get; set; }
        public string min_depend_colname { get; set; }
        public string max_depend_colname { get; set; }
    }
}
