using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using Consuming_Microservice.Models;


namespace Consuming_Microservice.Controllers
{
    public class ConsumingProductController : Controller
    {
        private readonly HttpClient _httpClient;

        public ConsumingProductController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:44343/api/Product");
        }

        public async Task<ActionResult> Index()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("");
            if (response.IsSuccessStatusCode)
            {
                var products = await response.Content.ReadAsAsync<List<Product>>();
                return View(products);
            }
            else
            {
                return View("Error");
            }
        }

        public async Task<ActionResult> Details(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(id.ToString());
            if (response.IsSuccessStatusCode)
            {
                var product = await response.Content.ReadAsAsync<Product>();
                return View(product);
            }
            else
            {
                return View("Error");
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Product product)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("", product);
            if (response.IsSuccessStatusCode)
            {
                var createdProduct = await response.Content.ReadAsAsync<Product>();
                return RedirectToAction("Details", new { id = createdProduct.Id });
            }
            else
            {
                return View("Error");
            }
        }

        public async Task<ActionResult> Edit(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(id.ToString());
            if (response.IsSuccessStatusCode)
            {
                var product = await response.Content.ReadAsAsync<Product>();
                return View(product);
            }
            else
            {
                return View("Error");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Product product)
        {
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync("", product);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Details", new { id = product.Id });
            }
            else
            {
                return View("Error");
            }
        }

        public async Task<ActionResult> Delete(int id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync(id.ToString());
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Error");
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _httpClient.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
