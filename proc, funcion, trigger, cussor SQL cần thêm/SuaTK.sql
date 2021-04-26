CREATE PROC [dbo].[TaiKhoan_Sua]
@maNV smallint,
@tenNV nvarchar(30),
@diachi nvarchar(50),
@sodt varchar(15),
@luong bigint,
@pass varchar(20)

AS
BEGIN
	UPDATE NhanVien
	SET	TenNV=@tenNV,
		DiaChi = @diachi,
		SoDT = @sodt,
		Luong = @luong
	WHERE MaNV = @maNV

	UPDATE TaiKhoan
	SET	MatKhau = @pass
	WHERE MaNV = @maNV
END