//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMS201724112128
{
    using System;
    using System.Collections.Generic;
    
    public partial class Equipment
    {
        public int EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentSpecs { get; set; }
        public string EquipmentPicture { get; set; }
        public Nullable<int> EquipmentPrice { get; set; }
        public Nullable<System.DateTime> DatePurchase { get; set; }
        public string StorageLocation { get; set; }
        public Nullable<int> EquipmentManager { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}