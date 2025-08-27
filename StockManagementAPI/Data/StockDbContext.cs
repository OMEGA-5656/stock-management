
using Microsoft.EntityFrameworkCore;
using StockManagementAPI.Models;

namespace StockManagementAPI.Data
{
    public class StockDbContext : DbContext
    {
        public StockDbContext(DbContextOptions<StockDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Product entity
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Description).HasMaxLength(500);
                entity.Property(e => e.Price).HasColumnType("decimal(18,2)");
                entity.Property(e => e.Category).HasMaxLength(50);
                entity.Property(e => e.SKU).HasMaxLength(50);
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");
                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            // Seed sample products
            modelBuilder.Entity<Product>().HasData(
                // Electronics
                new Product { Id = 1, Name = "Laptop", Description = "High-performance laptop for business use", Price = 999.99m, Quantity = 15, Category = "Electronics", SKU = "LAP001" },
                new Product { Id = 2, Name = "Mouse", Description = "Wireless optical mouse", Price = 25.99m, Quantity = 50, Category = "Electronics", SKU = "MOU001" },
                new Product { Id = 3, Name = "Keyboard", Description = "Mechanical gaming keyboard", Price = 89.99m, Quantity = 25, Category = "Electronics", SKU = "KEY001" },
                new Product { Id = 4, Name = "Monitor", Description = "24-inch LED monitor", Price = 199.99m, Quantity = 30, Category = "Electronics", SKU = "MON001" },
                new Product { Id = 5, Name = "Headphones", Description = "Noise-cancelling wireless headphones", Price = 149.99m, Quantity = 40, Category = "Electronics", SKU = "HEA001" },
                
                // Office Supplies
                new Product { Id = 6, Name = "Notebook", Description = "Spiral-bound notebook, 100 pages", Price = 5.99m, Quantity = 200, Category = "Office Supplies", SKU = "NOT001" },
                new Product { Id = 7, Name = "Pen Set", Description = "Pack of 10 blue ballpoint pens", Price = 8.99m, Quantity = 150, Category = "Office Supplies", SKU = "PEN001" },
                new Product { Id = 8, Name = "Stapler", Description = "Heavy-duty office stapler", Price = 12.99m, Quantity = 75, Category = "Office Supplies", SKU = "STA001" },
                new Product { Id = 9, Name = "Paper Clips", Description = "Box of 100 metal paper clips", Price = 3.99m, Quantity = 300, Category = "Office Supplies", SKU = "PAP001" },
                new Product { Id = 10, Name = "Desk Organizer", Description = "Multi-compartment desk organizer", Price = 19.99m, Quantity = 60, Category = "Office Supplies", SKU = "DES001" },
                
                // Furniture
                new Product { Id = 11, Name = "Office Chair", Description = "Ergonomic office chair with lumbar support", Price = 299.99m, Quantity = 20, Category = "Furniture", SKU = "CHA001" },
                new Product { Id = 12, Name = "Desk", Description = "Modern wooden desk with drawers", Price = 399.99m, Quantity = 15, Category = "Furniture", SKU = "DES002" },
                new Product { Id = 13, Name = "Bookshelf", Description = "5-shelf wooden bookshelf", Price = 149.99m, Quantity = 25, Category = "Furniture", SKU = "BOO001" },
                new Product { Id = 14, Name = "Filing Cabinet", Description = "2-drawer metal filing cabinet", Price = 89.99m, Quantity = 35, Category = "Furniture", SKU = "FIL001" },
                new Product { Id = 15, Name = "Coffee Table", Description = "Glass top coffee table", Price = 199.99m, Quantity = 18, Category = "Furniture", SKU = "COF001" },
                
                // Clothing
                new Product { Id = 16, Name = "T-Shirt", Description = "Cotton crew neck t-shirt", Price = 15.99m, Quantity = 100, Category = "Clothing", SKU = "TSH001" },
                new Product { Id = 17, Name = "Jeans", Description = "Blue denim jeans", Price = 49.99m, Quantity = 80, Category = "Clothing", SKU = "JEA001" },
                new Product { Id = 18, Name = "Sneakers", Description = "Casual athletic sneakers", Price = 79.99m, Quantity = 60, Category = "Clothing", SKU = "SNE001" },
                new Product { Id = 19, Name = "Hoodie", Description = "Fleece-lined hooded sweatshirt", Price = 39.99m, Quantity = 70, Category = "Clothing", SKU = "HOO001" },
                new Product { Id = 20, Name = "Jacket", Description = "Waterproof windbreaker jacket", Price = 89.99m, Quantity = 45, Category = "Clothing", SKU = "JAC001" },
                
                // Books
                new Product { Id = 21, Name = "Programming Book", Description = "Learn C# programming", Price = 29.99m, Quantity = 40, Category = "Books", SKU = "BOO002" },
                new Product { Id = 22, Name = "Novel", Description = "Bestselling fiction novel", Price = 14.99m, Quantity = 120, Category = "Books", SKU = "NOV001" },
                new Product { Id = 23, Name = "Cookbook", Description = "Collection of Italian recipes", Price = 24.99m, Quantity = 55, Category = "Books", SKU = "COO001" },
                new Product { Id = 24, Name = "Self-Help Book", Description = "Personal development guide", Price = 19.99m, Quantity = 85, Category = "Books", SKU = "SEL001" },
                new Product { Id = 25, Name = "History Book", Description = "World history encyclopedia", Price = 34.99m, Quantity = 30, Category = "Books", SKU = "HIS001" },
                
                // Sports Equipment
                new Product { Id = 26, Name = "Basketball", Description = "Official size basketball", Price = 29.99m, Quantity = 50, Category = "Sports", SKU = "BAS001" },
                new Product { Id = 27, Name = "Tennis Racket", Description = "Professional tennis racket", Price = 89.99m, Quantity = 25, Category = "Sports", SKU = "TEN001" },
                new Product { Id = 28, Name = "Yoga Mat", Description = "Non-slip yoga mat", Price = 19.99m, Quantity = 80, Category = "Sports", SKU = "YOG001" },
                new Product { Id = 29, Name = "Dumbbells", Description = "Set of 10lb dumbbells", Price = 39.99m, Quantity = 40, Category = "Sports", SKU = "DUM001" },
                new Product { Id = 30, Name = "Running Shoes", Description = "Professional running shoes", Price = 119.99m, Quantity = 35, Category = "Sports", SKU = "RUN001" },
                
                // Home & Garden
                new Product { Id = 31, Name = "Garden Hose", Description = "50ft expandable garden hose", Price = 34.99m, Quantity = 45, Category = "Home & Garden", SKU = "GAR001" },
                new Product { Id = 32, Name = "Plant Pot", Description = "Ceramic plant pot with drainage", Price = 12.99m, Quantity = 100, Category = "Home & Garden", SKU = "PLA001" },
                new Product { Id = 33, Name = "Garden Tools", Description = "Set of 5 essential garden tools", Price = 49.99m, Quantity = 30, Category = "Home & Garden", SKU = "TOO001" },
                new Product { Id = 34, Name = "Bird Feeder", Description = "Hanging bird feeder", Price = 24.99m, Quantity = 60, Category = "Home & Garden", SKU = "BIR001" },
                new Product { Id = 35, Name = "Outdoor Chair", Description = "Folding outdoor chair", Price = 39.99m, Quantity = 55, Category = "Home & Garden", SKU = "OUT001" },
                
                // Kitchen & Dining
                new Product { Id = 36, Name = "Coffee Maker", Description = "Programmable coffee maker", Price = 79.99m, Quantity = 25, Category = "Kitchen", SKU = "COF002" },
                new Product { Id = 37, Name = "Blender", Description = "High-speed blender", Price = 59.99m, Quantity = 35, Category = "Kitchen", SKU = "BLE001" },
                new Product { Id = 38, Name = "Dinner Plates", Description = "Set of 8 ceramic dinner plates", Price = 44.99m, Quantity = 40, Category = "Kitchen", SKU = "PLA002" },
                new Product { Id = 39, Name = "Cutlery Set", Description = "Stainless steel cutlery set", Price = 29.99m, Quantity = 50, Category = "Kitchen", SKU = "CUT001" },
                new Product { Id = 40, Name = "Mixing Bowls", Description = "Set of 3 nesting mixing bowls", Price = 19.99m, Quantity = 65, Category = "Kitchen", SKU = "MIX001" },
                
                // Toys & Games
                new Product { Id = 41, Name = "Board Game", Description = "Family strategy board game", Price = 34.99m, Quantity = 45, Category = "Toys & Games", SKU = "BOA001" },
                new Product { Id = 42, Name = "Puzzle", Description = "1000-piece jigsaw puzzle", Price = 14.99m, Quantity = 70, Category = "Toys & Games", SKU = "PUZ001" },
                new Product { Id = 43, Name = "Building Blocks", Description = "Construction toy set", Price = 49.99m, Quantity = 40, Category = "Toys & Games", SKU = "BLD001" },
                new Product { Id = 44, Name = "Art Supplies", Description = "Complete art kit for kids", Price = 24.99m, Quantity = 55, Category = "Toys & Games", SKU = "ART001" },
                new Product { Id = 45, Name = "Remote Control Car", Description = "High-speed RC car", Price = 39.99m, Quantity = 30, Category = "Toys & Games", SKU = "CAR001" },
                
                // Health & Beauty
                new Product { Id = 46, Name = "Shampoo", Description = "Natural hair care shampoo", Price = 12.99m, Quantity = 90, Category = "Health & Beauty", SKU = "SHA001" },
                new Product { Id = 47, Name = "Toothbrush", Description = "Electric toothbrush with timer", Price = 29.99m, Quantity = 75, Category = "Health & Beauty", SKU = "TOO002" },
                new Product { Id = 48, Name = "Face Cream", Description = "Anti-aging face cream", Price = 19.99m, Quantity = 60, Category = "Health & Beauty", SKU = "FAC001" },
                new Product { Id = 49, Name = "Vitamins", Description = "Daily multivitamin supplement", Price = 15.99m, Quantity = 100, Category = "Health & Beauty", SKU = "VIT001" },
                new Product { Id = 50, Name = "Hand Sanitizer", Description = "Alcohol-based hand sanitizer", Price = 8.99m, Quantity = 150, Category = "Health & Beauty", SKU = "HAN001" }
            );
        }
    }
}
