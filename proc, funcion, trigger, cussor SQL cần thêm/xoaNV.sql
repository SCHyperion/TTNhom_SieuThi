use QLSieuThi
go
create or alter proc xoaNV
@manv smallint
as
begin
delete from TaiKhoan where MaNV = @manv
delete from NhanVien where MaNV = @manv
end
