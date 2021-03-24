--Kiểm tra thông tin khách hàng
create or alter proc kiemtrakh @tenkh nvarchar(30), @sodt varchar(15), @makh smallint, @diachi nvarchar(50)
as
begin
if(select count(*) from KhachHang where MaKH=@makh) >0 
print N'Đã trùng mã khách hàng, mời chọn mã khác'
else
	if(select COUNT(*) from KhachHang where SoDT=@sodt) > 0
	print N'Số điện thoại đã được sử dụng, mời chọn số điện thoại khác'
	else
	begin
	insert into KhachHang(MaKH, TenKH, DiaChi, SoDT) values (@makh, @tenkh,@diachi, @sodt)
	print N'Thêm khách hàng thành công'
	end
end


create or alter proc sua_thongtin_kh @makh smallint, @tenkh nvarchar(30), @sodt varchar(15), @diachi nvarchar(50), @makh_cu smallint
as
begin
if(select COUNT(*) from KhachHang where MaKH = @makh_cu) =0
print N'Không có khách hàng này'
else if(select COUNT(*) from KhachHang where MaKH = @makh) != 0
print N'Trùng mã khách hàng, mời chọn mã khác'
else
begin
update KhachHang set MaKH=@makh, TenKH= @tenkh, SoDT=@sodt, DiaChi=@diachi where MaKH= @makh_cu
update HDBan set MaKH=@makh where MaKH= @makh_cu
print N'Sửa thông tin khách hàng cung hóa đơn đi kèm thành công'
end
end

--execute sua_thongtin_kh '3','Đào Bá','0111111111','Long Biên', '333'

create or alter  proc xoa_thongtin_kh @makh smallint, @tenkh nvarchar(30), @sodt varchar(15), @diachi nvarchar(50)
as
begin
	if(select COUNT(*) from KhachHang where MaKH = @makh and TenKH= @tenkh and SoDT=@sodt and DiaChi=@diachi) =0
	print N'Không có khách hàng này'
else 
	begin 
	delete KhachHang where MaKH = @makh
	delete HDBan where MaKH = @makh
	print N'Đã xóa thông tin khách hàng cùng hóa đơn đi kèm'
	end
end

--execute kiemtrakh 'Phàm Nhân Tu Tiên','12345678901','12345',''
--execute xoa_thongtin_kh '1', 'Phàm Nhân Tu Tiên', '12345678901', ''
--select * from KhachHang