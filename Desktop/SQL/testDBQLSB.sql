/*N'TEST DATABASE QUẢN LÝ SÂN BANH'*/
/*N'FILE NÀY ĐỂ TẠO CÁC TRƯỜNG MẶC ĐỊNH CHO CSDL'*/

USE [master]
USE [QLSB]
GO
SET DATEFORMAT DMY
/*N'Tạo giá trị mặc định'*/
/*N'Test bảng TAIKHOAN'*/
INSERT INTO [tblTAIKHOAN] ([maTaiKhoan],[userName],[passWord]) VALUES (1,N'lydaonam',N'namlydao123')
INSERT INTO [tblTAIKHOAN] ([maTaiKhoan],[userName],[passWord]) VALUES (2,N'taitrien',N'taitrien99')
INSERT INTO [tblTAIKHOAN] ([maTaiKhoan],[userName],[passWord]) VALUES (3,N'duytan',N'duytan99')
INSERT INTO [tblTAIKHOAN] ([maTaiKhoan],[userName],[passWord]) VALUES (4,N'ngovi',N'ngovi98')
/*N'Test bảng NHANVIEN'*/
INSERT INTO [tblNHANVIEN] ([maNhanVien],[maTaiKhoan],[hoTen],[tuoi],[diaChi],[gioiTinh],[soDT]) VALUES (1,1,N'Lý Đạo Nam',20,N'01 Trần Duy Hưng, Hà Nội =)))','Nam','0969696969')
INSERT INTO [tblNHANVIEN] ([maNhanVien],[maTaiKhoan],[hoTen],[tuoi],[diaChi],[gioiTinh],[soDT]) VALUES (2,2,N'Võ Văn Tài Triển',20,N'?????','Nam','0977777777')
INSERT INTO [tblNHANVIEN] ([maNhanVien],[maTaiKhoan],[hoTen],[tuoi],[diaChi],[gioiTinh],[soDT]) VALUES (3,3,N'Tan',20,N'?????','Nam','09888888888')
INSERT INTO [tblNHANVIEN] ([maNhanVien],[maTaiKhoan],[hoTen],[tuoi],[diaChi],[gioiTinh],[soDT]) VALUES (4,4,N'vi',21,N'?????','Nam','0999999999')
/*N'Test bảng KHACHHANG'*/
INSERT INTO [tblKHACHHANG] ([maKH],[tenKH],[loaiKH],[diaChi],[gioiTinh],[soDT]) VALUES (1,N'Ngô Bá Khá',N'Vãng lai',N'Vũ Trường','Nam','0966666666')
INSERT INTO [tblKHACHHANG] ([maKH],[tenKH],[loaiKH],[diaChi],[gioiTinh],[soDT]) VALUES (2,N'Ngô Khá',N'Than Thiet',N'Nha tho','bede','0922222222')
INSERT INTO [tblKHACHHANG] ([maKH],[tenKH],[loaiKH],[diaChi],[gioiTinh],[soDT]) VALUES (3,N'Ngô Bá',N'Vãng lai',N'nha giam','Nam','033333333')
/*N'Test bảng PHIEUDATSAN'*/
INSERT INTO [tblPHIEUDATSAN] ([maPhieuDatSan], [maNhanVien],[maKH]) VALUES (1,2,1)
INSERT INTO [tblPHIEUDATSAN] ([maPhieuDatSan], [maNhanVien],[maKH]) VALUES (1,2,2)
INSERT INTO [tblPHIEUDATSAN] ([maPhieuDatSan], [maNhanVien],[maKH]) VALUES (2,3,3)
/*N'Test bảng SAN'*/
INSERT INTO [tblSAN] ([maSan], [tinhTrang]) VALUES (1,N'Trống')
INSERT INTO [tblSAN] ([maSan], [tinhTrang]) VALUES (2,N'Trống')
/*N'Test bảng CHITIETDATSAN'*/
INSERT INTO [tblCHITIETDATSAN] ([maPhieuDatSan],[maSan],[ngayDat],[gioDat],[thoiLuong]) VALUES (1,1,'18/11/2019','20:00',2)
INSERT INTO [tblCHITIETDATSAN] ([maPhieuDatSan],[maSan],[ngayDat],[gioDat],[thoiLuong]) VALUES (2,1,'19/11/2019','20:00',2)
/*N'Test bảng THAMSO'*/
INSERT INTO [tblTHAMSO] ([luongnhanvien],[tiengiuxe],[giasanngay],[giasandem],[sotiencoc]) VALUES (10000,5000,30000,50000,10000)
/*N'Test bảng HOADON'*/
INSERT INTO [tblHOADON] ([maHoaDon],[maNhanVien],[maKH],[ngaytaohoadon]) VALUES (1,1,1,'18/11/2019')
INSERT INTO [tblHOADON] ([maHoaDon],[maNhanVien],[maKH],[ngaytaohoadon]) VALUES (2,3,3,'19/11/2019')
/*N'Test bảng LOAIHOADON'*/
INSERT INTO [tblLOAIHOADON] ([maLoaiHoaDon],[loaihoadon]) VALUES (1,'thu san')
INSERT INTO [tblLOAIHOADON] ([maLoaiHoaDon],[loaihoadon]) VALUES (2,'thu nuoc')
INSERT INTO [tblLOAIHOADON] ([maLoaiHoaDon],[loaihoadon]) VALUES (3,'chi csvc')
INSERT INTO [tblLOAIHOADON] ([maLoaiHoaDon],[loaihoadon]) VALUES (4,'chi nuoc')
/*N'Test bảng CHITIETHOADON'*/
INSERT INTO [tblCHITIETHOADON] ([maLoaiHoaDon],[maHoaDon],[trigiahoadon]) VALUES (1,1,100000)
INSERT INTO [tblCHITIETHOADON] ([maLoaiHoaDon],[maHoaDon],[trigiahoadon]) VALUES (1,2,10000)
INSERT INTO [tblCHITIETHOADON] ([maLoaiHoaDon],[maHoaDon],[trigiahoadon]) VALUES (2,2,10000)
/*N'Test bảng CSVC'*/
INSERT INTO [tblCSVC] ([maCSVC],[maNhanVien],[tencsvc],[soluongnhap],[dongianhap],[tinhtrangcsvc]) VALUES (1,4,'banh',5,50000,'hu hong')
INSERT INTO [tblCSVC] ([maCSVC],[maNhanVien],[tencsvc],[soluongnhap],[dongianhap],[tinhtrangcsvc]) VALUES (2,4,'san',5,50000,'tot')
/*N'Test bảng DOUONG'*/
INSERT INTO [tblDOUONG] ([maDoUong],[tendouong],[soluongconlai],[dongianhap],[dongiaban]) VALUES (1,'nuoc suoi',5,5000,10000)
INSERT INTO [tblDOUONG] ([maDoUong],[tendouong],[soluongconlai],[dongianhap],[dongiaban]) VALUES (2,'revice',5,5000,10000)
