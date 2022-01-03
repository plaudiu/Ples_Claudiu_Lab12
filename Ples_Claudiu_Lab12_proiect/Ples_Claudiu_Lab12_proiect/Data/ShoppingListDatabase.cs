using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ples_Claudiu_Lab12_proiect.Models;

namespace Ples_Claudiu_Lab12_proiect.Data
{
    public class ShoppingListDatabase
    {
        IRestService restService;
        private RestService restService1;

        public ShoppingListDatabase(IRestService service)
        {
            restService = service;
        }

        public ShoppingListDatabase(RestService restService1)
        {
            this.restService1 = restService1;
        }

        public Task<List<ShopList>> GetShopListsAsync()
        {
            return restService.RefreshDataAsync();
        }

        public Task SaveShopListAsync(ShopList item, bool isNewItem = true)
        {
            return restService.SaveShopListAsync(item, isNewItem);
        }
        public Task DeleteShopListAsync(ShopList item)
        {
            return restService.DeleteShopListAsync(item.ID);
        }
    }
}
