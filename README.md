# Test 1 Shape library

This is a C# library for calculating the area of different shapes. It supports circle and triangle, but can be easily extended to other shapes.

# Test 2 MS SQL

```
CREATE TABLE products (
  product_id INT,
  name VARCHAR(50) NOT NULL,
  price DECIMAL(10,2) NOT NULL
  PRIMARY KEY(product_id)
);

CREATE TABLE categories (
  category_id INT,
  name VARCHAR(50) NOT NULL,
  PRIMARY KEY(category_id),
);

CREATE TABLE product_categories (
  product_id INT FOREIGN KEY REFERENCES products(product_id),
  category_id INT FOREIGN KEY REFERENCES categories(category_id),
  PRIMARY KEY (product_id, category_id)
);


INSERT INTO products (product_id, name, price) VALUES
(1, 'Banana', 0.89),
(2, 'Apple', 5.79),
(3, 'Orange', 6.29),
(4, 'Milk', 5.59),
(5, 'Bread', 2.69);

INSERT INTO categories (category_id, name) VALUES
(1, 'Fruits'),
(2, 'Dairy'),
(3, 'Bakery'),
(4, 'Citrus');


INSERT INTO product_categories (product_id, category_id) VALUES
(1, 1),
(2, 1),
(3, 1),
(4, 2),
(5, 3);



SELECT [products].[name] AS product_name, [categories].[name] AS category_name
FROM [products]
LEFT JOIN [product_categories] ON [products].[product_id] = [product_categories].[product_id]
LEFT JOIN [categories] ON product_categories.[category_id] = [categories].[category_id];



DROP TABLE product_categories;
DROP TABLE categories;
DROP TABLE products;
```
