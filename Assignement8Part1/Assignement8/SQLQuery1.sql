Create Database Day8
use Day8
Create Table Products
(
    Pid CHAR(6) PRIMARY KEY,
    PName NVARCHAR(MAX) NOT NULL,
    PPrice float NOT NULL,
    MnfDate DATE NOT NULL,
    ExpDate DATE NOT NULL
);
INSERT INTO Products (Pid, PName, PPrice, MnfDate, ExpDate)
VALUES
    ('P00001', 'Product1', 19.99, '2023-01-01', '2023-12-31'),
    ('P00002', 'Product2', 29.99, '2023-02-01', '2023-12-31'),
    ('P00003', 'Product3', 39.99, '2023-03-01', '2023-12-31'),
    ('P00004', 'Product4', 49.99, '2023-04-01', '2023-12-31'),
    ('P00005', 'Product5', 59.99, '2023-05-01', '2023-12-31'),
    ('P00006', 'Product6', 69.99, '2023-06-01', '2023-12-31'),
    ('P00007', 'Product7', 79.99, '2023-07-01', '2023-12-31'),
    ('P00008', 'Product8', 89.99, '2023-08-01', '2023-12-31'),
    ('P00009', 'Product9', 99.99, '2023-09-01', '2023-12-31'),
    ('P00010', 'Product10', 109.99, '2023-10-01', '2023-12-31');
	select * from Products

select * from Products Order by PName Asc