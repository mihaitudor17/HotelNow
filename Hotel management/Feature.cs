//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel_management
{
    using System;
    using System.Collections.Generic;
    
    public partial class Feature
    {
        public long id { get; set; }
        public long room_id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public bool deleted { get; set; }
    
        public virtual Room Room { get; set; }
    }
}
