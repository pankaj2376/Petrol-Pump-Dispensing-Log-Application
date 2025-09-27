using System;
using System.ComponentModel.DataAnnotations;

namespace PetrolPumpLog.Models
{
    public class DispensingRecord
    {
        public int Id { get; set; }                     
        public string DispenserNo { get; set; }         
        public decimal QuantityLiters { get; set; }     
        public string VehicleNumber { get; set; }       
        public string PaymentMode { get; set; }         
        public string PaymentProofFileName { get; set; }
        public DateTime CreatedAt { get; set; }         
    }

}
