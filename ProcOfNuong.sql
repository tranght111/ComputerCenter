-- view xem ds khoa hoc
Create Or Alter view DSKhoaHoc
as
	select kh.MAKHOAHOC, kh.TENKHOAHOC,l.TENLOAIKHOAHOC, kh.SOLUONGTOIDA, kh.HOCPHI, kh.THOIGIANBATDAU, kh.MOTA
	from KHOAHOC kh, LOAIKHOAHOC l
	where kh.MALOAI = l.MALOAI;
go

-- proc xem ds nhom hoc phan theo KH
Create or Alter Proc proc_DSNhomHPcuaKH(@makh int)
as
Begin
		select n.MANHOM, n.TENNHOM
		from NHOMHOCPHAN n
		where n.MAKHOAHOC = @makh
End
go

-- DS Mon hoc theo Khoa hoc va Nhom HP
Create Or Alter Proc proc_DSMonHoctheoMaKH_MaNhomHP(@makh int, @manhom int)
As
Begin
	select m.MALOP, m.TENLOP, m.HOCPHI, m.NGAYBATDAU, m.GIOHOC, g.TENGV
	from NHOMHOCPHAN n, NHOMHOCPHAN_MONHOC nm, MONHOC m, GIANGVIEN g
	where n.MAKHOAHOC = @makh and n.MANHOM = @manhom and n.MANHOM = nm.MANHOM and nm.MALOP = m.MALOP and m.MAGV = g.MAGV
End
go
exec proc_DSMonHoctheoMaKH_MaNhomHP 1,2
go

-- Xem DS mon hoc cua nhom HP
Create Or Alter Proc proc_DSMonHocCuaNhomHP(@manhom int)
as
Begin
	select mh.TENLOP
	from MONHOC mh, NHOMHOCPHAN_MONHOC nm
	where @manhom = nm.MANHOM and nm.MALOP = mh.MALOP
End
go

-- Xem DS lop hoc theo MaKH
Create Or Alter Proc proc_DSLopHocCuaKhoaHoc(@makh int)
as
Begin
	select n.TENNHOM, mh.TENLOP, mh.HOCPHI, mh.NGAYBATDAU, mh.GIOHOC, gv.TENGV
	from MONHOC mh, NHOMHOCPHAN_MONHOC nm, NHOMHOCPHAN n, GIANGVIEN gv
	where n.MAKHOAHOC = @makh and n.MANHOM = nm.MANHOM and nm.MALOP = mh.MALOP and mh.MAGV = gv.MAGV
End
go



--DS tat ca HV phuc khao diem KTHP
Create Or Alter View view_DSHVPhucKhaoDiemKTHP
As
	select p.MAPHIEUPHUCKHAO_DIEMKTHP as MAPHIEU, h.MAHOCVIEN, h.TENHOCVIEN, h.GIOITINH, h.NGAYSINH, h.DIACHI, h.EMAIL
	from PHIEUPHUCKHAO_DIEMKTHP p, HOCVIEN h
	where p.MAHOCVIEN = h.MAHOCVIEN
go

--DS HV phuc khao diem KTHP theo ma KH
Create Or Alter Proc proc_DSHVPhucKhaoDiemKTHPtheoKH(@makh int)
As
Begin
	select distinct d.MAPHIEUPHUCKHAO_DIEMKTHP as MAPHIEU, h.MAHOCVIEN, h.TENHOCVIEN, h.GIOITINH, h.NGAYSINH, h.DIACHI, h.EMAIL
	from NHOMHOCPHAN n, NHOMHOCPHAN_MONHOC nm, HOCVIEN h, PHIEUPHUCKHAO_DIEMKTHP d
	where n.MAKHOAHOC = @makh and n.MANHOM = nm.MANHOM and nm.MALOP = d.MALOP and d.MAHOCVIEN = h.MAHOCVIEN
End
go

--DS HV phuc khao diem KTHP theo ma KH, ma nhom HP
Create Or Alter Proc proc_DSHVPhucKhaoDiemKTHPtheoKH_NhomHP(@makh int, @manhom int)
As
Begin
	select distinct d.MAPHIEUPHUCKHAO_DIEMKTHP as MAPHIEU, h.MAHOCVIEN, h.TENHOCVIEN, h.GIOITINH, h.NGAYSINH, h.DIACHI, h.EMAIL
	from NHOMHOCPHAN n, NHOMHOCPHAN_MONHOC nm, HOCVIEN h, PHIEUPHUCKHAO_DIEMKTHP d
	where n.MAKHOAHOC = @makh and d.MANHOM = @manhom and n.MANHOM = nm.MANHOM and nm.MALOP = d.MALOP and d.MAHOCVIEN = h.MAHOCVIEN
End
go

--DS HV phuc khao diem KTHP theo ma KH, ma nhom HP, ma Lop
Create Or Alter Proc proc_DSHVPhucKhaoDiemKTHPtheoKH_NhomHP_MaLop(@makh int, @manhom int, @malop int)
As
Begin
	select distinct d.MAPHIEUPHUCKHAO_DIEMKTHP as MAPHIEU, h.MAHOCVIEN, h.TENHOCVIEN, h.GIOITINH, h.NGAYSINH, h.DIACHI, h.EMAIL
	from NHOMHOCPHAN n, NHOMHOCPHAN_MONHOC nm, HOCVIEN h, PHIEUPHUCKHAO_DIEMKTHP d
	where n.MAKHOAHOC = @makh and d.MANHOM = @manhom and d.MALOP = @malop and n.MANHOM = nm.MANHOM and nm.MALOP = d.MALOP and d.MAHOCVIEN = h.MAHOCVIEN
End
go

--DS tat ca hoc vien phuc khao diem tot nghiep
Create Or Alter View View_DSHocVienPhucKhaoDiemTN
As
	select p.MAPHIEUPHUCKHAO_DIEMTN as MAPHIEU, h.MAHOCVIEN, h.TENHOCVIEN, h.GIOITINH, h.NGAYSINH, h.DIACHI, h.EMAIL
	from PHIEUPHUCKHAO_TN p, HOCVIEN h
	where p.MAHOCVIEN = h.MAHOCVIEN;
go

-- DS hoc vien phuc khao diem tot nghiep theo khoa hoc
Create Or Alter Proc proc_DSHocVienPhucKhaoDiemTNTheoKH(@makh int)
As
Begin
	select p.MAPHIEUPHUCKHAO_DIEMTN as MAPHIEU, h.MAHOCVIEN, h.TENHOCVIEN, h.GIOITINH, h.NGAYSINH, h.DIACHI, h.EMAIL
	from PHIEUPHUCKHAO_TN p, HOCVIEN h
	where p.MAKHOAHOC = @makh and p.MAHOCVIEN = h.MAHOCVIEN
End
Go

-- view xem ds tat ca hoc vien
Create Or Alter View view_AllHocVien
as
	select h.MAHOCVIEN, h.TENHOCVIEN, h.GIOITINH, h.NGAYSINH, h.DIACHI, h.EMAIL
	from HOCVIEN h
go


-- Lay ds hoc vien theo ma KH
Create Or Alter Proc proc_DSHVtheoMaKH(@makh int)
As
Begin
	select distinct h.MAHOCVIEN, h.TENHOCVIEN, h.GIOITINH, h.NGAYSINH, h.DIACHI, h.EMAIL
	from NHOMHOCPHAN n, NHOMHOCPHAN_MONHOC nm, DIEMTHIKTHP d, HOCVIEN h
	where n.MAKHOAHOC = @makh and n.MANHOM = nm.MANHOM and nm.MALOP = d.MALOP and d.MAHOCVIEN = h.MAHOCVIEN
End
go


Create Or Alter Proc proc_DSHVtheoMaKHvaMaNhomHP(@makh int, @manhom int)
as
Begin
	select distinct h.MAHOCVIEN, h.TENHOCVIEN, h.GIOITINH, h.NGAYSINH, h.DIACHI, h.EMAIL
	from NHOMHOCPHAN n, NHOMHOCPHAN_MONHOC nm, DIEMTHIKTHP d, HOCVIEN h
	where n.MAKHOAHOC = @makh and d.MANHOM = @manhom and n.MANHOM = nm.MANHOM and nm.MALOP = d.MALOP and d.MAHOCVIEN = h.MAHOCVIEN
End
go

Create Or Alter Proc proc_DSHVtheoMaKH_MaNhomHP_MaLop(@makh int, @manhom int, @malop int)
as
Begin
	select distinct h.MAHOCVIEN, h.TENHOCVIEN, h.GIOITINH, h.NGAYSINH, h.DIACHI, h.EMAIL
	from NHOMHOCPHAN n, NHOMHOCPHAN_MONHOC nm, DIEMTHIKTHP d, HOCVIEN h
	where n.MAKHOAHOC = @makh and d.MANHOM = @manhom and d.MALOP = @malop and n.MANHOM = nm.MANHOM and nm.MALOP = d.MALOP and d.MAHOCVIEN = h.MAHOCVIEN
End
go

--Lay thong tin role cua user
Create Or Alter Proc proc_GetRoleOfUser(@username varchar(20))
As
Begin
	select t.ROLE
	from dbo.TAIKHOAN t
	where t.USERNAME = @username
End
go

--Lay so luong hoc vien da dang ky khoa hoc
Create Or Alter Proc proc_SLHocVienDKKhoaHoc(@makh int)
as
Begin
	select COUNT(d.MAHOCVIEN) as SL
	from KHOAHOC k, DANGKYKHOAHOC d
	where k.MAKHOAHOC = @makh and k.MAKHOAHOC = d.MAKHOAHOC
End
go
exec proc_SLHocVienDKKhoaHoc 4