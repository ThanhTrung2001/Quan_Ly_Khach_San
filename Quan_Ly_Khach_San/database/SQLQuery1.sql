use KSQL

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
	maNV varchar(10),
	maKH varchar(10),
	/*chỉnh sửa*/
	maDSMA varchar(10), /*dsma lấy từ bảng CTDSMonAn*/

	tongTien money,
	tienNhan money,
	tienThua money,

	maRR varchar(10),
	soTienHoan int,

	maTinhTrang varchar(10),
	ghiChu varchar(100),
)

create table CTDSDichVu
(
	maChiTietDV varchar(10) primary key,
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

create table Phong
(
	maPhong varchar(10) primary key,
	loaiPhong varchar(20),
	/*giá tính theo loại phòng*/
	gia money,
	tinhTrang varchar(10),
)

create table HoaDonPhong
(
	maHoaDon varchar(10) primary key,
	checkin datetime,
	checkout datetime,
	maNV varchar(10),
	maKH varchar(10),

	maPhong varchar(10),
	soNgayO int,

	tongTien money,
	tienNhan money,
	tienThua money,

	maRR varchar(10),
	soTienHoan int,
	maTinhTrang varchar(10),
	ghiChu varchar(100),
)

create table HoaDonDichVu
(
	maHoaDon varchar(10) primary key,
	checkin datetime,
	checkout datetime,
	maNV varchar(10),
	maKH varchar(10),

	maDSDV varchar(10),

	tongTien money,
	tienNhan money,
	tienThua money,

	maRR varchar(10),
	soTienHoan int,
	maTinhTrang varchar(10),
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
	loaiRR varchar(100),
	phanHoanTien float,
)
--ALTER TABLE RUIRO ALTER COLUMN loaiRR varchar(100)

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
alter table HoaDonMonAn add constraint FK_HoaDonMonAn_TinhTrang foreign key (maTinhTrang) references TinhTrang (maTinhTrang)

alter table CTDSDichVu add constraint FK_CTDSDichVu_DichVu foreign key (maDV) references DichVu (maDV)
--alter table CTDSDichVu add constraint FK_CTDSDichVu_HoaDonPhongVaDichVu foreign key (maHoaDon) references HoaDonPhongVaDichVu (maHoaDon)

alter table DichVu add constraint FK_DichVu_LoaiDichVu foreign key (maLoaiDichVu) references LoaiDichVu (maLoaiDichVu)
alter table DichVu add constraint FK_DichVu_DonViTinh foreign key (maDVT) references DonViTinh (maDVT)

alter table DichVu add constraint FK_DichVu_TinhTrang foreign key (maTinhTrang) references TinhTrang (maTinhTrang)

--alter table CTDSPhong add constraint FK_CTDSPhong_HoaDonPhongVaDichVu foreign key (maHoaDon) references HoaDonPhongVaDichVu (maHoaDon)

alter table HoaDonPhong add constraint FK_HoaDonPhong_NhanVien foreign key (maNV) references NhanVien (maNV)
alter table HoaDonPhong add constraint FK_HoaDonPhong_KhachHang foreign key (maKH) references KhachHang (maKH)
alter table HoaDonPhong add constraint FK_HoaDonPhong_RuiRo foreign key (maRR) references RuiRo (maRR)
alter table HoaDonPhong add constraint FK_HoaDonPhong_Phong foreign key (maPhong) references Phong (maPhong)

alter table HoaDonDichVu add constraint FK_HoaDonDichVu_NhanVien foreign key (maNV) references NhanVien (maNV)
alter table HoaDonDichVu add constraint FK_HoaDonDichVu_KhachHang foreign key (maKH) references KhachHang (maKH)
alter table HoaDonDichVu add constraint FK_HoaDonDichVu_RuiRo foreign key (maRR) references RuiRo (maRR)
--alter table HoaDonDichVu add constraint FK_HoaDonDichVu_CTDSDichVu foreign key (maDSDV) references CTDSDichVu (maDSDV)

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
insert into DonViTinh values ('pl','plate')
insert into DonViTinh values ('ti', 'ticket')

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
insert into LoaiDichVu values ('TS003','Hot water')

--Tang 1
insert into Phong values ('P101','Single',3000,'Empty')
insert into Phong values ('P103','Single',3000,'Empty')
insert into Phong values ('P105','Single',3000,'Empty')
insert into Phong values ('P102','Double',5000,'Empty')
insert into Phong values ('P104','Double',5000,'Empty')
insert into Phong values ('P106','Double',5000,'Empty')
--Tang 2
insert into Phong values ('P201','Single',4500,'Empty')
insert into Phong values ('P203','Single',4500,'Empty')
insert into Phong values ('P205','Single',4500,'Empty')
insert into Phong values ('P202','Double',7000,'Empty')
insert into Phong values ('P204','Double', 7000,'Empty')
insert into Phong values ('P206','Double',7000,'Empty')
--Tang 3
insert into Phong values ('P301','Twin', 9000,'Empty')
insert into Phong values ('P302','Twin', 9000,'Empty')
insert into Phong values ('P303','Twin', 9000,'Empty')
insert into Phong values ('P304','Twin', 9000,'Empty')
--Tang 4
insert into Phong values ('P401','King', 12000,'Empty')
insert into Phong values ('P402','King', 12000,'Empty')
insert into Phong values ('P403','King', 12000,'Empty')
insert into Phong values ('P404','King', 12000,'Empty')

--DichVu
insert into DichVu values ('S001', 'Sauna Evening', 'TS001','ti', 100, 1,'St')
insert into DichVu values ('S002', 'Message Fish', 'TS002','ti', 80, 1,'St')
insert into DichVu values ('S003', 'Join Hot Water', 'TS003','ti', 150, 1,'St');

--delete from DichVu
--where maDV = 'S003'


insert into LoaiBaoCao values ('T001','Food Report')
insert into LoaiBaoCao values ('T002','Room and Service Report')
insert into LoaiBaoCao values ('T003','Supplier Report')

insert into MonAn values('F001','Beafsteak','TF002','pl', 100,'')
insert into MonAn values('F002','Soup','TF002','pl', 50,'')



insert into RuiRo values('RR999','Security', 50)
insert into RuiRo values('RR888','Poor service', 30)
insert into RuiRo values('RR777','Infrastructure', 27)
insert into RuiRo values('RR666','Dirty', 20)
insert into RuiRo values('RR555','Bad quality, unlike advertising', 45)

insert into KhachHang values('285771511','Dang Duy Bang','0358695320','285771511','Binh Phuoc','')
insert into KhachHang values('285551882','Nguyen Nhut Tan','0328795320','285551882','Quan 2 TpHCM','')
insert into KhachHang values('285020111','Nguyen Thanh Trung','0328795320','285020111','Da Nang','')



