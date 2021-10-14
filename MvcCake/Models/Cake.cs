using System;
using System.ComponentModel.DataAnnotations;
namespace MvcCake.Models
{
    public class Cake
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        [DataType(DataType.Date)]
        public DateTime ProductionDate { get; set; }
        public string Comment { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }
    }
}
