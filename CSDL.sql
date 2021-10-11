﻿CREATE DATABASE QLTHPT
GO
use QLTHPT
GO
---thisinhthituyen
CREATE TABLE THISINHTHITUYEN(MATHISINH nvarchar(10), HOTEN nvarchar(50), NGAYSINH date,GIOITINH int, DIACHI nvarchar(50)
constraint PK_TSTT primary key (MATHISINH)
);
go
---diemthisinhthituyen   
CREATE TABLE DIEMTUYENSINH(MATHISINH nvarchar(10),DIEMTOAN float,DIEMNGUVAN float,DIEMTIENGANH float,DIEMTONG float
constraint PK_d primary key (MATHISINH)
constraint FK_MTS foreign key (MATHISINH) REFERENCES THISINHTHITUYEN(MATHISINH)
);
GO
---hocsinh
CREATE TABLE HOCSINH(MAHOCSINH nvarchar(10),HOTEN nvarchar(50), NGAYSINH date,GIOITINH int, DIACHI nvarchar(50), MALOP nvarchar(5)
constraint PK_hs primary key (MAHOCSINH)

);
GO
CREATE TABLE DIEMHS(MAHOCSINH nvarchar(10),MAMH nvarchar (10),diemmieng float,diem15p float,diem15p2 float,diem15p3 float,diem1tiet float,diem1tiet2 float,diemthi float,diemtb float
constraint PK_dhs primary key (MAHOCSINH,MAMH)

);
go
CREATE TABLE lop(MALOP nvarchar(5),khoi int,
constraint FK_LOP primary key (MALOP)

);
GO
CREATE TABLE KHOI(SOKHOI INT
constraint PK_Khoi primary key (SOKHOI)
);

Go
CREATE TABLE MONHOC (MAMH nvarchar(10), TENMH nvarchar(50),KHOI int
constraint PK_MONHOC primary key (MAMH)


   
 );
Go
CREATE TABLE GIAOVIEN(
MAGV nvarchar(10), TENGV nvarchar(50),CHUCVU nvarchar(10),NGAYSINH date,GIOITINH int, DIACHI nvarchar(50),NGAYVAOTRUONG date,NGAYDADAY date,HESOLUONG float
constraint PK_GIAOVIEN primary key (MAGV)

   
 );
 GO


 CREATE TABLE GVDAYMONHOC( MAGV nvarchar(10),MAMH nvarchar(10)

constraint PK_GDM primary key (MAGV,MAMH)
);
GO






CREATE TABLE GVCN( MAGV nvarchar(10),MALOP nvarchar(5)

constraint pk_gvcn PRIMARY KEY (MAGV)
);
go

CREATE TABLE LUONG (BAC INT IDENTITY(1,1), HESOLUONG FLOAT,NAMLAMVIEC int

constraint pk_LUONG PRIMARY KEY (HESOLUONG)
)
go
CREATE TABLE PCLGVBM( MAGV nvarchar(10),MAMH nvarchar(10),MALOP NVARCHAR(5)

constraint PK_PCGVBM primary key (MAGV,MAMH,MALOP)
);
GO



CREATE TABLE CHUCVU( MACHUCVU nvarchar(10),TENCHUCVU nvarchar(100)
constraint PK_cv primary key (MACHUCVU)
);
go
CREATE TABLE NHANVIEN( MANV nvarchar(10),MACHUCVU nvarchar(10),TENNV nvarchar(100),NGAYSINH date,GIOITINH int, DIACHI nvarchar(50),NGAYVAOTRUONG date,NGAYLAM date,HESOLUONG float


constraint PK_cvVV primary key (MANV)
);
go
CREATE TABLE TAIKHOAN( TENDANGNHAP varchar(16),MATKHAU varchar(16),LoaiTK varchar, ma varchar
constraint PK_TK primary key (TENDANGNHAP)
);

go
CREATE TABLE HINHANH(MA char(15),hinh TEXT,
constraint PK_HINHANH primary key (MA)
);
go


-------------------Tao Khoa ngoai---------------------

ALTER table GVCN ADD constraint FK_GVCNLOP FOREIGN KEY (MALOP) REFERENCES LOP(MALOP)
ALTER TABLE DIEMHS ADD CONSTRAINT FK_DIEMHS FOREIGN KEY (MAHOCSINH) REFERENCES HOCSINH(MAHOCSINH)
ALTER table DIEMHS ADD constraint FK_DIEMHSMON FOREIGN KEY (MAMH) REFERENCES MONHOC(MAMH)
ALTER TABLE GVDAYMONHOC ADD CONSTRAINT FK_GDM2 FOREIGN KEY (MAMH) REFERENCES MONHOC(MAMH)
ALTER table PCLGVBM ADD constraint FK_PCGVBM2 FOREIGN KEY (MAMH) REFERENCES MONHOC(MAMH)
ALTER table PCLGVBM ADD constraint FK_PCGVBM3 FOREIGN KEY (MALOP) REFERENCES LOP(MALOP)
ALTER table GIAOVIEN ADD constraint FK_CVGV FOREIGN KEY (CHUCVU) REFERENCES CHUCVU(MACHUCVU)

ALTER TABLE HOCSINH ADD constraint FK_LOPPP foreign key (MALOP) REFERENCES LOP(MALOP)
ALTER TABLE LOP ADD constraint FK_LOPP FOREIGN KEY (KHOI) REFERENCES KHOI(SOKHOI)
ALTER TABLE MONHOC ADD constraint FK_MONHOC FOREIGN KEY (KHOI) REFERENCES KHOI(SOKHOI)
ALTER TABLE PCLGVBM ADD constraint FK_PCGVBM foreign key (MAGV) REFERENCES GIAOVIEN(MAGV)
ALTER TABLE NHANVIEN ADD constraint FK_CVV foreign key (MACHUCVU) REFERENCES CHUCVU(MACHUCVU)
ALTER TABLE GVCN ADD constraint FK_GVCN foreign key (MAGV) REFERENCES GIAOVIEN(MAGV)
ALTER TABLE GVDAYMONHOC ADD constraint FK_gdm foreign key (MAGV) REFERENCES GIAOVIEN(MAGV)
ALTER TABLE GIAOVIEN ADD constraint FK_LUONGGV FOREIGN KEY (HESOLUONG) REFERENCES LUONG(HESOLUONG)
------Them du lieu--------------
-- Phong ban
go 
INSERT INTO KHOI([SOKHOI])VALUES(10)
INSERT INTO KHOI([SOKHOI])VALUES(11)
INSERT INTO KHOI([SOKHOI])VALUES(12)



--môn học
---khối 10
go
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('T10',N'Toán 10',10)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('NV10',N'Ngữ Văn 10',10)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('TA10',N'Tiếng Anh 10',10)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('VL10',N'Vật Lý 10',10)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('H10',N'Hóa Học 10',10)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('S10',N'Sinh Học 10',10)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('LS10',N'Lịch Sử 10',10)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('GDCD10',N'Giáo Dục Công Dân 10',10)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('DL10',N'Địa Lí 10',10)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('TD10',N'Thể dục 10',10)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('CN10',N'Công Nghệ 10',10)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('IT10',N'Tin Học 10',10)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('HN10',N'Hướng Nghiệp 10',10)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('Q10',N'Giáo Dục Quốc Phòng 10',10)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('N',N'NGHỀ',11)

INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('T11',N'Toán 11',11)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('NV11',N'Ngữ Văn 11',11)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('TA11',N'Tiếng Anh 11',11)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('VL11',N'Vật Lý 11',11)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('H11',N'Hóa Học 11',11)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('S11',N'Sinh Học 11',11)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('LS11',N'Lịch Sử 11',11)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('GDCD11',N'Giáo Dục Công Dân 11',11)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('DL11',N'Địa Lí 11',11)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('TD11',N'Thể dục 11',11)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('CN11',N'Công Nghệ 11',11)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('IT11',N'Tin Học 11',11)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('HN11',N'Hướng Nghiệp 11',11)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('Q11',N'Giáo Dục Quốc Phòng 11',11)


INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('T12',N'Toán 12',12)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('NV12',N'Ngữ Văn 12',12)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('TA12',N'Tiếng Anh 12',12)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('VL12',N'Vật Lý 12',12)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('H12',N'Hóa Học 12',12)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('S12',N'Sinh Học 12',12)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('LS12',N'Lịch Sử 12',12)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('GDCD12',N'Giáo Dục Công Dân 12',12)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('DL12',N'Địa Lí 12',12)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('TD12',N'Thể dục 12',12)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('CN12',N'Công Nghệ 12',12)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('IT12',N'Tin Học 12',12)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('HN12',N'Hướng Nghiệp',12)
INSERT INTO MONHOC([MAMH], [TENMH],[KHOI])VALUES('Q12',N'Giáo Dục Quốc Phòng 12',12)
GO
ALTER table NHANVIEN ADD constraint FK_CVVVV FOREIGN KEY (HESOLUONG) REFERENCES LUONG(HESOLUONG)
INSERT INTO CHUCVU([MACHUCVU],[TENCHUCVU])VALUES ('HT',N'Hiệu Trưởng')
INSERT INTO CHUCVU([MACHUCVU],[TENCHUCVU])VALUES ('PHT',N'Phó Hiệu Trưởng')
INSERT INTO CHUCVU([MACHUCVU],[TENCHUCVU])VALUES ('YT',N'Y Tế')
INSERT INTO CHUCVU([MACHUCVU],[TENCHUCVU])VALUES ('BV',N'Bảo Vệ')
INSERT INTO CHUCVU([MACHUCVU],[TENCHUCVU])VALUES ('LC',N'Lao Công')
INSERT INTO CHUCVU([MACHUCVU],[TENCHUCVU])VALUES ('TT',N'Thủ Thư')
INSERT INTO CHUCVU([MACHUCVU],[TENCHUCVU])VALUES ('GVBM',N'Bộ Môn')
INSERT INTO CHUCVU([MACHUCVU],[TENCHUCVU])VALUES ('TB',N'Thiết Bị')
INSERT INTO CHUCVU([MACHUCVU],[TENCHUCVU])VALUES ('VP',N'Văn Phòng')
INSERT INTO CHUCVU([MACHUCVU],[TENCHUCVU])VALUES ('QLHS',N'Quản Lý Học Sinh')



GO

INSERT INTO LUONG([HESOLUONG],[NAMLAMVIEC]) VALUES (2.34,2)
INSERT INTO LUONG([HESOLUONG],[NAMLAMVIEC]) VALUES (2.67,4)
INSERT INTO LUONG([HESOLUONG],[NAMLAMVIEC]) VALUES (3,6)
INSERT INTO LUONG([HESOLUONG],[NAMLAMVIEC]) VALUES (3.33,8)
INSERT INTO LUONG([HESOLUONG],[NAMLAMVIEC]) VALUES (3.66,10)
INSERT INTO LUONG([HESOLUONG],[NAMLAMVIEC]) VALUES (3.99,12)
INSERT INTO LUONG([HESOLUONG],[NAMLAMVIEC]) VALUES (4.32,14)
INSERT INTO LUONG([HESOLUONG],[NAMLAMVIEC]) VALUES (4.65,16)
INSERT INTO LUONG([HESOLUONG],[NAMLAMVIEC]) VALUES (4.98,18)
go
select * from NHANVIEN n, CHUCVU c where n.MACHUCVU=c.MACHUCVU
			
insert into TAIKHOAN(TENDANGNHAP,MATKHAU,LoaiTK) values ('HS1','1',1)
insert into TAIKHOAN(TENDANGNHAP,MATKHAU,LoaiTK) values ('GV1','1',2)
insert into TAIKHOAN(TENDANGNHAP,MATKHAU,LoaiTK) values ('yi','1',3)

select * from HOCSINH where MAHOCSINH='HS1'
DELETE FROM NHANVIEN
DELETE FROM HINHANH
