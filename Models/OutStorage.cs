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
    
    public partial class OutStorage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OutStorage()
        {
            this.OutStoDetail = new HashSet<OutStoDetail>();
        }
    
        public int ID { get; set; }
        public string OrderNum { get; set; }
        public int OutType { get; set; }
        public int ProductType { get; set; }
        public int StorageNum { get; set; }
        public string CusNum { get; set; }
        public string CusName { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ContractOrder { get; set; }
        public Nullable<double> Num { get; set; }
        public Nullable<double> Amount { get; set; }
        public Nullable<double> Weight { get; set; }
        public System.DateTime SendDate { get; set; }
        public int Status { get; set; }
        public int IsDelete { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string CreateUser { get; set; }
        public string AuditUser { get; set; }
        public Nullable<System.DateTime> AuditeTime { get; set; }
        public string PrintUser { get; set; }
        public Nullable<System.DateTime> PrintTime { get; set; }
        public string Reason { get; set; }
        public int OperateType { get; set; }
        public string EquipmentNum { get; set; }
        public string EquipmentCode { get; set; }
        public string Remark { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OutStoDetail> OutStoDetail { get; set; }
        public virtual Product Product { get; set; }
        public virtual Storage Storage { get; set; }
    }
}
