/*N'TEST DATABASE QUẢN LÝ SÂN BANH'*/
/*N'FILE NÀY ĐỂ TẠO CÁC TRƯỜNG MẶC ĐỊNH CHO CSDL'*/

USE [master]
USE [QLSB]
GO
SET DATEFORMAT DMY
/*N'Tạo giá trị mặc định'*/
/*N'Test bảng TAIKHOAN'*/
INSERT INTO [tblTAIKHOAN] ([maTaiKhoan],[userName],[passWord],[Role]) VALUES (1,N'QLSB',N'1','master')
INSERT INTO [tblTAIKHOAN] ([maTaiKhoan],[userName],[passWord],[Role]) VALUES (2,N'QLSB',N'1','master')

INSERT INTO [tblTAIKHOAN] ([maTaiKhoan],[userName],[passWord],[Role]) VALUES (4,N'QLSB',N'1','NhanVienQLSB')
INSERT INTO [tblTAIKHOAN] ([maTaiKhoan],[userName],[passWord],[Role]) VALUES (5,N'QLTC',N'1','NhanVienQLTC')
INSERT INTO [tblTAIKHOAN] ([maTaiKhoan],[userName],[passWord],[Role]) VALUES (6,N'QLCSVC',N'1','NhanVienQLCSVC')
/*N'Test bảng NHANVIEN'*/
INSERT INTO [tblNHANVIEN] ([maNhanVien],[maTaiKhoan],[hoTen],[tuoi],[diaChi],[gioiTinh],[soDT]) VALUES (1,1,N'Lý Đạo Nam',20,N'01 Trần Duy Hưng, Hà Nội =)))','Nam','0969696969')
INSERT INTO [tblNHANVIEN] ([maNhanVien],[maTaiKhoan],[hoTen],[tuoi],[diaChi],[gioiTinh],[soDT]) VALUES (2,2,N'Võ Văn Tài Triển',20,N'Bùi Viện','Nam','0977777777')
/*N'Test bảng KHACHHANG'*/
INSERT INTO [tblKHACHHANG] ([maKH],[tenKH],[loaiKH],[diaChi],[gioiTinh],[soDT]) VALUES (1,N'CHỦ SÂN',N'Vãng lai',N'NHÀ VỢ BẾ','Nam','0966666666')
/*N'Test bảng PHIEUDATSAN'*/
INSERT INTO [tblPHIEUDATSAN] ([maPhieuDatSan], [maNhanVien],[maKH]) VALUES (1,2,1)
/*N'Test bảng SAN'*/
INSERT INTO [tblSAN] ([maSan], [tinhTrang]) VALUES (1,0)
INSERT INTO [tblSAN] ([maSan], [tinhTrang]) VALUES (2,0)
/*N'Test bảng CHITIETDATSAN'*/
INSERT INTO [tblCHITIETDATSAN] ([maPhieuDatSan],[maSan],[ngayDat],[gioDat],[thoiLuong]) VALUES (1,1,'2019-03-03','20:00','00:30')
/*N'Test bảng THAMSO'*/
INSERT INTO [tblTHAMSO] ([luongnhanvien],[tiengiuxe],[giasanngay],[giasandem],[sotiencoc]) VALUES (10000,5000,30000,50000,10000)
/*N'Test bảng HOADON'*/
INSERT INTO [tblHOADON] ([maHoaDon],[maNhanVien],[maKH],[ngaytaohoadon]) VALUES (1,1,1,'2019-03-03')
/*N'Test bảng LOAIHOADON'*/
INSERT INTO [tblLOAIHOADON] ([maLoaiHoaDon],[loaihoadon]) VALUES (1,'Thu Sân')
INSERT INTO [tblLOAIHOADON] ([maLoaiHoaDon],[loaihoadon]) VALUES (2,'Chi CSVC')
INSERT INTO [tblLOAIHOADON] ([maLoaiHoaDon],[loaihoadon]) VALUES (3,'Thu Nước')
INSERT INTO [tblLOAIHOADON] ([maLoaiHoaDon],[loaihoadon]) VALUES (4,'Chi Nước')
/*N'Test bảng CHITIETHOADON'*/
INSERT INTO [tblCHITIETHOADON] ([maLoaiHoaDon],[maHoaDon],[trigiahoadon]) VALUES (1,2,100000)
/*N'Test bảng CSVC'*/
INSERT INTO [tblCSVC] ([maCSVC],[maNhanVien],[tencsvc],[csvctot],[csvchong],[dongianhap]) VALUES (1,2,'bong',50,5,50000)
INSERT INTO [tblCSVC] ([maCSVC],[maNhanVien],[tencsvc],[csvctot],[csvchong],[dongianhap]) VALUES (2,2,'luoi',50,5,50000)
INSERT INTO [tblCSVC] ([maCSVC],[maNhanVien],[tencsvc],[csvctot],[csvchong],[dongianhap]) VALUES (3,2,'san co',50,5,50000)
INSERT INTO [tblCSVC] ([maCSVC],[maNhanVien],[tencsvc],[csvctot],[csvchong],[dongianhap]) VALUES (4,2,'den',50,5,50000)
/*N'Test bảng DOUONG'*/
INSERT INTO [tblDOUONG] ([maDoUong],[tendouong],[soluongconlai],[dongianhap],[dongiaban],[ngaytaohoadon]) VALUES (1,'nuoc suoi',5,5000,10000,'2019-03-03')
INSERT INTO [tblDOUONG] ([maDoUong],[tendouong],[soluongconlai],[dongianhap],[dongiaban],[ngaytaohoadon]) VALUES (2,'nuocrevive',10,5000,10000,'2019-03-03')
