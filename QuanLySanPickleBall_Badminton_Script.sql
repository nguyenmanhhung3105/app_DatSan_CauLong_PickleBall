USE [master]
GO

CREATE DATABASE [QuanLySan]

EXEC [QuanLySanBongsoso].[dbo].[sp_fulltext_database] @action = 'enable'
ALTER DATABASE [QuanLySan] SET ANSI_PADDING OFF 
ALTER DATABASE [QuanLySan] SET AUTO_CLOSE OFF


ALTER DATABASE [QuanLySan] SET AUTO_SHRINK OFF 
ALTER DATABASE [QuanLySan] SET AUTO_UPDATE_STATISTICS ON 
ALTER DATABASE [QuanLySan] SET CURSOR_CLOSE_ON_COMMIT OFF
ALTER DATABASE [QuanLySan] SET CURSOR_DEFAULT  GLOBAL
ALTER DATABASE [QuanLySan] SET NUMERIC_ROUNDABORT OFF
ALTER DATABASE [QuanLySan] SET  ENABLE_BROKER 
ALTER DATABASE [QuanLySan] SET TRUSTWORTHY OFF 
ALTER DATABASE [QuanLySan] SET READ_COMMITTED_SNAPSHOT OFF 
ALTER DATABASE [QuanLySan] SET HONOR_BROKER_PRIORITY OFF 
ALTER DATABASE [QuanLySan] SET RECOVERY FULL 
ALTER DATABASE [QuanLySan] SET  MULTI_USER 
ALTER DATABASE [QuanLySan] SET PAGE_VERIFY CHECKSUM
ALTER DATABASE [QuanLySan] SET FILESTREAM( NON_TRANSACTED_ACCESS = FULL ) 
ALTER DATABASE [QuanLySan] SET TARGET_RECOVERY_TIME = 60 SECONDS 
ALTER DATABASE [QuanLySan] SET DELAYED_DURABILITY = DISABLED 
EXEC sys.sp_db_vardecimal_storage_format N'QuanLySanBongsoso', N'ON'
GO
ALTER DATABASE [QuanLySan] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuanLySan] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)

USE [QuanLySan]

--Khach hang
GO
CREATE TABLE [dbo].[KhachHang](
	[maKhachHang] [varchar](10) NOT NULL,
	[tenKhachHang] [nvarchar](50) NULL,
	[soDienThoai] [varchar](10) NULL,
	[email] [varchar](50) NULL,
	[matKhau] [varchar](50) NULL,
	[gioiTinh] [nvarchar](10) NULL,
	[ngaySinh] [smalldatetime] NULL,
	[diaChi] [nvarchar](50) NULL,
	[soLanDatSan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

INSERT [dbo].[KhachHang] ([maKhachHang], [tenKhachHang], [soDienThoai], [email], [matKhau], [gioiTinh], [ngaySinh], [diaChi], [soLanDatSan]) VALUES (N'KH00000000', N'Kh1', N'0706613468', N'dang0582366729@gmail.com', N'123456', N'Nam', CAST(N'2005-09-08T00:00:00' AS SmallDateTime), N'Số 19, phườngng Tân Phong, quậnn 7, TP.Hồ Chí Minh', 1)


Go
CREATE TABLE [dbo].[OTP](
	[email] [nvarchar](50) NOT NULL,
	[otpCode] [nvarchar](4) NOT NULL,
	[expireAt][DATETIME] NOT NULL
PRIMARY KEY CLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

INSERT [dbo].[OTP] ([email], [otpCode]) VALUES (N'dang0582366729@gmail.com', 5072)

CREATE TABLE [dbo].[San](
	[maSan] [nvarchar](10) NOT NULL,
	[tenSan] [nvarchar](50) NULL,
	[loaiSan] [nvarchar](50) NULL,
	[giaSanTheoPhut] [int] NULL
PRIMARY KEY CLUSTERED 
(
	[maSan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'PK01', N'Sân PK-01',N'Sân Pickleball', 150000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'PK02', N'Sân PK-02',N'Sân Pickleball', 150000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'PK03', N'Sân PK-03',N'Sân Pickleball', 150000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'PK04', N'Sân PK-04',N'Sân Pickleball', 150000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'PK05', N'Sân PK-05',N'Sân Pickleball', 150000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'PK06', N'Sân PK-06',N'Sân Pickleball', 150000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'PK07', N'Sân PK-07',N'Sân Pickleball', 150000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'PK08', N'Sân PK-08',N'Sân Pickleball', 150000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'PK09', N'Sân PK-09',N'Sân Pickleball', 150000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'PK10', N'Sân PK-10',N'Sân Pickleball', 150000)

INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA01', N'Sân BA-01',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA02', N'Sân BA-02',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA03', N'Sân BA-03',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA04', N'Sân BA-04',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA05', N'Sân BA-05',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA06', N'Sân BA-06',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA07', N'Sân BA-07',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA08', N'Sân BA-08',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA09', N'Sân BA-09',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA10', N'Sân BA-10',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA11', N'Sân BA-11',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA12', N'Sân BA-12',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA13', N'Sân BA-13',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA14', N'Sân BA-14',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA15', N'Sân BA-15',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA16', N'Sân BA-16',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA17', N'Sân BA-17',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA18', N'Sân BA-18',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA19', N'Sân BA-19',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA20', N'Sân BA-20',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA21', N'Sân BA-21',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA22', N'Sân BA-22',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA23', N'Sân BA-23',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA24', N'Sân BA-24',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA25', N'Sân BA-25',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA26', N'Sân BA-26',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA27', N'Sân BA-27',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA28', N'Sân BA-28',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA29', N'Sân BA-29',N'Sân Cầu lông', 100000)
INSERT [dbo].[San] ([maSan], [tenSan], [loaiSan], [giaSanTheoPhut]) VALUES (N'BA30', N'Sân BA-30',N'Sân Cầu lông', 100000)

CREATE TABLE Kho (
    maDungCu NVARCHAR(10) NOT NULL PRIMARY KEY, 
    tenDungCu NVARCHAR(50) NOT NULL, 
    loaiDungCu NVARCHAR(50) NOT NULL,
    soLuong INT NOT NULL DEFAULT 0 CHECK (soLuong >= 0), 
    donGia INT NOT NULL DEFAULT 0 CHECK (donGia >= 0), 
    moTa NVARCHAR(255) NULL
);

CREATE TABLE PhieuThueDC (
    maPhieu NVARCHAR(10) NOT NULL PRIMARY KEY, 
    ngayThue DATETIME NULL, 
    maKH VARCHAR(10) NULL, 
    tongTien INT NULL CHECK (tongTien >= 0), 
    trangThai NVARCHAR(50) NULL,
    
    CONSTRAINT FK_PhieuThueDC_KhachHang FOREIGN KEY (maKH) REFERENCES KhachHang(maKhachHang)
);

CREATE TABLE CT_PhieuThueDC (
    maPhieu NVARCHAR(10) NOT NULL,
    maDungCu NVARCHAR(10) NOT NULL,
    soLuong INT NOT NULL CHECK (soLuong > 0),
    donGia INT NOT NULL CHECK (donGia >= 0),
    thanhTien AS (soLuong * donGia) PERSISTED, 
    
    PRIMARY KEY (maPhieu, maDungCu),
    
    CONSTRAINT FK_CT_PhieuThueDC_PhieuThueDC FOREIGN KEY (maPhieu) 
        REFERENCES PhieuThueDC(maPhieu) 
        ON DELETE CASCADE,  

    CONSTRAINT FK_CT_PhieuThueDC_Kho FOREIGN KEY (maDungCu) 
        REFERENCES Kho(maDungCu)
)

INSERT INTO Kho (maDungCu, tenDungCu, loaiDungCu, soLuong, donGia, moTa)
VALUES
('DC01', N'Cầu Lông VNB M01 77', N'Cầu', 50, 10000, N'Cầu lông vũ tự nhiên.'),
('DC02', N'Cầu Lông Yonex MSV 10', N'Cầu', 50, 20000, N'Cầu lông nylon siêu cao cấp.'),
('DC03', N'Cầu Lông Vina Start Đỏ', N'Cầu', 50, 5000, N'Cầu lông chất lượng tốt, giá thành rẻ.'),
('DC04', N'Vợt Cầu lông Yonex Nanoflare 1000z', N'Vợt', 50, 1000000, N'Vợt nhẹ, trợ lực, dễ đánh cao.'),
('DC05', N'Vợt Cầu lông Lining Aeronaut 6000', N'Vợt', 50, 1000000, N'Vợt màu sắc đẹp, hiện đại.'),
('DC06', N'Cầu Lông VNB M01 77', N'Cầu', 50, 20000, N'Cầu lông vũ tự nhiên.'),
('DC07', N'Vợt pickleball Adidas Carbon', N'Vợt', 50, 700000, N'Vợt carbon siêu nhẹ, linh hoạt và tối ưu.'),
('DC08', N'Vợt pickleball Adidas ATTK 2', N'Vợt', 50, 20000, N'Vợt có bộ trợ lực đánh dài, dễ bắt tốc.'),
('DC09', N'Bóng X- ACE40', N'Cầu', 50, 20000, N'Bóng nhẹ, nảy tốt.');


CREATE TABLE PhieuDatSan(
	maPhieuDatSan nvarchar(10) NOT NULL,
	maKhachHang varchar(10) NOT NULL,
	maNhanVien varchar(10) NOT NULL,
	loaiSan nvarchar(50) NULL,
	ngayDatSan datetime default getDate(),
	thoiGianDat datetime not null,
	thoiGianKetThuc datetime not null,
	tongTien int NOT NULL check (tongTien >=0),
	trangThai nvarchar default N'Chưa thanh toán',
	CONSTRAINT PK_PDS PRIMARY KEY (maPhieuDatSan),
	CONSTRAINT FK_PDS_SAN FOREIGN KEY (maSan) REFERENCES San(maSan),
	CONSTRAINT FK_PDS_KH FOREIGN KEY (maKhachHang) REFERENCES KhachHang(maKhachHang),
	CONSTRAINT FK_PDS_NV FOREIGN KEY (maNhanVien) REFERENCES NhanVien(maNhanVien),
	CONSTRAINT CK_PDS_TG CHECK (thoiGianKetThuc > thoiGianBatDau)
)

CREATE TABLE chiTietPhieuDatSan(
	maPDS nvarchar(10) NOT NULL,
	maSan nvarchar(10) NOT NULL,
	giaSanTheoPhut int NULL,
)