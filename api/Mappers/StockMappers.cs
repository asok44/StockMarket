using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Stock;
using api.Models;

namespace api.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stockmodel)
        {
            return new StockDto
            {
                Id = stockmodel.Id,
                Symbol = stockmodel.Symbol,
                CompanyName = stockmodel.CompanyName,
                Purchase = stockmodel.Purchase,
                LastDiv = stockmodel.LastDiv,
                Industry = stockmodel.Industry,
                MarketCap = stockmodel.MarketCap
            };
        }

        public static Stock ToStockFromCreateDto(this CreateStockRequestDto sockDto)
        {
            return new Stock
            {
                Symbol = sockDto.Symbol,
                CompanyName = sockDto.CompanyName,
                Purchase = sockDto.Purchase,
                LastDiv = sockDto.LastDiv,
                Industry = sockDto.Industry,
                MarketCap = sockDto.MarketCap
            };
        }
    }
}