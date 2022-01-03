using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ples_Claudiu_Lab12_proiect.Models;

namespace Ples_Claudiu_Lab12_proiect.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}