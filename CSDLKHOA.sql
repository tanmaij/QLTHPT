﻿use QLTHPT
GO

Insert into GIAOVIEN([MAGV],[TENGV],[NGAYSINH],[CHUCVU],[GIOITINH],[DIACHI],[NGAYVAOTRUONG],[NGAYDADAY],[HESOLUONG]) VALUES (N'01',N'Lux','11/05/1990',N'GVBM',1,N'Demacia', '08/23/2018','08/24/2018',2.34)

Insert into GIAOVIEN([MAGV],[TENGV],[NGAYSINH],[CHUCVU],[GIOITINH],[DIACHI],[NGAYVAOTRUONG],[NGAYDADAY],[HESOLUONG]) VALUES (N'02',N'Garen','07/07/1990',N'GVBM',0,N'Demacia', '03/04/2017','04/04/2019',2.34)
Insert into GIAOVIEN([MAGV],[TENGV],[NGAYSINH],[CHUCVU],[GIOITINH],[DIACHI],[NGAYVAOTRUONG],[NGAYDADAY],[HESOLUONG]) VALUES (N'03',N'Sona','05/19/1989',N'GVBM',1,N'Demacia', '05/05/2018','05/05/2018',2.34)


Insert into GIAOVIEN([MAGV],[TENGV],[NGAYSINH],[CHUCVU],[GIOITINH],[DIACHI],[NGAYVAOTRUONG],[NGAYDADAY],[HESOLUONG]) VALUES (N'04',N'Teemo','01/01/1987',N'GVBM',0,N'Bandle', '09/08/2017','09/08/2017',2.34)
Insert into GIAOVIEN([MAGV],[TENGV],[NGAYSINH],[CHUCVU],[GIOITINH],[DIACHI],[NGAYVAOTRUONG],[NGAYDADAY],[HESOLUONG]) VALUES (N'05',N'Kaisa','10/08/1985',N'GVBM',1,N'hư không', '12/09/2010','12/09/2010',2.34)
Insert into GIAOVIEN([MAGV],[TENGV],[NGAYSINH],[CHUCVU],[GIOITINH],[DIACHI],[NGAYVAOTRUONG],[NGAYDADAY],[HESOLUONG]) VALUES (N'06',N'Annie','09/09/1996',N'GVBM',1,N'Noxus', '10/10/2013','10/10/2013',2.34)

Insert into GIAOVIEN([MAGV],[TENGV],[NGAYSINH],[CHUCVU],[GIOITINH],[DIACHI],[NGAYVAOTRUONG],[NGAYDADAY],[HESOLUONG]) VALUES (N'07',N'Yuumi','12/12/1988',N'GVBM',1,N'Bandle', '10/11/2017','10/11/2017',2.34)



Insert into GIAOVIEN([MAGV],[TENGV],[NGAYSINH],[CHUCVU],[GIOITINH],[DIACHI],[NGAYVAOTRUONG],[NGAYDADAY],[HESOLUONG]) VALUES (N'08',N'Ezreal','09/08/1987',N'GVBM',0,N'Piltover', '08/01/2016','08/01/2016',2.34)

Insert into GIAOVIEN([MAGV],[TENGV],[NGAYSINH],[CHUCVU],[GIOITINH],[DIACHI],[NGAYVAOTRUONG],[NGAYDADAY],[HESOLUONG]) VALUES (N'09',N'Master Yi','06/03/1989',N'GVBM',0,N'Lonoa', '12/11/2017','12/11/1017',2.34)


Insert into GIAOVIEN([MAGV],[TENGV],[NGAYSINH],[CHUCVU],[GIOITINH],[DIACHI],[NGAYVAOTRUONG],[NGAYDADAY],[HESOLUONG]) VALUES (N'10',N'Ashe','02/01/1979',N'GVBM',1,N'Freljord', '07/10/2011','07/10/2011',2.34)


go






Insert into lop([MALOP],[khoi]) VALUES (N'A1',12)
go
insert into GVCN([MAGV],[MALOP]) VALUES (N'01',N'A1')
go

Insert into HOCSINH([MAHOCSINH],[HOTEN],[NGAYSINH],[GIOITINH],[DIACHI],[MALOP]) VALUES (N'001',N'Lucian','01/02/2003',0,N'Demacia',N'A1')


Insert into HOCSINH([MAHOCSINH],[HOTEN],[NGAYSINH],[GIOITINH],[DIACHI],[MALOP]) VALUES (N'002',N'Leona','02/11/2003',1,N'Targon',N'A1')

Insert into HOCSINH([MAHOCSINH],[HOTEN],[NGAYSINH],[GIOITINH],[DIACHI],[MALOP]) VALUES (N'003',N'Nasus','06/09/2003',0,N'Shurima',N'A1')

Insert into HOCSINH([MAHOCSINH],[HOTEN],[NGAYSINH],[GIOITINH],[DIACHI],[MALOP]) VALUES (N'004',N'Shyvana','03/10/2003',1,N'Demacia',N'A1')

Insert into HOCSINH([MAHOCSINH],[HOTEN],[NGAYSINH],[GIOITINH],[DIACHI],[MALOP]) VALUES (N'005',N'Sylas','12/03/2003',0,N'Demacia',N'A1')


GO
select * from HOCSINH
select *from lop
Insert into GVCN([MAGV],MALOP) VALUES  ( N'07',N'A2')


Insert into lop([MALOP],[khoi]) VALUES (N'A2',11)
GO
Insert into HOCSINH([MAHOCSINH],[HOTEN],[NGAYSINH],[GIOITINH],[DIACHI],[MALOP]) VALUES (N'006',N'Ahri','08/08/2004',0,N'Lonia',N'A2')

Insert into HOCSINH([MAHOCSINH],[HOTEN],[NGAYSINH],[GIOITINH],[DIACHI],[MALOP]) VALUES (N'007',N'Fizz','06/09/2004',0,N'Bilgewater',N'A2')

Insert into HOCSINH([MAHOCSINH],[HOTEN],[NGAYSINH],[GIOITINH],[DIACHI],[MALOP]) VALUES (N'008',N'Graves','10/07/2004',0,N'Bilgewater',N'A2')

Insert into HOCSINH([MAHOCSINH],[HOTEN],[NGAYSINH],[GIOITINH],[DIACHI],[MALOP]) VALUES (N'009',N'Irelia','12/11/2004',1,N'Lonia',N'A2')

Insert into HOCSINH([MAHOCSINH],[HOTEN],[NGAYSINH],[GIOITINH],[DIACHI],[MALOP]) VALUES (N'010',N'Jinx','09/13/2004',1,N'Zaun',N'A2')
go

select * from GIAOVIEN

go
Insert into lop([MALOP],[khoi]) VALUES (N'10A1',10)


Insert into GIAOVIEN([MAGV],[TENGV],[NGAYSINH],[CHUCVU],[GIOITINH],[DIACHI],[NGAYVAOTRUONG],[NGAYDADAY],[HESOLUONG]) VALUES (N'06',N'Annie','09/09/1996',N'GVBM',1,N'Noxus', '10/10/2013','10/10/2013',2.94)
insert into GVCN(MAGV,MALOP) VALUES (N'06',N'10A1')
Insert into HOCSINH([MAHOCSINH],[HOTEN],[NGAYSINH],[GIOITINH],[DIACHI],[MALOP]) VALUES (N'011',N'Darius','04/04/2005',0,N'Noxus',N'10A1')

Insert into HOCSINH([MAHOCSINH],[HOTEN],[NGAYSINH],[GIOITINH],[DIACHI],[MALOP]) VALUES (N'012',N'Jarvan IV','06/17/2005',0,N'Demacia',N'10A1')

Insert into HOCSINH([MAHOCSINH],[HOTEN],[NGAYSINH],[GIOITINH],[DIACHI],[MALOP]) VALUES (N'013',N'Katarina','03/09/2005',1,N'Noxus',N'10A1')

Insert into HOCSINH([MAHOCSINH],[HOTEN],[NGAYSINH],[GIOITINH],[DIACHI],[MALOP]) VALUES (N'014',N'Jhin','07/10/2005',0,N'LMHT',N'10A1')

Insert into HOCSINH([MAHOCSINH],[HOTEN],[NGAYSINH],[GIOITINH],[DIACHI],[MALOP]) VALUES (N'015',N'Morgana','10/12/2005',1,N'Noxus',N'10A1')

SELECT count(MAGV) from GIAOVIEN
go 
Insert into lop([MALOP],[khoi]) VALUES (N'Null',10)
delete from HINHANH where MA='NV1'
ins