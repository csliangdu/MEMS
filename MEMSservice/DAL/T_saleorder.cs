//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MEMSservice.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_saleorder
    {
        public int id { get; set; }
        public string saleno { get; set; }
        public System.DateTime saledate { get; set; }
        public int receiveperiodtype { get; set; }
        public Nullable<int> receiveperiod { get; set; }
        public int receivetype { get; set; }
        public int receivestate { get; set; }
        public int orderstate { get; set; }
        public Nullable<decimal> saletotalamount { get; set; }
        public Nullable<decimal> receiveamount { get; set; }
        public Nullable<decimal> receiveratio { get; set; }
        public int quotationid { get; set; }
        public string remarks { get; set; }
        public int customerid { get; set; }
    }
}
