﻿using Newtonsoft.Json;
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


        public static async Task SaveItemsToDB(List<Item> items)
        {
            string url = $"https://localhost:44343/api/Items/UpsertItems";

            string jsonString = JsonConvert.SerializeObject(items);

            using (HttpContent httpContent = new StringContent(jsonString))
            {
                httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                HttpResponseMessage response =await ApiHelper.ApiClient.PutAsync(url, httpContent);
            }

        }



    }
}
