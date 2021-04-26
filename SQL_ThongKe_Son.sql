Create or Alter function thongKeBan(@MaHang smallint, @MaHD smallint)
returns bigint
as 
begin
declare @soluong int, @giatien bigint, @tongTien bigint
select @soluong=SoLuong, @giatien= GiaBan
from CTHDBan cthdb, MatHang mh
where mh.MaHang=cthdb.MaHang and cthdb.MaHang=@MaHang and cthdb.MaHD=@maHD
set @tongTien=@soluong * @giatien
return @tongTien
end
go

Create or alter function thongKeTheoNgay( @NgayBD date, @NgayKT date)
returns table
as
return (
select hdb.NgayMua, ctb.MaHD,ctb.MaHang,ctb.SoLuong, dbo.thongKeBan(ctb.MaHang,ctb.MaHD) as TongTien
from CTHDBan ctb, HDBan hdb
where hdb.NgayMua between @NgayBD and @NgayKT
)
go
