use QLSieuThi
go

create  proc xoahdban
@mahd nchar(10)
as begin

delete from CTHDBan where CTHDBan.MaHD = @mahd

delete from HDBan where HDBan.MaHD = @mahd

end
