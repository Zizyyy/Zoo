//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zoo.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public int TypeTicketID { get; set; }
        public System.DateTime DateSale { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual TypeTicket TypeTicket { get; set; }
    }
}
