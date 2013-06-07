//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpartanHotels.Repository.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        public string ReservationID { get; set; }
        public Nullable<int> ConfirmationNum { get; set; }
        public Nullable<int> HotelRoomID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<int> BookStatusID { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual BookingStatu BookingStatu { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual HotelRoom HotelRoom { get; set; }
    }
}
