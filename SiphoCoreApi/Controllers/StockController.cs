using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SiphoCoreApi.Implimentation;
using SiphoCoreApi.Model;

namespace SiphoCoreApi.Controllers
{
    public class StockController : Controller
    {
        private StockData _db;
    
        public StockController(StockData stockdata)
        {
            _db = stockdata;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetStock()
        {
            try
            {
                var s = _db.GetStockItems();
                return Ok(s);
            }
            catch (Exception ex)
            {
                throw;
            }
         
        }
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddStock(StockItemModel stockItem)
        {
            try
            {
               var stock = _db.AddStock(stockItem);
                return Ok(stock);
            }
            catch (Exception)
            {
                throw;
            }
           
        }
        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult UpdateStockItem(Guid id,StockItemModel stockItem)
        {
            try
            {
                var stockExists = _db.GetBy(id);
                if (stockExists != null)
                {
                    stockItem.id = stockExists.id;
                    _db.UpdateStock(stockItem);
                } 
                return Ok(stockItem);
            }
            catch (Exception)
            {
                throw;
            }
           
        }
        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteStock(Guid id)
        {
            try
            {
                var stock = _db.GetBy(id);
                if (stock != null)
                {
                    _db.DeleteStock(stock);
                    return Ok($"Deleted {stock}");
                }
                return NotFound($"Stock item {id} not found");
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
    }
}
