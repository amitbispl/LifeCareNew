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
    
    public partial class StockDetail_Result1
    {
        public string FCode { get; set; }
        public string PartyName { get; set; }
        public string ProdID { get; set; }
        public string ProductName { get; set; }
        public decimal DP { get; set; }
        public decimal OpStock { get; set; }
        public decimal InStock { get; set; }
        public decimal StockOut { get; set; }
        public decimal ClsStock { get; set; }
        public Nullable<decimal> OpStockValue { get; set; }
        public Nullable<decimal> InStockValue { get; set; }
        public Nullable<decimal> StockOutValue { get; set; }
        public Nullable<decimal> ClsStockValue { get; set; }
    }
}
