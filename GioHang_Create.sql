CREATE TABLE GIOHANG 
(
	Username NVARCHAR(50) REFERENCES TAIKHOAN(Username),
	ThanhTien FLOAT
)

CREATE TABLE CHITIETGIOHANG
(
	Username NVARCHAR(50) REFERENCES TAIKHOAN(Username),
	MaHang NVARCHAR(10) REFERENCES MATHANG(MaHang),
	SoLuong INT
)
