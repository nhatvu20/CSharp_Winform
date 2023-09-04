create table donviphongban(
	madonvi int not null primary key,
	donviphongban nvarchar(20),
)

create table bangmucluong (
	mamucluong int not null primary key,
	mucluong nvarchar(20)
)



create table nhansu(
	hoten nvarchar(30),
	gioitinh bit,
	ngaysinh Date,
	socccd nvarchar(12),
	email nvarchar(20),
	sodienthoai nvarchar(10),
	diachi nvarchar(20),
	mucdongbhxh int,
	madonvi int not null,
	mamucluong int not null,
	tinhtrang bit,
	foreign key (madonvi) references donviphongban(madonvi),
	foreign key (mamucluong) references bangmucluong(mamucluong)
)

INSERT INTO nhansu VALUES(N'Nhất Vũ','True','2003-10-20','123','123','123','123',123,1,1)