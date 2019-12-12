/*N'TEST DATABASE QUẢN LÝ SÂN BANH'*/
/*N'FILE NÀY ĐỂ TẠO CÁC TRƯỜNG MẶC ĐỊNH CHO CSDL'*/

USE [master]
USE [QLSB]
GO
SET DATEFORMAT DMY
/*N'Tạo giá trị mặc định'*/
/*N'Test bảng TAIKHOAN'*/
INSERT INTO [tblTAIKHOAN] ([maTaiKhoan],[userName],[passWord],[role]) VALUES (1,N'lydaonam',N'namlydao123', 'NhanVienQLSB')
INSERT INTO [tblTAIKHOAN] ([maTaiKhoan],[userName],[passWord],[role]) VALUES (2,N'taitrien',N'taitrien99', 'NhanVienQLCSVC')
INSERT INTO [tblTAIKHOAN] ([maTaiKhoan],[userName],[passWord],[role]) VALUES (3,N'duytan',N'duytan99', 'NhanVienQLTC')
/*N'Test bảng NHANVIEN'*/
INSERT INTO [tblNHANVIEN] ([maNhanVien],[maTaiKhoan],[hoTen],[tuoi],[diaChi],[gioiTinh],[soDT]) VALUES (1,1,N'Lý Đạo Nam',20,N'01 Trần Duy Hưng, Hà Nội =)))','Nam','0969696969')
INSERT INTO [tblNHANVIEN] ([maNhanVien],[maTaiKhoan],[hoTen],[tuoi],[diaChi],[gioiTinh],[soDT]) VALUES (2,2,N'Võ Văn Tài Triển',20,N'?????','Nam','0977777777')
/*N'Test bảng KHACHHANG'*/
INSERT INTO [tblKHACHHANG] ([maKH],[tenKH],[loaiKH],[diaChi],[gioiTinh],[soDT]) VALUES (1,N'Ngô Bá Khá',N'Vãng lai',N'Vũ Trường','Nam','0966666666')
/*N'Test bảng PHIEUDATSAN'*/
INSERT INTO [tblPHIEUDATSAN] ([maPhieuDatSan], [maNhanVien],[maKH]) VALUES (1,2,1)
/*N'Test bảng SAN'*/
INSERT INTO [tblSAN] ([maSan], [tinhTrang]) VALUES (1,0)
/*N'Test bảng CHITIETDATSAN'*/
INSERT INTO [tblCHITIETDATSAN] ([maPhieuDatSan],[maSan],[ngayDat],[gioDat],[thoiLuong]) VALUES (1,1,'18/11/2019','20:00','00:30')
/*N'Test bảng THAMSO'*/
INSERT INTO [tblTHAMSO] ([luongnhanvien],[tiengiuxe],[giasanngay],[giasandem],[sotiencoc]) VALUES (10000,5000,30000,50000,10000)
/*N'Test bảng HOADON'*/
INSERT INTO [tblHOADON] ([maHoaDon],[maNhanVien],[maKH],[ngaytaohoadon]) VALUES (1,1,1,'18/11/2019')
/*N'Test bảng LOAIHOADON'*/
INSERT INTO [tblLOAIHOADON] ([maLoaiHoaDon],[loaihoadon]) VALUES (1,'thu san')
/*N'Test bảng CHITIETHOADON'*/
INSERT INTO [tblCHITIETHOADON] ([maLoaiHoaDon],[maHoaDon],[trigiahoadon]) VALUES (1,1,100000)
/*N'Test bảng CSVC'*/
INSERT INTO [tblCSVC] ([maCSVC],[maNhanVien],[tencsvc],[soluongnhap],[dongianhap],[tinhtrangcsvc]) VALUES (1,2,'banh',5,50000,'hu hong')
INSERT INTO [tblCSVC] ([maCSVC],[maNhanVien],[tencsvc],[soluongnhap],[dongianhap],[tinhtrangcsvc]) VALUES (2,2,'luoi',4,150000,'hu hong')
INSERT INTO [tblCSVC] ([maCSVC],[maNhanVien],[tencsvc],[soluongnhap],[dongianhap],[tinhtrangcsvc]) VALUES (3,2,'san co',2,500000,'tot')
/*N'Test bảng DOUONG'*/
INSERT INTO [tblDOUONG] ([maDoUong],[tendouong],[soluongconlai],[dongianhap],[dongiaban],[ngaytaohoadon]) VALUES (1,'nuoc suoi',5,5000,10000,'18/11/2019')