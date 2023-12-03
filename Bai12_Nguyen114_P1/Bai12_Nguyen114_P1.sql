use master
create database QLBH

use QLBH
create table KhachHang(
	MaKH char(4) not null primary key,
	TenKH nvarchar(50),
	SoDT varchar(12),
	DiaChi nvarchar(50)
)

create table NguoiDung(
	TenDangNhap varchar(10) not null primary key,
	MatKhau varchar(10) not null,
	HoTen nvarchar(50) not null
)

create table LoaiSanPham(
	MaLoai char(3) not null primary key,
	TenLoai nvarchar(50) not null
)

create table SanPham(
	MaSP char(4) not null primary key,
	TenSP nvarchar(50) not null,
	MaLoai char(3),
	SoLuong int,
	DonGia int,
	constraint fk_sp_lsp foreign key(MaLoai)
		references LoaiSanPham(MaLoai)
)

create table HoaDon(
	MaHD char(4) not null primary key,
	NgayLap date,
	MaKH char(4),
	NguoiLap varchar(10),
	TenDangNhap varchar(10),
	constraint fk_hd_kh foreign key(MaKH)
		references KhachHang(MaKH),
	constraint fk_hd_nd foreign key(TenDangNhap)
		references NguoiDung(TenDangNhap)
)

create table HoaDonChiTiet(
	MaHD char(4) not null,
	MaSP char(4) not null,
	SoLuongMua int,
	constraint pk_hdct primary key(MaHD, MaSP),
	constraint fk_hdct_hd foreign key(MaHD)
		references HoaDon(MaHD),
	constraint fk_hdct_sp foreign key(MaSP)
		references SanPham(MaSP)
)

insert into KhachHang values('KH1','Nguyen Van A','0323654756','Ha Noi'), ('KH2','Tran Thi B','0378298734','Thai Binh'), ('KH3','Le Quoc C','0316248923','Ha Noi')
insert into NguoiDung values('Haisaki','123456','Tran Trinh Dong Hai'), ('Himass','135579','La Phuong Tien Dat'), ('Taikonn','246268','Ha Huu Tai')
insert into LoaiSanPham values('L1','Ban phim'), ('L2','Tai nghe'), ('L3','Dien thoai')
insert into SanPham values('SP1','Galaxy Fold 4','L3', 100, 4000000), ('SP2','K550 Leaven','L1', 50, 350000), ('SP3','M1240 Lightning','L1', 75, 320000)
insert into HoaDon values('HD1', '2020-12-11', 'KH1', 'Solozy', 'Taikonn'), ('HD2','2020-07-05','KH2','Ssubang','Himass'), ('HD3','2020-06-15','Kh3','YmCud','Himass')
insert into HoaDonChiTiet values('HD1','SP1', 5), ('HD2','SP2', 7), ('HD3','SP3', 10)

select * from KhachHang
select * from NguoiDung
select * from LoaiSanPham
select * from SanPham
select * from HoaDon
select * from HoaDonChiTiet

select MaSP, TenSP, SoLuong, DonGia, TenLoai
from SanPham inner join LoaiSanPham on SanPham.MaLoai = LoaiSanPham.MaLoai

