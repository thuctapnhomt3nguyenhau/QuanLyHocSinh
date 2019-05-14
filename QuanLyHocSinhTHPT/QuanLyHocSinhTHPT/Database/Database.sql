CREATE DATABASE TT_QLHS
GO

USE TT_QLHS
CREATE TABLE GiaoVien
(
  idGiaoVien INT IDENTITY(1,1) NOT NULL,
  tenGiaoVien NVARCHAR(50) NOT NULL,
  gioiTinh NVARCHAR(4) DEFAULT(N'Nam') CHECK(gioiTinh in (N'Nam', N'Nữ')),
  ngaySinh DATE DEFAULT(GETDATE()),
  soDienThoai NVARCHAR(12),

  PRIMARY KEY(idGiaoVien)
);

CREATE TABLE LopHoc
(
  idLopHoc INT IDENTITY(1,1) NOT NULL,
  tenLopHoc NVARCHAR(50) NOT NULL,
  tenKhoi NVARCHAR(3),
  namHoc NVARCHAR(20),
  idGiaoVienChuNhiem INT,

  PRIMARY KEY(idLopHoc),
  FOREIGN KEY (idGiaoVienChuNhiem) REFERENCES GiaoVien(idGiaoVien)
);


CREATE TABLE HocSinh
(
  idHocSinh INT IDENTITY(1,1) NOT NULL,
  tenHocSinh NVARCHAR(50) NOT NUll,
  gioiTinh NVARCHAR(4),
  ngaySinh DATE,
  idLopHoc INT,

  PRIMARY KEY (idHocSinh),
  FOREIGN KEY(idLopHoc) REFERENCES LopHoc(idLopHoc)
);


CREATE TABLE MonHoc
(
  idMonHoc INT IDENTITY(1,1) NOT NULL,
  tenMonHoc NVARCHAR(50) NOT NULL,
  soTietHoc INT,
  namHoc NVARCHAR(10),
  kiHoc INT CHECK (kiHoc IN (1, 2)),
  idGiaoVien int,

  PRIMARY KEY (idMonHoc),
  FOREIGN KEY (idGiaoVien) REFERENCES GiaoVien (idGiaoVien)
);

CREATE TABLE BangDiem
(
  idBangDiem INT IDENTITY(1,1) NOT NULL,
  diem15phut FLOAT,
  diem45phut FLOAT,
  diemHocKi FLOAT,
  idMonHoc INT,
  idHocSinh INT,

  PRIMARY KEY(idBangDiem),
  FOREIGN KEY(idMonHoc) REFERENCES MonHoc(idMonHoc),
  FOREIGN KEY(idHocSinh) REFERENCES HocSinh(idHocSinh),
);