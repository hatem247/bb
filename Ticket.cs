//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirportMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public int Ticket_Id { get; set; }
        public Nullable<int> Seat_Number { get; set; }
        public string Passenger_Name { get; set; }
        public string Ticket_Status { get; set; }
        public Nullable<int> Ticket_Price { get; set; }
        public Nullable<int> Passenger_Id { get; set; }
    
        public virtual Passenger Passenger { get; set; }
    }
}
