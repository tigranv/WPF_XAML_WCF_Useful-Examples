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
    
    public partial class TAWDBCITY
    {
        public int ID { get; set; }
        public Nullable<short> CITYKIND { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public Nullable<System.DateTime> DESTROYDATE { get; set; }
        public Nullable<System.DateTime> LASTMODIFIED { get; set; }
        public string NAME { get; set; }
        public Nullable<int> REGION { get; set; }
        public Nullable<double> LONGITUDE { get; set; }
        public Nullable<double> LATITUDE { get; set; }
        public string CENTER_GEOM { get; set; }
        public string SHAPE_GEOM { get; set; }
        public Nullable<int> OLD_ID { get; set; }
    }
}
