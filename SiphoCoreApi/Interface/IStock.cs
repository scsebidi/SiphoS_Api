using SiphoCoreApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiphoCoreApi.Implimentation
{
    public interface IStock
    {
        List<StockItemModel> GetStockItems();

        StockItemModel AddStock(StockItemModel stock);

        StockItemModel UpdateStock(StockItemModel stockItem);

        void DeleteStock(StockItemModel stockItem);

        StockItemModel GetBy(Guid id);
    }
}
