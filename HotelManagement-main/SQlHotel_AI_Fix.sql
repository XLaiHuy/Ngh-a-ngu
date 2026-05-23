
DROP TABLE IF EXISTS Payment;
DROP TABLE IF EXISTS InvoiceDetail;
DROP TABLE IF EXISTS Invoice;
DROP TABLE IF EXISTS BookingService;
DROP TABLE IF EXISTS BookingDetail;
DROP TABLE IF EXISTS Booking;
DROP TABLE IF EXISTS RoomService;
DROP TABLE IF EXISTS Room;
DROP TABLE IF EXISTS RoomType;
DROP TABLE IF EXISTS Service;
DROP TABLE IF EXISTS ServiceType;
DROP TABLE IF EXISTS Floor;
DROP TABLE IF EXISTS Customer;
DROP TABLE IF EXISTS FUNC;
GO

CREATE TABLE Customer (
    CustomerID  INT           IDENTITY(1,1) PRIMARY KEY,
    FullName    NVARCHAR(100) NOT NULL,
    CCCD        VARCHAR(20)   UNIQUE,
    Phone       VARCHAR(15),
    Email       VARCHAR(100),
    Gender      NVARCHAR(5),
    IsBlocked   BIT           DEFAULT 0,
    BlockReason NVARCHAR(200)
);
 
CREATE TABLE Floor (
    FloorID   INT          IDENTITY(1,1) PRIMARY KEY,
    FloorName NVARCHAR(50)
);
 
CREATE TABLE ServiceType (
    ServiceTypeID INT          IDENTITY(1,1) PRIMARY KEY,
    Type          NVARCHAR(50),
    MaServiceType NVARCHAR(50) UNIQUE
);
 
CREATE TABLE Service (
    ServiceID   INT           IDENTITY(1,1) PRIMARY KEY,
    TypeID      INT,
    Quantity    INT,
    NameService NVARCHAR(100),
    Price       DECIMAL(18,2),
    FOREIGN KEY (TypeID) REFERENCES ServiceType(ServiceTypeID)
);
 
CREATE TABLE RoomType (
    RoomTypeID       INT           IDENTITY(1,1) PRIMARY KEY,
    TypeName         NVARCHAR(50)  NOT NULL,
    Price            DECIMAL(18,2),
    BedNumbers       INT,
    HumanCapacity    INT,
    StandardCapacity INT,
    AdultCapacity    INT,
    ChildCapacity    INT
);
 
CREATE TABLE Room (
    RoomID           INT          IDENTITY(1,1) PRIMARY KEY,
    RoomCode         NVARCHAR(50) UNIQUE NOT NULL,
    RoomTypeID       INT,
    FloorID          INT,
    Status           NVARCHAR(50) DEFAULT N'Trống',
    AllowExtraPeople BIT          DEFAULT 0,
    FOREIGN KEY (RoomTypeID) REFERENCES RoomType(RoomTypeID),
    FOREIGN KEY (FloorID)    REFERENCES Floor(FloorID)
);
 
-- ✅ Booking: giữ RoomID để tương thích code hiện tại
--    (RoomID = phòng chính / phòng đầu tiên trong booking)
CREATE TABLE Booking (
    BookingID           INT           IDENTITY(1,1) PRIMARY KEY,
    CustomerID          INT,
    Channel             NVARCHAR(50),
    CheckInDate         DATETIME,
    PlannedCheckOutDate DATETIME,
    CheckOutDate        DATETIME,
    TotalPrice          DECIMAL(18,2) DEFAULT 0,
    Note                NVARCHAR(500),
    TheoDoan            BIT           DEFAULT 0,
    CheckOut            BIT           DEFAULT 0,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);
 
-- ✅ BookingDetail: mỗi dòng = 1 phòng trong booking
--    Hỗ trợ 1 booking đặt nhiều phòng
CREATE TABLE BookingDetail (
    BookingDetailID     INT           IDENTITY(1,1) PRIMARY KEY,
    BookingID           INT           NOT NULL,
    RoomID              INT           NOT NULL,
    CheckInDate         DATETIME      NOT NULL,
    SONGAYO             INT           NULL,
    THANHTIEN           DECIMAL(18,2) NULL,
    CheckOutDate        DATETIME      NULL,       -- NULL = chưa checkout
    RoomPrice           DECIMAL(18,2) NOT NULL,   -- Giá tại thời điểm đặt
    Note                NVARCHAR(200) NULL,
    NGAY                DATETIME      NULL,
    FOREIGN KEY (BookingID) REFERENCES Booking(BookingID),
    FOREIGN KEY (RoomID)    REFERENCES Room(RoomID)
);
 
-- ✅ BookingService: dịch vụ khách dùng trong thời gian ở
CREATE TABLE BookingService (
    BookingServiceID INT           IDENTITY(1,1) PRIMARY KEY,
    BookingDetailID  INT           NOT NULL,
    BookingID        INT           NOT NULL,
    RoomID           INT           NOT NULL,
    ServiceID        INT           NULL,
    DONGIA           DECIMAL(18,2) NOT NULL,
    THANHTIEN        DECIMAL(18,2) NOT NULL,
    Quantity         INT           DEFAULT 1,
    UsedDate         DATETIME      DEFAULT GETDATE(),
    Note             NVARCHAR(200),
    FOREIGN KEY (BookingID)  REFERENCES Booking(BookingID),
    FOREIGN KEY (ServiceID)  REFERENCES Service(ServiceID),
    FOREIGN KEY (BookingDetailID)  REFERENCES BookingDetail(BookingDetailID),
    FOREIGN KEY (RoomID)  REFERENCES Room(RoomID),

);
 
CREATE TABLE Invoice (
    InvoiceID   INT           IDENTITY(1,1) PRIMARY KEY,
    BookingID   INT           UNIQUE,
    IssueDate   DATETIME      DEFAULT GETDATE(),
    TotalAmount DECIMAL(18,2),
    FinalAmount DECIMAL(18,2),
    FOREIGN KEY (BookingID) REFERENCES Booking(BookingID)
);
 
CREATE TABLE InvoiceDetail (
    InvoiceDetailID INT           IDENTITY(1,1) PRIMARY KEY,
    InvoiceID       INT           NOT NULL,
    ServiceID       INT           NOT NULL,
    Quantity        INT           DEFAULT 1,
    UnitPrice       DECIMAL(18,2),
    SubTotal        AS (Quantity * UnitPrice) PERSISTED,
    FOREIGN KEY (InvoiceID)  REFERENCES Invoice(InvoiceID),
    FOREIGN KEY (ServiceID)  REFERENCES Service(ServiceID)
);
 
CREATE TABLE Payment (
    PaymentID   INT           IDENTITY(1,1) PRIMARY KEY,
    InvoiceID   INT,
    PaymentDate DATETIME      DEFAULT GETDATE(),
    Amount      DECIMAL(18,2),
    Method      NVARCHAR(50),
    Note        NVARCHAR(200),
    FOREIGN KEY (InvoiceID) REFERENCES Invoice(InvoiceID)
);
 
CREATE TABLE FUNC (
    FUNC_CODE   NVARCHAR(50)  NOT NULL PRIMARY KEY,
    SORT        INT           NOT NULL,
    DESCRIPTION NVARCHAR(200) NULL,
    ISGROUP     BIT           NULL,
    PARENT      NVARCHAR(50)  NULL,
    MENU        BIT           NULL,
    TIPS        NVARCHAR(500) NULL
);
GO
 
-- ── BƯỚC 3: Insert data mẫu ───────────────────────────────────
 
INSERT INTO Customer (FullName, CCCD, Phone, Email, Gender, IsBlocked, BlockReason)
VALUES
(N'Nguyễn Văn B', '012345678', '0987654321', 'abc@gmail.com',    N'Nam', 0, NULL),
(N'Trần Thị C',   '112345678', '0909123456', 'tran@gmail.com',   N'Nữ', 0, NULL),
(N'Lê Văn D',     '321456789', '0978123456', 'le@gmail.com',     N'Nam', 0, NULL);
 
INSERT INTO Floor (FloorName)
VALUES (N'Tầng 1'), (N'Tầng 2'), (N'Tầng 3');
 
INSERT INTO RoomType (TypeName, Price, BedNumbers, HumanCapacity, StandardCapacity, AdultCapacity, ChildCapacity)
VALUES
(N'VIP 01',  1000000, 1, 2, 2, 2, 1),
(N'VIP 02',  1500000, 2, 4, 4, 4, 2),
(N'Loại 1',   500000, 1, 2, 2, 2, 1);
 
INSERT INTO Room (RoomCode, RoomTypeID, FloorID, Status, AllowExtraPeople)
VALUES
(N'Phòng 101', 1, 1, N'Trống',    0),
(N'Phòng 102', 2, 1, N'Trống',    0),
(N'Phòng 103', 3, 1, N'Trống',    0),
(N'Phòng 201', 1, 2, N'Trống',    0),
(N'Phòng 202', 2, 2, N'Cho thuê', 0),
(N'Phòng 203', 3, 2, N'Trống',    0),
(N'Phòng 301', 1, 3, N'Dọn',      0),
(N'Phòng 302', 2, 3, N'Trống',    0),
(N'Phòng 303', 3, 3, N'Trống',    0);
 
INSERT INTO ServiceType (Type, MaServiceType)
VALUES
(N'Thức ăn', N'TA01'),
(N'Đồ uống', N'DU01'),
(N'Dịch vụ spa',     N'SP01'),
(N'Dịch vụ giặt ủi', N'GU01');
 
INSERT INTO Service (TypeID, Quantity, NameService, Price)
VALUES
(1, 100, N'Cơm chiên',    20000),
(1, 100, N'Mì xào',     15000),
(3, 50,  N'Sting', 100000),
(4, 100, N'Giặt ủi',     30000);
 
INSERT INTO FUNC (FUNC_CODE, SORT, DESCRIPTION, ISGROUP, PARENT, MENU, TIPS)
VALUES
('DANHMUC',    1, N'DANH MỤC',             1, NULL,      1, N'Danh mục dùng chung'),
('TANG',       2, N'Quản lý Tầng',         0, 'DANHMUC', 1, NULL),
('LOAIPHONG',  3, N'Quản lý Loại Phòng',   0, 'DANHMUC', 1, NULL),
('PHONG',      4, N'Quản lý Phòng',        0, 'DANHMUC', 1, NULL),
('DATPHONG',   5, N'Quản lý Đặt Phòng',    0, 'DANHMUC', 1, NULL),
('LOAIDICHVU', 6, N'Quản lý Loại Dịch Vụ', 0, 'DANHMUC', 1, NULL),
('DICHVU',     7, N'Quản lý Dịch Vụ',      0, 'DANHMUC', 1, NULL),
('KHACHHANG',  8, N'Quản lý Khách Hàng',   0, 'DANHMUC', 1, NULL),
('HETHONG',    9, N'HỆ THỐNG',             1, NULL,      1, N'Tính năng hệ thống'),
('THANHTOAN', 10, N'Quản lý Thanh Toán',   0, 'HETHONG', 1, NULL),
('HOADON',    11, N'Quản lý Hóa đơn',      0, 'HETHONG', 1, NULL),
('DOANHTHU',  12, N'Báo cáo Doanh thu',    0, 'HETHONG', 1, NULL);
GO
 
-- ── BƯỚC 4: Kiểm tra kết quả ─────────────────────────────────
SELECT 'Customer'     AS Bang, COUNT(*) AS SoDong FROM Customer     UNION ALL
SELECT 'Floor',                COUNT(*)            FROM Floor        UNION ALL
SELECT 'RoomType',             COUNT(*)            FROM RoomType     UNION ALL
SELECT 'Room',                 COUNT(*)            FROM Room         UNION ALL
SELECT 'ServiceType',          COUNT(*)            FROM ServiceType  UNION ALL
SELECT 'Service',              COUNT(*)            FROM Service      UNION ALL
SELECT 'FUNC',                 COUNT(*)            FROM FUNC;
GO
