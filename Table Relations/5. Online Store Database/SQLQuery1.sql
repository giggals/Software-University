
CREATE TABLE Cities (
  CityID INT NOT NULL,
  [Name] NVARCHAR(50) NOT NULL

  CONSTRAINT PK_Cities
  PRIMARY KEY(CityID)
)

CREATE TABLE Customers (
  CustomerID INT NOT NULL,
  [Name] NVARCHAR(50) NOT NULL,
  Birthday DATE ,
  CityID INT  NULL,

  CONSTRAINT PK_Customers
  PRIMARY KEY(CustomerID),

  CONSTRAINT FK_Customers_Cities
  FOREIGN KEY(CityID) REFERENCES Cities(CityID)

)

CREATE TABLE ItemTypes(
  ItemTypeID INT NOT NULL,
  [Name] NVARCHAR NOT NULL,

  CONSTRAINT PK_ItemTypes
  PRIMARY KEY(ItemTypeID)
)

CREATE TABLE Items(
  ItemID INT NOT NULL,
  [Name] NVARCHAR(50) NOT NULL,
  ItemTypeID INT NOT NULL,

  CONSTRAINT PK_Items
  PRIMARY KEY(ItemID),

  CONSTRAINT FK_Items_ItemsType
  FOREIGN KEY(ItemTypeID) REFERENCES ItemTypes(ItemTypeID)

)

CREATE TABLE Orders (
   OrderID INT IDENTITY NOT NULL,
   CustomerID INT NOT NULL,

   CONSTRAINT PK_Orders
   PRIMARY KEY(OrderID),

   CONSTRAINT FK_Orders_Customers
  FOREIGN KEY(CustomerID) REFERENCES Customers(CustomerID)
)




CREATE TABLE OrderItems(
   OrderID INT NOT NULL,
   ItemID INT NOT NULL

   CONSTRAINT PK_OrderItems
   PRIMARY KEY(OrderID , ItemID),

   CONSTRAINT FK_OrdersItems_Orders
   FOREIGN KEY(OrderID) REFERENCES Orders(OrderID),

   CONSTRAINT FK_OrdersItems_Items
   FOREIGN KEY(ItemID) REFERENCES Items(ItemID)
)

