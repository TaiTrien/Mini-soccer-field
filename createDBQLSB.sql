/*N'TẠO DATABASE QUẢN LÝ SÂN BANH'*/

USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLSB')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLSB') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLSB]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLSB]
GO
USE [QLSB]
GO
SET DATEFORMAT DMY
/*N'TẠO BẢNG TÀI KHOẢN	'*/
CREATE TABLE [dbo].[tblTAIKHOAN](
[maTaiKhoan] [nvarchar](5) NOT NULL,
[userName] [nvarchar](30) NOT NULL,
[passWord] [nvarchar](30) NOT NULL,
[Role] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_tblTAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[maTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
/*N'TẠO BẢNG NHÂN VIÊN'*/
CREATE TABLE [dbo].[tblNHANVIEN](
[maNhanVien] [nvarchar](5) NOT NULL,
[maTaiKhoan] [nvarchar](5) NOT NULL,
[hoTen] [nvarchar](20) NOT NULL,
[tuoi] [int] NOT NULL,
[gioiTinh] [nvarchar](20) NOT NULL,
[diaChi] [nvarchar](40) NOT NULL,
[soDT] [nvarchar](10) NOT NULL,
CONSTRAINT [PK_tblNHANVIEN] PRIMARY KEY CLUSTERED 
(
	[maNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
CONSTRAINT fk_TAIKHOAN_NHANVIEN
   FOREIGN KEY (maTaiKhoan)
   REFERENCES tblTAIKHOAN (maTaiKhoan)
) ON [PRIMARY]

/*N'TẠO BẢNG KHÁCH HÀNG'*/
CREATE TABLE [dbo].[tblKHACHHANG](
	[maKH] [nvarchar](5) NOT NULL,
	[tenKH] [nvarchar] (20) NOT NULL,
	[gioiTinh] [nvarchar](5) NOT NULL,
	[diaChi] [nvarchar](30) NOT NULL,
	[loaiKH] [nvarchar](10) NOT NULL,
	[soDT] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblKHACHHANG] PRIMARY KEY CLUSTERED 
(
	[maKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
/*N'TẠO BẢNG PHIẾU ĐẶT SÂN'*/
CREATE TABLE [dbo].[tblPHIEUDATSAN](
[maPhieuDatSan] [nvarchar] (5) NOT NULL,
[maNhanVien] [nvarchar] (5) NOT NULL,
[maKH] [nvarchar] (5) NOT NULL,
CONSTRAINT [PK_tblPHIEUDATSAN] PRIMARY KEY CLUSTERED 
(
	[maPhieuDatSan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
CONSTRAINT fk_NHANVIEN_PHIEUDATSAN
   FOREIGN KEY (maNhanVien)
   REFERENCES tblNHANVIEN (maNhanVien),
CONSTRAINT fk_KHACHHANG_PHIEUDATSAN
   FOREIGN KEY (maKH)
   REFERENCES tblKHACHHANG (maKH)
) ON [PRIMARY]

/*N'TẠO BẢNG SÂN'*/
CREATE TABLE [dbo].[tblSAN](
	[maSan] [nvarchar](5) NOT NULL,
	[tinhTrang] [bit],

 CONSTRAINT [PK_tblSAN] PRIMARY KEY CLUSTERED 
(
	[maSan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
/*N'TẠO BẢNG CHI TIẾT ĐẶT SÂN'*/
CREATE TABLE [dbo].[tblCHITIETDATSAN](
	[maPhieuDatSan] [nvarchar](5) NOT NULL,
	[maSan] [nvarchar](5) NOT NULL,
	[ngayDat] [date] NOT NULL,
	[gioDat] [time] NOT NULL,
	[thoiLuong] [time] NOT NULL,
CONSTRAINT fk_PHIEUDATSAN_CHITIETDATSAN
   FOREIGN KEY (maPhieuDatSan)
   REFERENCES tblPHIEUDATSAN (maPhieuDatSan),
CONSTRAINT fk_SAN_CHITIETDATSAN
   FOREIGN KEY (maSan)
   REFERENCES tblSAN (maSan)
) ON [PRIMARY]
/*N'TẠO BẢNG THAM SỐ'*/
CREATE TABLE [dbo].[tblTHAMSO](
	[luongnhanvien] [float] NOT NULL,
	[tiengiuxe] [float] ,
	[giasanngay] [float] NOT NULL,
	[giasandem] [float] NOT NULL,
	[sotiencoc] [float] )
/*N'TẠO BẢNG CSVC'*/
CREATE TABLE [dbo].[tblCSVC](
	[maCSVC] [nvarchar](5) NOT NULL,
	[maNhanVien] [nvarchar](5) NOT NULL,
	[tencsvc] [nvarchar](20) NOT NULL,
	[csvctot] [int] ,
	[csvchong] [int],
	[dongianhap] [int] NOT NULL,
	CONSTRAINT [PK_tblCSVC] PRIMARY KEY CLUSTERED 
(
	[maCSVC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
CONSTRAINT fk_NHANVIEN_CSVC
   FOREIGN KEY (maNhanVien)
   REFERENCES tblNHANVIEN (maNhanVien)
) ON [PRIMARY]
/*N'TẠO BẢNG ĐỒ UỐNG'*/
CREATE TABLE [dbo].[tblDOUONG](
	[maDoUong] [nvarchar](5) NOT NULL,
	[tendouong] [nvarchar](10) NOT NULL,
	[soluongconlai] [int] NOT NULL,
	[dongianhap] [int] NOT NULL,
	[dongiaban] [int] NOT NULL,
	[ngaytaohoadon] [smalldatetime] NOT NULL,
CONSTRAINT [PK_tblDOUONG] PRIMARY KEY CLUSTERED 
(
	[maDouong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
) ON [PRIMARY]
/*N'TẠO BẢNG HÓA ĐƠN'*/
CREATE TABLE [dbo].[tblHOADON](
	[maHoaDon] [nvarchar](5) NOT NULL,
	[maNhanvien] [nvarchar](5) NOT NULL,
	[maKH] [nvarchar](5) NOT NULL,
	[ngaytaohoadon] [date] NOT NULL,
CONSTRAINT [PK_tblHOADON] PRIMARY KEY CLUSTERED 
(
	[maHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
CONSTRAINT fk_NHANVIEN_HOADON
   FOREIGN KEY (maNhanVien)
   REFERENCES tblNHANVIEN (maNhanVien),
CONSTRAINT fk_KHACHHANG_HOADON
   FOREIGN KEY (maKH)
   REFERENCES tblKHACHHANG (maKH)
) ON [PRIMARY]	
/*N'TẠO BẢNG LOẠI HÓA ĐƠN'*/
CREATE TABLE [dbo].[tblLOAIHOADON](
	[maLoaiHoaDon] [nvarchar](5) NOT NULL,
	[loaihoadon] [nvarchar](10) NOT NULL,
CONSTRAINT [PK_tblLOAIHOADON] PRIMARY KEY CLUSTERED 
(
	[maLoaiHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
) ON [PRIMARY]
/*N'TẠO BẢNG CHI TIẾT HÓA ĐƠN'*/
CREATE TABLE [dbo].[tblCHITIETHOADON](
	[maLoaiHoaDon] [nvarchar](5) NOT NULL,
	[maHoaDon] [nvarchar](5) NOT NULL,
	[trigiahoadon] [float] NOT NULL,
CONSTRAINT fk_HOADON_CHITIETHOADON
   FOREIGN KEY (maHoaDon)
   REFERENCES tblHOADON (maHoaDon),
CONSTRAINT fk_LOAIHOADON_CHITIETHOADON
   FOREIGN KEY (maLoaiHoaDon)
   REFERENCES tblLOAIHOADON (maLoaiHoaDon),
) ON [PRIMARY]

