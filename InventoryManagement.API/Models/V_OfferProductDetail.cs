//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventoryManagement.API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_OfferProductDetail
    {
        public string ParentProdId { get; set; }
        public string ParentProductName { get; set; }
        public string ProdId { get; set; }
        public string ProductName { get; set; }
        public string ParentBatchNo { get; set; }
        public string SubBatchNo { get; set; }
        public decimal ParentProdQty { get; set; }
        public decimal SubProdQty { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public string IsCardIssue { get; set; }
        public string Scheme { get; set; }
        public string TaxApplied { get; set; }
        public string BvApplied { get; set; }
        public string Formula { get; set; }
        public string ActiveStatus { get; set; }
        public string Remarks { get; set; }
    }
}
