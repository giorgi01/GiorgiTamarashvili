USE Shop

-- #1
SELECT e.EmployeeID, COUNT(*) AS OrdersAmount
FROM (Employees e INNER JOIN Orders o ON e.EmployeeID = o.EmployeeID) 
GROUP BY e.EmployeeID;

-- #2
SELECT SUM(od.Quantity * p.Price) AS PriceToPay
FROM (OrderDetails od 
INNER JOIN Orders o ON od.OrderID = o.OrderID 
INNER JOIN Products p ON od.ProductID = p.ProductID
) GROUP BY od.OrderID;

-- #3
SELECT COUNT(DISTINCT(p.ProductID)) AS DiffItems, SUM(od.Quantity) AS Amount
FROM (OrderDetails od 
INNER JOIN Orders o ON od.OrderID = o.OrderID 
INNER JOIN Products p ON od.ProductID = p.ProductID
) GROUP BY od.OrderID;

-- #4
SELECT CustomerName, City, [Address], Country, PaidCash FROM (
(SELECT TOP 1 c.CustomerID, SUM(od.Quantity * p.Price) AS PaidCash
FROM (Orders o
INNER JOIN Customers c ON o.CustomerID = c.CustomerID
INNER JOIN OrderDetails od ON o.OrderID = od.OrderID
INNER JOIN Products p ON od.ProductID = p.ProductID) 
GROUP BY c.CustomerID
ORDER BY PaidCash DESC) T1
INNER JOIN Customers c1 ON T1.CustomerID = c1.CustomerID);

-- #5
INSERT INTO Customers (CustomerName, ContactName, Country, City, PostalCode, [Address])
VALUES ('Giorgi Tamarashvili', 'Giorgi Tamarashvili', 'Georgia', 'Kaspi', 2600, 'Aghmashenebeli str' );

INSERT INTO Orders (OrderID, CustomerID, EmployeeID, ShipperID, OrderDate)
VALUES (10500, 92, 1, 1, GETDATE());
SELECT TOP 1 * FROM Orders ORDER BY OrderID DESC;

INSERT INTO OrderDetails (OrderID, ProductID, Quantity) VALUES (10500, 11, 20);
SELECT TOP 1 * FROM OrderDetails ORDER BY OrderDetailID DESC;
