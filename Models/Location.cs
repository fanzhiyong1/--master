//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Location
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Location()
        {
            this.BadReportDetail = new HashSet<BadReportDetail>();
            this.BadReportDetail1 = new HashSet<BadReportDetail>();
            this.InStorDetail = new HashSet<InStorDetail>();
            this.InventoryBook = new HashSet<InventoryBook>();
            this.InventoryBook1 = new HashSet<InventoryBook>();
            this.MoveOrderDetail = new HashSet<MoveOrderDetail>();
            this.MoveOrderDetail1 = new HashSet<MoveOrderDetail>();
            this.OutStoDetail = new HashSet<OutStoDetail>();
            this.Product = new HashSet<Product>();
            this.ReturnDetail = new HashSet<ReturnDetail>();
        }
    
        public int ID { get; set; }
        public string LocalNum { get; set; }
        public string LocalBarCode { get; set; }
        public string LocalName { get; set; }
        public string StorageNum { get; set; }
        public int StorageType { get; set; }
        public int LocalType { get; set; }
        public string Rack { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public int UnitNum { get; set; }
        public string UnitName { get; set; }
        public string Remark { get; set; }
        public int IsForbid { get; set; }
        public int IsDefault { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BadReportDetail> BadReportDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BadReportDetail> BadReportDetail1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InStorDetail> InStorDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryBook> InventoryBook { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryBook> InventoryBook1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MoveOrderDetail> MoveOrderDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MoveOrderDetail> MoveOrderDetail1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OutStoDetail> OutStoDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnDetail> ReturnDetail { get; set; }
    }
}
