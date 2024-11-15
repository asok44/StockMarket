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
                MarketCap = stockmodel.MarketCap,
                Comments = stockmodel.Comments.Select(c => c.ToCommentDto()).ToList()
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

        public static Stock ToStockFromFMP(this FMPStock fMPStock)
        {
            return new Stock
            {
                Symbol = fMPStock.symbol,
                CompanyName = fMPStock.companyName,
                Purchase = (decimal)fMPStock.price,
                LastDiv = (decimal)fMPStock.lastDiv,
                Industry = fMPStock.industry,
                MarketCap = fMPStock.mktCap
            };
        }
    }
}