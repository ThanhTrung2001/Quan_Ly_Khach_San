﻿
use dbQLNH

create table TaiKhoan
(
	maTaiKhoan varchar(10) primary key,
	tenDangNhap varchar(100),
	matKhau varchar(100),
	maChucVu varchar(10),
)

create table ChucVu
(
	maChucVu varchar(10) primary key,
	tenChucVu varchar(100),
)

create table NhanVien
(
	maNV varchar(10) primary key,
	tenNV varchar(100),
	ngaySinh datetime,
	CMND varchar(10),
	diaChi varchar(100),
	SDT varchar(10),
	maTaiKhoan varchar(10),
	maChucVu varchar(10),
)

create table PYCMuaHang
(
	maPhieu varchar(10) primary key,
	ngayLap datetime,
	ngayCapNhat datetime,
	/*chỉnh sửa*/
	maDSNL varchar(10), /*dsnl lấy từ bảng DSNguyenLieu*/

	maTinhTrang varchar(10),
	ghiChu varchar(100),
)

create table TinhTrang
(
	maTinhTrang varchar(10) primary key,
	tinhTrang varchar(100),
)

create table CTDSNguyenLieu
(
	maChiTiet varchar(10) primary key,
	maDSNL varchar(10),
	maNL varchar(10),
	tenNL varchar(100),
	/*số lượng yêu cầu*/
	soLuong int,
	maDonViTinh varchar(10),
	donGia money,
	thanhTien money,
)

create table DonViTinh
(
	maDVT varchar(10) primary key,
	donViTinh varchar(100),
)

create table NguyenLieu
(
	maNL varchar(10) primary key,
	tenNL varchar(100),
	maLoaiNL varchar(10),
	maDVT varchar(10),
	/*tổng số lượng có trong kho*/
	soLuong int,
)

create table ChiTietDL
(
	maChiTiet varchar(10) primary key,
	maNL varchar(10),
	maDL varchar(10),
)

create table LoaiNguyenLieu
(
	maLoaiNL varchar(10) primary key,
	loaiNguyenLieu varchar(100),
)

create table PhieuThanhToan
(
	maPhieu varchar(10) primary key,
	ngayLap datetime,
	maDL varchar(10),
	maNV varchar(10),
	/*chính sửa*/
	maDSNL varchar(10), /*dsnl lấy từ bảng DSNGUYENLIEU*/

	tongTien money,
	maTrangThai varchar(10),
	ghiChu varchar(10)
)

create table DaiLy
(
	maDL varchar(10) primary key,
	tenDL varchar(100),
	diaChi varchar(100),
	SDT varchar(10),
	email varchar(100),
	ghiChu varchar(100),
)

create table PhieuNhapKho
(
	maPhieu varchar(10) primary key,
	ngayLap datetime,
	maNV varchar(10),
	/*chỉnh sửa*/
	maDSNL varchar(10), /*dsnl lấy từ bảng DSnguyeen laiueje*/

	ghiChu varchar(100),
)

create table CTDSMonAn
(
	maChiTiet varchar(10) primary key,
	maDSMA varchar(10),
	maMonAn varchar(10),
	tenMonAn varchar(100),
	soLuong int,
	maDVT varchar(10),
	gia money,
	thanhTien money,
	ghiChu varchar(100),
)

create table MonAn
(
	maMonAn varchar(10) primary key,
	TenMonAn varchar(100),
	maLoaiMonAn varchar(10),
	maDVT varchar(10),
	gia money,
	ghiChu varchar(100),
)

create table LoaiMonAn
(
	maLoaiMonAn varchar(10) primary key,
	loaiMonAn varchar(100),
)

create table PhieuXuatKho
(
	maPhieu varchar(10) primary key,
	ngayLap datetime,
	maNV varchar(10),
	/*chỉnh sửa*/
	maDSNL varchar(10), /*dsnl lấy từ bảng DSnguyeen laiueje*/

	lyDo varchar(100),
	ghiChu varchar(100),
)

create table HoaDonMonAn
(
	maHoaDon varchar(10) primary key,
	ngayLap datetime,
	ban int,
	maNV varchar(10),
	maKH varchar(10),
	/*chỉnh sửa*/
	maDSMA varchar(10), /*dsma lấy từ bảng CTDSMonAn*/

	tongTien money,
	tienNhan money,
	tienThua money,

	maRR varchar(10),
	soTienHoan int,

	maTrangThai varchar(10),
	ghiChu varchar(100),
)

create table CTDSDichVu
(
	maChiTiet varchar(10) primary key,
	maDSDV varchar(10),
	maDV varchar(10),
	maLoaiDichVu varchar(10),
	gia money, 
	soLuong int,
	maDVT varchar(10),
	thanhTien money,
)

create table DichVu
(
	maDV varchar(10) primary key,
	tenDV varchar(100),
	maLoaiDichVu varchar(10),
	maDVT varchar(10),
	gia money,
	soLuong int,
	maTinhTrang varchar(10),
)

create table LoaiDichVu
(
	maLoaiDichVu varchar(10) primary key,
	loaiDichVu varchar(10),
)

create table CTDSPhong
(
	maChiTiet varchar(10) primary key,
	maDSP varchar(10),
	maPhong varchar(10),
	maLoaiPhong varchar(10),
	thanhTien money,
)

create table Phong
(
	maPhong varchar(10) primary key,
	tenPhong varchar(100),
	maLoaiPhong varchar(10),
	tang int,
	/*giá tính theo loại phòng*/
	gia money,
	maTinhTrang varchar(10),
)

create table LoaiPhong
(
	maLoaiPhong varchar(10) primary key,
	loaiPhong varchar(10),
	gia money,
)

create table HoaDonPhongVaDichVu
(
	maHoaDon varchar(10) primary key,
	ngayLap datetime,
	checkin datetime,
	checkout datetime,
	maNV varchar(10),
	maKH varchar(10),

	maDSP varchar(10), /*dsnl lấy từ bảng CTDSPhong*/
	maDSDV varchar(10), /*dsnl lấy từ bảng CTDSDichVu*/

	tongTien money,
	tienNhan money,
	tienThua money,

	maRR varchar(10),
	soTienHoan int,
	maTrangThai varchar(10),
	ghiChu varchar(100),
)

create table BaoCaoNgay
(
	maBC varchar(10) primary key,
	ngayBC datetime,
	maLoaiBC varchar(10),
	tongThu money,
	tongChi money,
)

create table BaoCaoThang
(
	maBC varchar(10) primary key,
	thangBC datetime,
	maLoaiBC varchar(10),
	tongThu money,
	tongChi money,
)

create table LoaiBaoCao
(
	maLoaiBC varchar(10) primary key,
	loaiBaoCao varchar(100),
)

create table KhachHang 
(
	maKH varchar(10) primary key,
	tenKhachHang varchar(100),
	SDT varchar(10),
	CMND varchar(100),
	diaChi varchar(100),
	ghiChu varchar(100),
)

create table RuiRo 
(
	maRR varchar(10) primary key,
	loaiRR varchar(10),
	phanHoanTien float,
)

alter table NhanVien add constraint FK_NhanVien_ChucVu foreign key (maChucVu) references ChucVu (maChucVu)
alter table NhanVien add constraint FK_NhanVien_TaiKhoan foreign key (maTaiKhoan) references TaiKhoan (maTaiKhoan)
/**/
alter table PYCMuaHang add constraint FK_PYCMuaHang_TinhTrang foreign key (maTinhTrang) references TinhTrang (maTinhTrang)

alter table CTDSNguyenLieu add constraint FK_CTDSNguyenLieu_NguyenLieu foreign key (maNL) references NguyenLieu (maNL)
--alter table CTDSNguyenLieu add constraint FK_CTDSNguyenLieu_PhieuYeuCau foreign key (maPhieu) references PYCMuaHang (maPhieu)
--alter table CTDSNguyenLieu add constraint FK_CTDSNguyenLieu_PhieuThanhToan foreign key (maPhieu) references PhieuThanhToan (maPhieu)
--alter table CTDSNguyenLieu add constraint FK_CTDSNguyenLieu_PhieuNhapKho foreign key (maPhieu) references PhieuNhapKho (maPhieu)
--alter table CTDSNguyenLieu add constraint FK_CTDSNguyenLieu_PhieuXuatKho foreign key (maPhieu) references PhieuXuatKho (maPhieu)

alter table NguyenLieu add constraint FK_NguyenLieu_LoaiNL foreign key (maLoaiNL) references LoaiNguyenLieu (maLoaiNL)
alter table NguyenLieu add constraint FK_NguyenLieu_DonViTinh foreign key (maDVT) references DonViTinh (maDVT)

alter table ChiTietDL add constraint FK_ChiTietDL_NguyenLieu foreign key (maNL) references NguyenLieu (maNL)
alter table ChiTietDL add constraint FK_ChiTietDL_DaiLy foreign key (maDL) references DaiLy (maDL)

alter table PhieuThanhToan add constraint FK_PThanhToan_DaiLy foreign key (maDL) references DaiLy (maDL)
alter table PhieuThanhToan add constraint FK_PThanhToan_NhanVien foreign key (maNV) references NhanVien (maNV)

alter table PhieuNhapKho add constraint FK_PNhapKho_NhanVien foreign key (maNV) references NhanVien (maNV)

alter table CTDSMonAn add constraint FK_CTDSMonAn_MonAn foreign key (maMonAn) references MonAn (maMonAn)
--alter table CTDSMonAn add constraint FK_CTDSMonAn_HoaDonMonAn foreign key (maHoaDon) references HoaDonMonAn (maHoaDon)

alter table MonAn add constraint FK_MonAn_DonViTinh foreign key (maDVT) references DonViTinh (maDVT)
alter table MonAn add constraint FK_MonAn_LoaiMonAn foreign key (maLoaiMonAn) references LoaiMonAn (maLoaiMonAn)

alter table PhieuXuatKho add constraint FK_PhieuXuatKho_NhanVien foreign key (maNV) references NhanVien (maNV)

alter table HoaDonMonAn add constraint FK_HoaDonMonAn_NhanVien foreign key (maNV) references NhanVien (maNV)
alter table HoaDonMonAn add constraint FK_HoaDonMonAn_RuiRo foreign key (maRR) references RuiRo (maRR)
alter table HoaDonMonAn add constraint FK_HoaDonMonAn_KhachHang foreign key (maKH) references KhachHang (maKH)

alter table CTDSDichVu add constraint FK_CTDSDichVu_DichVu foreign key (maDV) references DichVu (maDV)
--alter table CTDSDichVu add constraint FK_CTDSDichVu_HoaDonPhongVaDichVu foreign key (maHoaDon) references HoaDonPhongVaDichVu (maHoaDon)

alter table DichVu add constraint FK_DichVu_LoaiDichVu foreign key (maLoaiDichVu) references LoaiDichVu (maLoaiDichVu)
alter table DichVu add constraint FK_DichVu_DonViTinh foreign key (maDVT) references DonViTinh (maDVT)

alter table DichVu add constraint FK_DichVu_TinhTrang foreign key (maTinhTrang) references TinhTrang (maTinhTrang)

alter table CTDSPhong add constraint FK_CTDSPhong_Phong foreign key (maPhong) references Phong (maPhong)
--alter table CTDSPhong add constraint FK_CTDSPhong_HoaDonPhongVaDichVu foreign key (maHoaDon) references HoaDonPhongVaDichVu (maHoaDon)

alter table Phong add constraint FK_Phong_LoaiPhong foreign key (maLoaiPhong) references LoaiPhong (maLoaiPhong)
alter table Phong add constraint FK_Phong_TinhTrang foreign key (maTinhTrang) references TinhTrang (maTinhTrang)

alter table HoaDonPhongVaDichVu add constraint FK_HoaDonPhongVaDichVu_NhanVien foreign key (maNV) references NhanVien (maNV)
alter table HoaDonPhongVaDichVu add constraint FK_HoaDonPhongVaDichVu_KhachHang foreign key (maKH) references KhachHang (maKH)
alter table HoaDonPhongVaDichVu add constraint FK_HoaDonPhongVaDichVu_RuiRo foreign key (maRR) references RuiRo (maRR)

alter table BaoCaoNgay add constraint FK_BaoCaoNgay_LoaiBaoCao foreign key (maLoaiBC) references LoaiBaoCao (maLoaiBC)
alter table BaoCaoThang add constraint FK_BaoCaoThang_LoaiBaoCao foreign key (maLoaiBC) references LoaiBaoCao (maLoaiBC)

insert into TinhTrang values ('Ca','Canceled')
insert into TinhTrang values ('Pe','Pending')
insert into TinhTrang values ('Co','Complete')
insert into TinhTrang values ('St', 'Stocking')
insert into TinhTrang values ('So', 'Sold out')

insert into DonViTinh values ('kg','kg')
insert into DonViTinh values ('g','g')
insert into DonViTinh values ('p','piece')

insert into LoaiNguyenLieu values ('TI001','Spice')
insert into LoaiNguyenLieu values ('TI002','Vegetable')
insert into LoaiNguyenLieu values ('TI003','Meat')
insert into LoaiNguyenLieu values ('TI004','Fish')

insert into LoaiMonAn values ('TF001','Appetizer')
insert into LoaiMonAn values ('TF002','Main dishes')
insert into LoaiMonAn values ('TF003','Side dishes')
insert into LoaiMonAn values ('TF004','Snacks')
insert into LoaiMonAn values ('TF005','Dessert')
insert into LoaiMonAn values ('TF006','Drinks')

insert into LoaiDichVu values ('TS001','Sauna')
insert into LoaiDichVu values ('TS002','Massage')
insert into LoaiDichVu values ('TS003','Hot waterfall')

insert into LoaiPhong values ('TR001','Single',3000)
insert into LoaiPhong values ('TR002','Double', 4000)
insert into LoaiPhong values ('TR003','Queen', 6000)
insert into LoaiPhong values ('TR004','King', 7000)
insert into LoaiPhong values ('TR005','Twin', 5000)

insert into LoaiBaoCao values ('T001','Food')
insert into LoaiBaoCao values ('T002','Service')
insert into LoaiBaoCao values ('T003','Room')

select*from KhachHang
insert into KhachHang (maKH, tenKhachHang) values('312465538', 'Nguyen nhut tan')
