using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;




namespace Helper
{
    public static class ItemsProcessor
    {

        public static async Task<List<Item>> LoadItems(string searchingPhrase, int page = 1)
        {
            string url = $"https://localhost:44343/api/Items/Parse?name={ searchingPhrase }&page={ page }";


            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<Item> items = await response.Content.ReadAsAsync<List<Item>>();

                    return items;
                }
                else
                    throw new Exception(response.ReasonPhrase);
            }

        }


        public static async Task<List<Item>> LoadItemsFromDB(string searchingPhrase)
        {
            var url = $"https://localhost:44343/api/Items/GetFromDB?searchedPhrase={searchingPhrase}";

            using (HttpResponseMessage responseMessage = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (responseMessage.IsSuccessStatusCode)
                {
                    var items = await responseMessage.Content.ReadAsAsync<List<Item>>();

                    return items;
                }
                else
                    throw new Exception(responseMessage.ReasonPhrase);
            }

        }




        public static async Task SaveItemsToDB(List<Item> items)
        {
            string url = $"https://localhost:44343/api/Items/UpsertItems";
            var itemsJson = JsonConvert.SerializeObject(items);
            var httpContent = new StringContent(itemsJson, Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsync(url, httpContent))
            {
                if (!response.IsSuccessStatusCode)
                    throw new Exception(response.ReasonPhrase);
            }



        }




    }
}
