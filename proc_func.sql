
-- proc ThemHocVien
CREATE PROCEDURE [dbo].[proc_ThemHocVien](@ten nvarchar(50), @gioitinh varchar(5), @diachi varchar(100), @ngaysinh date, @sdt varchar(15),
											@email varchar(30), @user varchar(20), @pass varchar(20))
AS
BEGIN
	DECLARE @mahocvien int;
	SET @mahocvien = (SELECT MAX(MAHOCVIEN) FROM [dbo].[HOCVIEN]) + 1;
	INSERT INTO [dbo].[HOCVIEN](MAHOCVIEN, TENHOCVIEN, GIOITINH, DIACHI, NGAYSINH, SDT, EMAIL, USERNAME, PASSWORD)
	VALUES(@mahocvien, @ten, @gioitinh, @diachi, @ngaysinh, @sdt, @email, @user, @pass) 
END

--func KTraUsernameHopLe
CREATE FUNCTION [dbo].[KTraUsernameHopLe](@user VARCHAR(20))
RETURNS int
AS
BEGIN
	DECLARE @rs int
	SELECT @rs = COUNT(USERNAME) FROM HOCVIEN WHERE USERNAME = @user

	RETURN @rs
END