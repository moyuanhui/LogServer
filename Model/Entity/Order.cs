using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogServer.Model.Entity { 


    public class Order : Entity
    {
        public string OrderID { get; set; }
        public string MemberID { get; set; }
        public Nullable<decimal> OrderTotalAmount { get; set; }
        public Nullable<decimal> OrderPayableAmount { get; set; }
        public Nullable<decimal> OrderPaymentAmount { get; set; }
        public Nullable<decimal> OrderFreight { get; set; }
        public string Handler { get; set; }
        public string AdressID { get; set; }
        public string OrderConsignee { get; set; }
        public string OrderPaymentMode { get; set; }
        public Nullable<System.DateTime> OrderPaymentTime { get; set; }
        public string OrderPaymentDescription { get; set; }
        public string OrderDeliveryMode { get; set; }
        public string OrderWaybillNO { get; set; }
        public string OrderCarrier { get; set; }
        public string OrderDeliveryDescription { get; set; }
        public string NeedInvoiceOrNot { get; set; }
        public string OrderInvoiceType { get; set; }
        public string OrderInvoiceTitle { get; set; }
        public string OrderInvoiceContent { get; set; }
        public Nullable<System.DateTime> OrderAddTime { get; set; }
        public string OrderStatus { get; set; }
        public Nullable<System.DateTime> OrderDeliveryTime { get; set; }
        public string OrderSignBillDescription { get; set; }
        public string LogicallyDeleteOrNot { get; set; }
        public string Remarks { get; set; }
    }
}
