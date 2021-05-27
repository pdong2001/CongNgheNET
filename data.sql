USE master
GO

CREATE DATABASE CongNgheNet
GO

USE CongNgheNet
GO

CREATE TABLE tbSanPham
(
	MaSP NCHAR(10),
	TenSP NVARCHAR(50) NOT NULL,
	SoLuong INT NOT NULL,
	GiaBan INT NULL,
	XuatSu NVARCHAR(50) NULL,
	CONSTRAINT PK_tbSanPham PRIMARY KEY (MaSP)
)
GO

DECLARE @I INT
SELECT @I = COUNT(*) FROM dbo.tbSanPham
WHILE @I < 200
BEGIN
	INSERT INTO dbo.tbSanPham
	        ( MaSP, TenSP, SoLuong, GiaBan, XuatSu )
	VALUES  ( N'SP'+CAST(@I AS VARCHAR(5)), -- MaSP - nchar(10)
	          N'Sản phẩm '+CAST(@I AS VARCHAR(5)), -- TenSP - nvarchar(50)
	          ABS(CHECKSUM(NEWID())) % 100, -- SoLuong - int
	          ABS(CHECKSUM(NEWID())) / 10000000 * 1000, -- GiaBan - int
	          N''  -- XuatSu - nvarchar(50)
	          )
	SET @I = @I + 1
END
GO