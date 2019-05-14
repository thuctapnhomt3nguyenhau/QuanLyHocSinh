USE TT_QLHS
GO
-----------------------Giao Vien------------------------
CREATE PROCEDURE SP_GiaoVien_GetAll
AS
BEGIN
  SELECT *
  FROM GiaoVien
END
GO

CREATE PROCEDURE SP_GiaoVien_Insert
  @tenGiaoVien NVARCHAR(50),
  @gioiTinh NVARCHAR(4),
  @ngaySinh DATE,
  @soDienThoai NVARCHAR(12)
AS
BEGIN
  INSERT INTO GiaoVien
    (tenGiaoVien, gioiTinh, ngaySinh, soDienThoai)
  VALUES(@tenGiaoVien, @gioiTinh, @ngaySinh, @soDienThoai)
END
GO

CREATE PROCEDURE SP_GiaoVien_Delete
  @idGiaoVien INT
AS
BEGIN
  UPDATE LopHoc
  SET idGiaoVienChuNhiem = NULL
  WHERE idGiaoVienChuNhiem = @idGiaoVien

  UPDATE MonHoc
  SET idGiaoVien = NULL
  WHERE idGiaoVien = @idGiaoVien

  DELETE GiaoVien
  WHERE idGiaoVien = @idGiaoVien
END
GO

CREATE PROCEDURE SP_GiaoVien_Update
  @idGiaoVien INT,
  @tenGiaoVien NVARCHAR(50),
  @gioiTinh NVARCHAR(4),
  @ngaySinh DATE,
  @soDienThoai NVARCHAR(12)
AS
BEGIN
  UPDATE GiaoVien
  SET tenGiaoVien = @tenGiaoVien,
  gioiTinh = @gioiTinh,
  ngaySinh = @ngaySinh,
  soDienThoai = @soDienThoai
  WHERE idGiaoVien = @idGiaoVien
END
GO

CREATE PROCEDURE SP_GiaoVien_Search
  @searchValue NVARCHAR(200)
AS
BEGIN
  SELECT *
  FROM GiaoVien
  WHERE idGiaoVien LIKE N'%' + @searchValue + '%'
    OR idGiaoVien LIKE N'%' + @searchValue + '%'
    OR tenGiaoVien LIKE N'%' + @searchValue + '%'
    OR gioiTinh LIKE N'%' + @searchValue + '%'
    OR ngaySinh LIKE N'%' + @searchValue + '%'
    OR soDienThoai LIKE N'%' + @searchValue + '%'
END
GO
-----------------------Lop Hoc------------------------
CREATE PROCEDURE SP_LopHoc_GetAll
AS
BEGIN
  SELECT *
  FROM LopHoc
END
GO

CREATE PROCEDURE SP_LopHoc_Insert
  @tenLopHoc NVARCHAR(50),
  @tenKhoi NVARCHAR(3),
  @namHoc NVARCHAR(10),
  @idGiaoVienChuNhiem INT
AS
BEGIN
  INSERT INTO LopHoc
    (tenLopHoc, tenKhoi, namHoc, idGiaoVienChuNhiem)
  VALUES(@tenLopHoc, @tenKhoi, @namHoc, @idGiaoVienChuNhiem)
END
GO

CREATE PROCEDURE SP_LopHoc_Delete
  @idLopHoc INT
AS
BEGIN
  UPDATE HocSinh
  SET idLopHoc = NULL
  WHERE idLopHoc = @idLopHoc
  DELETE LopHoc
  WHERE idLopHoc = @idLopHoc
END
GO

CREATE PROCEDURE SP_LopHoc_Update
  @idLopHoc INT,
  @tenLopHoc NVARCHAR(50),
  @tenKhoi NVARCHAR(3),
  @namHoc NVARCHAR(10),
  @idGiaoVienChuNhiem INT
AS
BEGIN
  UPDATE LopHoc
  SET tenLopHoc = @tenLopHoc,
  tenKhoi = @tenKhoi,
  namHoc = @namHoc,
  idGiaoVienChuNhiem = @idGiaoVienChuNhiem
  WHERE idLopHoc = @idLopHoc
END
GO

CREATE PROCEDURE SP_LopHoc_Search
  @searchValue NVARCHAR(50)
AS
BEGIN
  SELECT *
  FROM LopHoc
  WHERE idLopHoc LIKE N'%' + @searchValue + '%'
    OR tenLopHoc LIKE N'%' + @searchValue + '%'
    OR tenKhoi LIKE N'%' + @searchValue + '%'
    OR namHoc LIKE N'%' + @searchValue + '%'
    OR idGiaoVienChuNhiem LIKE N'%' + @searchValue + '%'
END
GO

-----------------------Hoc Sinh------------------------
CREATE PROCEDURE SP_HocSinh_GetAll
AS
BEGIN
  SELECT *
  FROM HocSinh
END
GO

CREATE PROCEDURE SP_HocSinh_Insert
  @tenHocSinh NVARCHAR(50),
  @gioiTinh NVARCHAR(4),
  @ngaySinh DATE,
  @idLopHoc INT
AS
BEGIN
  INSERT INTO HocSinh
    (tenHocSinh, gioiTinh, ngaySinh, idLopHoc)
  VALUES(@tenHocSinh, @gioiTinh, @ngaySinh, @idLopHoc)
END
GO

CREATE PROCEDURE SP_HocSinh_Delete
  @idHocSinh INT
AS
BEGIN
  DELETE BangDiem
  WHERE idHocSinh = @idHocSinh
  DELETE HocSinh
  WHERE idHocSinh = @idHocSinh
END
GO

CREATE PROCEDURE SP_HocSinh_Update
  @idHocSinh INT,
  @tenHocSinh NVARCHAR(50),
  @gioiTinh NVARCHAR(4),
  @ngaySinh DATE,
  @idLopHoc INT
AS
BEGIN
  UPDATE HocSinh
  SET tenHocSinh = @tenHocSinh,
  gioiTinh = @gioiTinh,
  ngaySinh = @ngaySinh,
  idLopHoc = @idLopHoc
  WHERE idHocSinh = @idHocSinh
END
GO

CREATE PROCEDURE SP_HocSinh_Search
  @searchValue NVARCHAR(200)
AS
BEGIN
  SELECT *
  FROM HocSinh
  WHERE idHocSinh LIKE N'%' + @searchValue + '%'
    OR tenHocSinh LIKE N'%' + @searchValue + '%'
    OR gioiTinh LIKE N'%' + @searchValue + '%'
    OR ngaySinh LIKE N'%' + @searchValue + '%'
    OR idLopHoc LIKE N'%' + @searchValue + '%'
END
GO



-----------------------Mon Hoc------------------------
CREATE PROCEDURE SP_MonHoc_GetAll
AS
BEGIN
  SELECT *
  FROM MonHoc
END
GO

CREATE PROCEDURE SP_MonHoc_Insert
  @tenMonHoc NVARCHAR(50),
  @soTietHoc INT,
  @namHoc NVARCHAR(10),
  @kiHoc INT,
  @idGiaoVien int
AS
BEGIN
  INSERT INTO MonHoc
    (tenMonHoc, soTietHoc, namHoc, kiHoc, idGiaoVien)
  VALUES(@tenMonHoc, @soTietHoc, @namHoc, @kiHoc, @idGiaoVien)
END
GO

CREATE PROCEDURE SP_MonHoc_Delete
  @idMonHoc INT
AS
BEGIN
  DELETE BangDiem
  WHERE idMonHoc = @idMonHoc
  DELETE MonHoc
  WHERE idMonHoc = @idMonHoc
END
GO

CREATE PROCEDURE SP_MonHoc_Update
  @idMonHoc INT,
  @tenMonHoc NVARCHAR(50),
  @soTietHoc INT,
  @namHoc NVARCHAR(10),
  @kiHoc INT,
  @idGiaoVien INT
AS
BEGIN
  UPDATE MonHoc
  SET tenMonHoc = @tenMonHoc,
      soTietHoc = @soTietHoc,
      namHoc = @namHoc,
      kiHoc = @kiHoc,
      idGiaoVien = @idGiaoVien
  WHERE idMonHoc = @idMonHoc
END
GO

CREATE PROCEDURE SP_MonHoc_Search
  @searchValue NVARCHAR(50)
AS
BEGIN
  SELECT *
  FROM MonHoc
  WHERE idMonHoc LIKE N'%' + @searchValue + '%'
    OR tenMonHoc LIKE N'%' + @searchValue + '%'
    OR soTietHoc LIKE N'%' + @searchValue + '%'
    OR namHoc LIKE N'%' + @searchValue + '%'
    OR kiHoc LIKE N'%' + @searchValue + '%'
    OR idGiaoVien LIKE N'%' + @searchValue + '%'
END
GO

-----------------------Bang Diem------------------------
CREATE PROCEDURE SP_BangDiem_GetAll
AS
BEGIN
  SELECT *
  FROM BangDiem
END
GO
CREATE PROCEDURE SP_BangDiem_GetByIdMonHoc
	@idMonHoc int
AS
BEGIN
  SELECT *
  FROM BangDiem
  WHERE idMonHoc = @idMonHoc
END
GO
CREATE PROCEDURE SP_BangDiem_Insert
  @diem15phut FLOAT,
  @diem45phut FLOAT,
  @diemHocKi FLOAT,
  @idMonHoc INT,
  @idHocSinh INT
AS
BEGIN
  INSERT INTO BangDiem
    (diem15phut, diem45phut, diemHocKi, idMonHoc, idHocSinh)
  VALUES(@diem15phut, @diem45phut, @diemHocKi, @idMonHoc, @idHocSinh)
END
GO

CREATE PROCEDURE SP_BangDiem_Delete
  @idBangDiem INT
AS
BEGIN
  DELETE BangDiem
  WHERE idBangDiem = @idBangDiem
END
GO

CREATE PROCEDURE SP_BangDiem_Update
  @idBangDiem INT,
  @diem15phut FLOAT,
  @diem45phut FLOAT,
  @diemHocKi FLOAT,
  @idMonHoc INT,
  @idHocSinh INT
AS
BEGIN
  UPDATE BangDiem
  SET diem15phut = @diem15phut,
  diem45phut = @diem45phut,
  diemHocKi = @diemHocKi,
  idMonHoc = @idMonHoc,
  idHocSinh = @idHocSinh
  WHERE idBangDiem = @idBangDiem
END
GO

CREATE PROCEDURE SP_BangDiem_Search
  @searchValue NVARCHAR(200)
AS
BEGIN
  SELECT *
  FROM BangDiem
  WHERE idBangDiem LIKE N'%' + @searchValue + '%'
    OR diem15phut LIKE N'%' + @searchValue + '%'
    OR diem45phut LIKE N'%' + @searchValue + '%'
    OR diemHocKi LIKE N'%' + @searchValue + '%'
    OR idMonHoc LIKE N'%' + @searchValue + '%'
    OR idHocSinh LIKE N'%' + @searchValue + '%'
END
GO