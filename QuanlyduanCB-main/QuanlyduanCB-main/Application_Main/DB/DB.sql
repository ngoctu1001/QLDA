Create Database QLBDS
Go
Use QLBDS
Go
Create table TkDangNhap(
	Chucdanh nvarchar(10) null,
	IDTk char(5) Primary key not null ,
	Tdn nvarchar(max) not null,
	Mk nvarchar(max) not null,
	Ten nvarchar(50) not null,
	GT int not null,
	NS date not null,
	Gmail nvarchar(max) null,
	SDT nvarchar(10) not null
)
Go
Create Table DuAnChuaDuyet(
	IDDACD char(5) Primary key not null,
	TenDuAn nvarchar(50) not null,
	Diachi nvarchar(max) not null,
	Mota nvarchar(max) null,
	Gia int null,
	Dientich float null,
	IDTk char(5),
	Foreign key (IDTk) references TkDangNhap(IDTk)
)
Go
Create table DuAnDaDuyet(
	IDDADD char(5) Primary key not null,
	TenDuAn nvarchar(50) not null,
	DiaChi nvarchar(max) not null,
	Mota nvarchar(max) null,
	Gia int null,
	Dientich float null,
	IDTk char(5),
	Foreign key (IDTk) references TkDangNhap(IDTk)
)
Drop Table DuAnChuaDuyet
Drop Table DuAnDaDuyet
Drop Table TkDangNhap