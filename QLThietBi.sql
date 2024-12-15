-- Bước 1: Tạo cơ sở dữ liệu
CREATE DATABASE QLThietbi;
GO
USE QLThietbi;
GO

-- Bước 2: Tạo bảng Donvi
CREATE TABLE Donvi (
    Madv INT IDENTITY(1,1) PRIMARY KEY,
    Tendv NVARCHAR(35) NOT NULL
);
GO

-- Bước 3: Thêm dữ liệu mẫu vào bảng Donvi
INSERT INTO Donvi (Tendv) 
VALUES 
(N'Khoa CNTT'),
(N'Khoa Toán'),
(N'Khoa Lý');
GO

-- Bước 4: Tạo bảng Loaithietbi
CREATE TABLE Loaithietbi (
    Maloai INT IDENTITY(1,1) PRIMARY KEY,
    Tenloai NVARCHAR(35) NOT NULL,
    Ghichu NVARCHAR(50)
);
GO

-- Bước 5: Thêm dữ liệu mẫu vào bảng Loaithietbi
INSERT INTO Loaithietbi (Tenloai, Ghichu) 
VALUES 
(N'Máy in', N'Máy in văn phòng'),
(N'Máy tính', N'Máy tính để bàn'),
(N'Điện thoại', N'Điện thoại di động');
GO

-- Bước 6: Tạo bảng Thietbi
CREATE TABLE Thietbi (
    Madv INT,
    Maloai INT,
    Matb INT IDENTITY(1,1) PRIMARY KEY,
    Tentb NVARCHAR(35) NOT NULL,
    Nuocsx NVARCHAR(30),
    Namsx INT,
    Ngaysd NVARCHAR(10),
    Ghichu NVARCHAR(50),
    FOREIGN KEY (Madv) REFERENCES Donvi(Madv),
    FOREIGN KEY (Maloai) REFERENCES Loaithietbi(Maloai)
);
GO

-- Bước 7: Thêm dữ liệu mẫu vào bảng Thietbi
INSERT INTO Thietbi (Madv, Maloai, Tentb, Nuocsx, Namsx, Ngaysd, Ghichu) 
VALUES 
(1, 1, N'Máy in Canon', N'Nhật Bản', 2020, N'01/01/2021', N'Máy in màu'),
(2, 2, N'Máy tính Dell', N'Mỹ', 2021, N'15/03/2021', N'Máy tính cấu hình cao'),
(3, 3, N'Điện thoại Samsung', N'Hàn Quốc', 2022, N'10/05/2022', N'Điện thoại thông minh');
GO
