//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeMvc
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_city
    {
        public tbl_city()
        {
            this.tbl_EmployeeDetails = new HashSet<tbl_EmployeeDetails>();
        }
    
        public int cit_Id { get; set; }
        public string cit_name { get; set; }
        public int cit_couId { get; set; }
    
        public virtual tbl_Country tbl_Country { get; set; }
        public virtual ICollection<tbl_EmployeeDetails> tbl_EmployeeDetails { get; set; }
    }
}
