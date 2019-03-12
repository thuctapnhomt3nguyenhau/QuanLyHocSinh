create database QuanLyHocSinhTHPT;
use QuanLyHocSinhTHPT;

-- Table Môn học
create table MonHoc(
  maMonHoc int identity(1,1) not null,
  tenMonHoc nvarchar(50),
  soTietHoc int,
  primary key(maMonHoc),
)
-- Khối 
create table Khoi(
  maKhoi int identity(1,1) not null, 
  tenKhoi nvarchar(50),
  primary key(maKhoi),

)
-- Học Sinh
create table HocSinh(
  maHocSinh int identity(1,1) not null, 
  tenHocSinh nvarchar(50),
  gioiTinh nvarchar(4),
  ngaySinh date,
  diaChi nvarchar(50),
  tenPhuHuynh nvarchar(50),
  soDienThoai nvarchar(12),
  primary key(maHocSinh),
)
-- Giáo viên
create table GiaoVien(
  maGiaoVien int identity(1,1) not null,
  maMonHoc int,
  tenGiaoVien nvarchar(50),
  gioiTinh nvarchar(5),
  diaChi nvarchar(50),
  soDienThoai nvarchar(50),
  bangCap nvarchar(50),

  primary key(maGiaoVien),
  foreign key(maMonHoc) REFERENCES MonHoc(maMonHoc),
)

-- Lớp học
create table LopHoc(
  maLopHoc int identity(1,1) not null, 
  maKhoi int,
  maGiaoVienChuNhiem int,
  tenLop nvarchar(50),
  siSo int,
  
  primary key(maLopHoc),
  foreign key(maKhoi) REFERENCES Khoi(maKhoi),
  foreign key(maGiaoVienChuNhiem) REFERENCES GiaoVien(maGiaoVien),
)

-- Học lớp
create table ChiTietLopHoc(
  maHocSinh int,
  maLopHoc int,
  namHoc int,
  foreign key(maHocSinh) REFERENCES HocSinh(maHocSinh),
  foreign key(maLopHoc) REFERENCES LopHoc(maLopHoc),
)

-- Học tập
create table HocTap(
  maHocSinh int,
  maMonHoc int,
  diem15p float,
  diem45p float,
  diemHocKi float,
  hocKi nvarchar(50),
  hocLuc nvarchar(50),
  namHoc nvarchar(20),
  foreign key(maHocSinh) REFERENCES HocSinh(maHocSinh),
  foreign key(maMonHoc) REFERENCES MonHoc(maMonHoc),
)
