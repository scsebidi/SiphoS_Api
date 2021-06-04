using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiphoCoreApi.Model
{
    public class StockItemModel
    {
        [Key]
        public Guid id { get; set; }
        public string VehicleRegistration { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime ModelYear { get; set; }
        public int KMS { get; set; }
        public string Colour { get; set; }
        public string VIN { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal RetailPrice { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal CostPrice { get; set; }
        public List<ImagesModel> Images { get; set; }
        public List<StockAccessoryModel> Assesorry { get; set; }
        public DateTime DTCreated { get; set; }
        public DateTime DTUpdated { get; set; }
    }
    public class StockAccessoryModel
    {
        public int id { get; set; }
        public string Description { get; set; }
        public StockItemModel StockItemModel { get; set; }

    }
    public class Root
    {
        public StockItemModel StockItemModel { get; set; }
    }
    public class ImagesModel
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public StockItemModel StockItemModel { get; set; }
    }
}
