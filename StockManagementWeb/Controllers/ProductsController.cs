using Microsoft.AspNetCore.Mvc;
using StockManagementWeb.Models;
using System.Text;
using System.Text.Json;

namespace StockManagementWeb.Controllers
{
    public class ProductsController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl = "http://localhost:5099/api/products";

        public ProductsController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // GET: Products
        public async Task<IActionResult> Index(string searchTerm = "")
        {
            try
            {
                var url = string.IsNullOrEmpty(searchTerm) 
                    ? _apiBaseUrl 
                    : $"{_apiBaseUrl}/search?query={Uri.EscapeDataString(searchTerm)}";
                
                var response = await _httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var products = JsonSerializer.Deserialize<List<Product>>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return View(products ?? new List<Product>());
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"Error connecting to API: {ex.Message}";
            }
            
            return View(new List<Product>());
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Description,Price,Quantity,Category,SKU")] Product product)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var json = JsonSerializer.Serialize(product);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    
                    var response = await _httpClient.PostAsync(_apiBaseUrl, content);
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ViewBag.ErrorMessage = $"Error creating product: {response.StatusCode}";
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = $"Error connecting to API: {ex.Message}";
                }
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_apiBaseUrl}/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var product = JsonSerializer.Deserialize<Product>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return View(product);
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"Error connecting to API: {ex.Message}";
            }
            
            return NotFound();
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Price,Quantity,Category,SKU")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var json = JsonSerializer.Serialize(product);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    
                    var response = await _httpClient.PutAsync($"{_apiBaseUrl}/{id}", content);
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ViewBag.ErrorMessage = $"Error updating product: {response.StatusCode}";
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = $"Error connecting to API: {ex.Message}";
                }
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_apiBaseUrl}/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var product = JsonSerializer.Deserialize<Product>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return View(product);
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"Error connecting to API: {ex.Message}";
            }
            
            return NotFound();
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"{_apiBaseUrl}/{id}");
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.ErrorMessage = $"Error deleting product: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = $"Error connecting to API: {ex.Message}";
            }
            
            return RedirectToAction(nameof(Index));
        }
    }
}
