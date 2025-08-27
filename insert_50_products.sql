-- Insert 50 sample products into the Products table
INSERT INTO Products (Id, Name, Description, Price, Quantity, Category, SKU, CreatedAt, UpdatedAt) VALUES
-- Electronics
(1, 'Laptop', 'High-performance laptop for business use', 999.99, 15, 'Electronics', 'LAP001', NOW(), NOW()),
(2, 'Mouse', 'Wireless optical mouse', 25.99, 50, 'Electronics', 'MOU001', NOW(), NOW()),
(3, 'Keyboard', 'Mechanical gaming keyboard', 89.99, 25, 'Electronics', 'KEY001', NOW(), NOW()),
(4, 'Monitor', '24-inch LED monitor', 199.99, 30, 'Electronics', 'MON001', NOW(), NOW()),
(5, 'Headphones', 'Noise-cancelling wireless headphones', 149.99, 40, 'Electronics', 'HEA001', NOW(), NOW()),

-- Office Supplies
(6, 'Notebook', 'Spiral-bound notebook, 100 pages', 5.99, 200, 'Office Supplies', 'NOT001', NOW(), NOW()),
(7, 'Pen Set', 'Pack of 10 blue ballpoint pens', 8.99, 150, 'Office Supplies', 'PEN001', NOW(), NOW()),
(8, 'Stapler', 'Heavy-duty office stapler', 12.99, 75, 'Office Supplies', 'STA001', NOW(), NOW()),
(9, 'Paper Clips', 'Box of 100 metal paper clips', 3.99, 300, 'Office Supplies', 'PAP001', NOW(), NOW()),
(10, 'Desk Organizer', 'Multi-compartment desk organizer', 19.99, 60, 'Office Supplies', 'DES001', NOW(), NOW()),

-- Furniture
(11, 'Office Chair', 'Ergonomic office chair with lumbar support', 299.99, 20, 'Furniture', 'CHA001', NOW(), NOW()),
(12, 'Desk', 'Modern wooden desk with drawers', 399.99, 15, 'Furniture', 'DES002', NOW(), NOW()),
(13, 'Bookshelf', '5-shelf wooden bookshelf', 149.99, 25, 'Furniture', 'BOO001', NOW(), NOW()),
(14, 'Filing Cabinet', '2-drawer metal filing cabinet', 89.99, 35, 'Furniture', 'FIL001', NOW(), NOW()),
(15, 'Coffee Table', 'Glass top coffee table', 199.99, 18, 'Furniture', 'COF001', NOW(), NOW()),

-- Clothing
(16, 'T-Shirt', 'Cotton crew neck t-shirt', 15.99, 100, 'Clothing', 'TSH001', NOW(), NOW()),
(17, 'Jeans', 'Blue denim jeans', 49.99, 80, 'Clothing', 'JEA001', NOW(), NOW()),
(18, 'Sneakers', 'Casual athletic sneakers', 79.99, 60, 'Clothing', 'SNE001', NOW(), NOW()),
(19, 'Hoodie', 'Fleece-lined hooded sweatshirt', 39.99, 70, 'Clothing', 'HOO001', NOW(), NOW()),
(20, 'Jacket', 'Waterproof windbreaker jacket', 89.99, 45, 'Clothing', 'JAC001', NOW(), NOW()),

-- Books
(21, 'Programming Book', 'Learn C# programming', 29.99, 40, 'Books', 'BOO002', NOW(), NOW()),
(22, 'Novel', 'Bestselling fiction novel', 14.99, 120, 'Books', 'NOV001', NOW(), NOW()),
(23, 'Cookbook', 'Collection of Italian recipes', 24.99, 55, 'Books', 'COO001', NOW(), NOW()),
(24, 'Self-Help Book', 'Personal development guide', 19.99, 85, 'Books', 'SEL001', NOW(), NOW()),
(25, 'History Book', 'World history encyclopedia', 34.99, 30, 'Books', 'HIS001', NOW(), NOW()),

-- Sports Equipment
(26, 'Basketball', 'Official size basketball', 29.99, 50, 'Sports', 'BAS001', NOW(), NOW()),
(27, 'Tennis Racket', 'Professional tennis racket', 89.99, 25, 'Sports', 'TEN001', NOW(), NOW()),
(28, 'Yoga Mat', 'Non-slip yoga mat', 19.99, 80, 'Sports', 'YOG001', NOW(), NOW()),
(29, 'Dumbbells', 'Set of 10lb dumbbells', 39.99, 40, 'Sports', 'DUM001', NOW(), NOW()),
(30, 'Running Shoes', 'Professional running shoes', 119.99, 35, 'Sports', 'RUN001', NOW(), NOW()),

-- Home & Garden
(31, 'Garden Hose', '50ft expandable garden hose', 34.99, 45, 'Home & Garden', 'GAR001', NOW(), NOW()),
(32, 'Plant Pot', 'Ceramic plant pot with drainage', 12.99, 100, 'Home & Garden', 'PLA001', NOW(), NOW()),
(33, 'Garden Tools', 'Set of 5 essential garden tools', 49.99, 30, 'Home & Garden', 'TOO001', NOW(), NOW()),
(34, 'Bird Feeder', 'Hanging bird feeder', 24.99, 60, 'Home & Garden', 'BIR001', NOW(), NOW()),
(35, 'Outdoor Chair', 'Folding outdoor chair', 39.99, 55, 'Home & Garden', 'OUT001', NOW(), NOW()),

-- Kitchen & Dining
(36, 'Coffee Maker', 'Programmable coffee maker', 79.99, 25, 'Kitchen', 'COF002', NOW(), NOW()),
(37, 'Blender', 'High-speed blender', 59.99, 35, 'Kitchen', 'BLE001', NOW(), NOW()),
(38, 'Dinner Plates', 'Set of 8 ceramic dinner plates', 44.99, 40, 'Kitchen', 'PLA002', NOW(), NOW()),
(39, 'Cutlery Set', 'Stainless steel cutlery set', 29.99, 50, 'Kitchen', 'CUT001', NOW(), NOW()),
(40, 'Mixing Bowls', 'Set of 3 nesting mixing bowls', 19.99, 65, 'Kitchen', 'MIX001', NOW(), NOW()),

-- Toys & Games
(41, 'Board Game', 'Family strategy board game', 34.99, 45, 'Toys & Games', 'BOA001', NOW(), NOW()),
(42, 'Puzzle', '1000-piece jigsaw puzzle', 14.99, 70, 'Toys & Games', 'PUZ001', NOW(), NOW()),
(43, 'Building Blocks', 'Construction toy set', 49.99, 40, 'Toys & Games', 'BLD001', NOW(), NOW()),
(44, 'Art Supplies', 'Complete art kit for kids', 24.99, 55, 'Toys & Games', 'ART001', NOW(), NOW()),
(45, 'Remote Control Car', 'High-speed RC car', 39.99, 30, 'Toys & Games', 'CAR001', NOW(), NOW()),

-- Health & Beauty
(46, 'Shampoo', 'Natural hair care shampoo', 12.99, 90, 'Health & Beauty', 'SHA001', NOW(), NOW()),
(47, 'Toothbrush', 'Electric toothbrush with timer', 29.99, 75, 'Health & Beauty', 'TOO002', NOW(), NOW()),
(48, 'Face Cream', 'Anti-aging face cream', 19.99, 60, 'Health & Beauty', 'FAC001', NOW(), NOW()),
(49, 'Vitamins', 'Daily multivitamin supplement', 15.99, 100, 'Health & Beauty', 'VIT001', NOW(), NOW()),
(50, 'Hand Sanitizer', 'Alcohol-based hand sanitizer', 8.99, 150, 'Health & Beauty', 'HAN001', NOW(), NOW());
