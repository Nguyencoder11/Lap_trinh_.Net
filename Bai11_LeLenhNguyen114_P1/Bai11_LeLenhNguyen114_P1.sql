use master
create database QLBanHang

use QLBanHang
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

