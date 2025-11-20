-- 1. Создание базы данных
-----------------------------------------------------
CREATE DATABASE RealEstateAgency;
GO

USE RealEstateAgency;
GO

-----------------------------------------------------
-- 2. Создание таблицы Клиентов
-----------------------------------------------------
CREATE TABLE Clients (
    ClientID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(30),
    Email NVARCHAR(100)
);
GO

-----------------------------------------------------
-- 3. Создание таблицы Сотрудников
-----------------------------------------------------
CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Role NVARCHAR(50) NOT NULL,      -- Administrator / Realtor / Lawyer
    Status NVARCHAR(20) NOT NULL,    -- Active / Fired
    Phone NVARCHAR(30),
    Login NVARCHAR(50) UNIQUE NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    Shift NVARCHAR(20)
);
GO

-----------------------------------------------------
-- 4. Создание таблицы Недвижимости
-----------------------------------------------------
CREATE TABLE Property (
    PropertyID INT IDENTITY(1,1) PRIMARY KEY,
    Address NVARCHAR(150) NOT NULL,
    Type NVARCHAR(50),
    Price DECIMAL(18,2)
);
GO

-----------------------------------------------------
-- 5. Создание таблицы Заказов
-----------------------------------------------------
CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    ClientID INT NOT NULL,
    EmployeeID INT NOT NULL,
    PropertyID INT NOT NULL,
    Status NVARCHAR(50),
    CreatedDate DATE DEFAULT GETDATE(),

    FOREIGN KEY (ClientID) REFERENCES Clients(ClientID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
    FOREIGN KEY (PropertyID) REFERENCES Property(PropertyID)
);
GO

-----------------------------------------------------
-- 6. Создание таблицы Документов
-----------------------------------------------------
CREATE TABLE Documents (
    DocumentID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL,
    DocName NVARCHAR(100),
    CreatedBy INT NOT NULL,
    FilePath NVARCHAR(200),
    Status NVARCHAR(50),

    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (CreatedBy) REFERENCES Employees(EmployeeID)
);
GO

-----------------------------------------------------
-- 7. Добавляем тестовых сотрудников (для входа)
-----------------------------------------------------
INSERT INTO Employees (FullName, Role, Status, Phone, Login, Password, Shift)
VALUES
('Иванов Иван', 'Administrator', 'Active', '9001112233', 'admin', 'admin', 'Day'),
('Петров Петр', 'Realtor', 'Active', '9002223344', 'realtor', '12345', 'Evening'),
('Сидоров Сидор', 'Lawyer', 'Active', '9003334455', 'lawyer', '7777', 'Day');
GO

-----------------------------------------------------
-- БАЗА ПОЛНОСТЬЮ ГОТОВА
-----------------------------------------------------
