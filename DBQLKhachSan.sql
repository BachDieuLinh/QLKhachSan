USE [QLKhachSan]
GO
/****** Object:  Table [dbo].[tblCTHD]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCTHD](
	[MaHDCT] [nvarchar](10) NOT NULL,
	[MaPhong] [nvarchar](10) NOT NULL,
	[MaDV] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[TongTien] [bigint] NULL,
 CONSTRAINT [PK_tblCTHD_1] PRIMARY KEY CLUSTERED 
(
	[MaHDCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDangNhap]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDangNhap](
	[Username] [varchar](50) NOT NULL,
	[Pass] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblDichVu]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDichVu](
	[MaDV] [nvarchar](10) NOT NULL,
	[TenDV] [nvarchar](50) NULL,
	[Gia] [float] NULL,
	[DonViTinh] [nvarchar](10) NULL,
 CONSTRAINT [PK_tblDichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDoDung]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDoDung](
	[MaDoDung] [nvarchar](10) NOT NULL,
	[TenDoDung] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[DonViTinh] [nvarchar](10) NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[MaPhong] [nvarchar](10) NULL,
 CONSTRAINT [PK_tblDoDung] PRIMARY KEY CLUSTERED 
(
	[MaDoDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHoaDon]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblHoaDon](
	[MaHD] [nvarchar](10) NOT NULL,
	[MaHDCT] [nvarchar](10) NULL,
	[MaKH] [nvarchar](10) NULL,
	[MaNV] [nvarchar](50) NULL,
	[NgayLapHD] [varchar](50) NULL,
 CONSTRAINT [PK_tblHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblKhachThuePhong]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblKhachThuePhong](
	[MaKH] [nvarchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[GT] [nvarchar](3) NULL,
	[NgaySinh] [date] NULL,
	[CMND] [varchar](20) NULL,
 CONSTRAINT [PK_tblKhachThuePhong] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[MaNV] [varchar](10) NULL,
	[TenNV] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[SDT] [nchar](20) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPhong]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhong](
	[MaPhong] [nvarchar](10) NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
	[LoaiPhong] [nvarchar](10) NULL,
 CONSTRAINT [PK_tblPhong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[tblCTHD] ([MaHDCT], [MaPhong], [MaDV], [SoLuong], [TongTien]) VALUES (N'CT001', N'PH101', N'DV002', NULL, 200000)
INSERT [dbo].[tblCTHD] ([MaHDCT], [MaPhong], [MaDV], [SoLuong], [TongTien]) VALUES (N'CT002', N'PH102', N'DV005', NULL, 320000)
INSERT [dbo].[tblCTHD] ([MaHDCT], [MaPhong], [MaDV], [SoLuong], [TongTien]) VALUES (N'CT003', N'PH103', N'DV001', NULL, 50000)
INSERT [dbo].[tblCTHD] ([MaHDCT], [MaPhong], [MaDV], [SoLuong], [TongTien]) VALUES (N'CT004', N'PH201', N'DV003', NULL, 300000)
INSERT [dbo].[tblCTHD] ([MaHDCT], [MaPhong], [MaDV], [SoLuong], [TongTien]) VALUES (N'CT005', N'PH202', N'DV002', NULL, 400000)
INSERT [dbo].[tblDangNhap] ([Username], [Pass]) VALUES (N'Linheve@gmail.com', N'123456')
INSERT [dbo].[tblDangNhap] ([Username], [Pass]) VALUES (N'HuyenB41@gmail.com', N'123456')
INSERT [dbo].[tblDichVu] ([MaDV], [TenDV], [Gia], [DonViTinh]) VALUES (N'DV001', N'Giặt ủi', 5000, N'Kg')
INSERT [dbo].[tblDichVu] ([MaDV], [TenDV], [Gia], [DonViTinh]) VALUES (N'DV002', N'Xông hơi', 100000, N'Lần')
INSERT [dbo].[tblDichVu] ([MaDV], [TenDV], [Gia], [DonViTinh]) VALUES (N'DV003', N'Massage', 200000, N'Giờ')
INSERT [dbo].[tblDichVu] ([MaDV], [TenDV], [Gia], [DonViTinh]) VALUES (N'DV004', N'Karaoke', 100000, N'Giờ')
INSERT [dbo].[tblDichVu] ([MaDV], [TenDV], [Gia], [DonViTinh]) VALUES (N'DV005', N'Suất ăn', 80000, N'Suất')
INSERT [dbo].[tblDoDung] ([MaDoDung], [TenDoDung], [SoLuong], [DonViTinh], [TinhTrang], [MaPhong]) VALUES (N'DD001', N'Gối', 2, N'cái', N'Mới', N'PH102')
INSERT [dbo].[tblDoDung] ([MaDoDung], [TenDoDung], [SoLuong], [DonViTinh], [TinhTrang], [MaPhong]) VALUES (N'DD002', N'Chăn', 1, N'cái', N'Mới', N'PH101')
INSERT [dbo].[tblDoDung] ([MaDoDung], [TenDoDung], [SoLuong], [DonViTinh], [TinhTrang], [MaPhong]) VALUES (N'DD003', N'Grap trải giường', 1, N'cái', N'Mới ', N'PH201')
INSERT [dbo].[tblDoDung] ([MaDoDung], [TenDoDung], [SoLuong], [DonViTinh], [TinhTrang], [MaPhong]) VALUES (N'DD004', N'Tivi', 1, N'cái', N'Đã sử dụng', N'PH202')
INSERT [dbo].[tblDoDung] ([MaDoDung], [TenDoDung], [SoLuong], [DonViTinh], [TinhTrang], [MaPhong]) VALUES (N'DD005', N'Điều hòa', 1, N'cái', N'Đã sử dụng', N'PH103')
INSERT [dbo].[tblHoaDon] ([MaHD], [MaHDCT], [MaKH], [MaNV], [NgayLapHD]) VALUES (N'HD001', N'CT001', N'KH00000003', N'NV003', N'12/4/2015 12:50:22 AM')
INSERT [dbo].[tblHoaDon] ([MaHD], [MaHDCT], [MaKH], [MaNV], [NgayLapHD]) VALUES (N'HD002', N'CT001', N'KH00000003', N'NV003', N'12/4/2015 12:50:16 AM')
INSERT [dbo].[tblHoaDon] ([MaHD], [MaHDCT], [MaKH], [MaNV], [NgayLapHD]) VALUES (N'NV002', N'CT001', N'KH00000002', N'NV002', N'12/4/2015 12:48:46 AM')
INSERT [dbo].[tblKhachThuePhong] ([MaKH], [TenKH], [GT], [NgaySinh], [CMND]) VALUES (N'KH00000001', N'Trần Trung Kiên', N'Nam', CAST(N'1994-11-23' AS Date), N'14235767967')
INSERT [dbo].[tblKhachThuePhong] ([MaKH], [TenKH], [GT], [NgaySinh], [CMND]) VALUES (N'KH00000002', N'Trần Trung', N'Nam', CAST(N'1994-11-23' AS Date), N'14235767967')
INSERT [dbo].[tblKhachThuePhong] ([MaKH], [TenKH], [GT], [NgaySinh], [CMND]) VALUES (N'KH00000003', N'Phạm Văn Lượng', N'Nam', CAST(N'1994-11-04' AS Date), N'164531004')
INSERT [dbo].[tblKhachThuePhong] ([MaKH], [TenKH], [GT], [NgaySinh], [CMND]) VALUES (N'KH00000004', N'Lê Tiến Dũng', N'Nam', CAST(N'1994-11-11' AS Date), N'232342344')
INSERT [dbo].[tblKhachThuePhong] ([MaKH], [TenKH], [GT], [NgaySinh], [CMND]) VALUES (N'KH00000005', N'Đoàn Quang Long', N'Nam', CAST(N'1994-02-14' AS Date), N'123123123')
INSERT [dbo].[tblKhachThuePhong] ([MaKH], [TenKH], [GT], [NgaySinh], [CMND]) VALUES (N'KH00000006', N'Nguyễn Hòa Nhập Quang', N'Nam', CAST(N'1994-11-23' AS Date), N'14235767967')
INSERT [dbo].[tblKhachThuePhong] ([MaKH], [TenKH], [GT], [NgaySinh], [CMND]) VALUES (N'KH00000007', N'Bạch Thị Diệu Linh', N'Nữ', CAST(N'1994-12-19' AS Date), N'343311227')
INSERT [dbo].[tblKhachThuePhong] ([MaKH], [TenKH], [GT], [NgaySinh], [CMND]) VALUES (N'KH00000008', N'Trần Thị Huyền ', N'Nữ', CAST(N'1994-04-25' AS Date), N'329988182')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [ChucVu], [SDT]) VALUES (N'NV001', N'Lê Thị Huyền Anh', N'Nhan Viên', N'097818543           ')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [ChucVu], [SDT]) VALUES (N'NV002', N'Phan Thị Bích Hằng', N'Nhân Viên', N'012354546           ')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [ChucVu], [SDT]) VALUES (N'NV003', N'Trần Trung Đức', N'Nhân Viên', N'084879045           ')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [ChucVu], [SDT]) VALUES (N'NV004', N'Hà Anh Đức', N'Nhân viên', N'0847507443          ')
INSERT [dbo].[tblPhong] ([MaPhong], [TenPhong], [LoaiPhong]) VALUES (N'PH101', N'101', N'Bình dân')
INSERT [dbo].[tblPhong] ([MaPhong], [TenPhong], [LoaiPhong]) VALUES (N'PH102', N'102', N'Bình dân')
INSERT [dbo].[tblPhong] ([MaPhong], [TenPhong], [LoaiPhong]) VALUES (N'PH103', N'103', N'Bình dân')
INSERT [dbo].[tblPhong] ([MaPhong], [TenPhong], [LoaiPhong]) VALUES (N'PH201', N'201', N'VIP')
INSERT [dbo].[tblPhong] ([MaPhong], [TenPhong], [LoaiPhong]) VALUES (N'PH202', N'202', N'VIP')
ALTER TABLE [dbo].[tblCTHD]  WITH CHECK ADD  CONSTRAINT [FK_tblCTHD_tblDichVu] FOREIGN KEY([MaDV])
REFERENCES [dbo].[tblDichVu] ([MaDV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tblCTHD] CHECK CONSTRAINT [FK_tblCTHD_tblDichVu]
GO
ALTER TABLE [dbo].[tblCTHD]  WITH CHECK ADD  CONSTRAINT [FK_tblCTHD_tblPhong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[tblPhong] ([MaPhong])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[tblCTHD] CHECK CONSTRAINT [FK_tblCTHD_tblPhong]
GO
ALTER TABLE [dbo].[tblDoDung]  WITH CHECK ADD  CONSTRAINT [FK_tblDoDung_tblPhong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[tblPhong] ([MaPhong])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblDoDung] CHECK CONSTRAINT [FK_tblDoDung_tblPhong]
GO
ALTER TABLE [dbo].[tblHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDon_tblCTHD] FOREIGN KEY([MaHDCT])
REFERENCES [dbo].[tblCTHD] ([MaHDCT])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tblHoaDon] CHECK CONSTRAINT [FK_tblHoaDon_tblCTHD]
GO
ALTER TABLE [dbo].[tblHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDon_tblKhachThuePhong] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tblKhachThuePhong] ([MaKH])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblHoaDon] CHECK CONSTRAINT [FK_tblHoaDon_tblKhachThuePhong]
GO
/****** Object:  StoredProcedure [dbo].[ADDKhachThuePhong]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ADDKhachThuePhong] (@TenKH nvarchar(50), @GT nvarchar(3), @NgaySinh date, @CMND varchar(20))
AS 
BEGIN
	DECLARE @MaKH nchar(10)
	DECLARE @sott int
	DECLARE contro CURSOR FORWARD_ONLY FOR SELECT MaKH FROM tblKhachThuePhong
	SET @sott = 0
	
	OPEN contro
	FETCH NEXT FROM contro INTO @MaKH
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		IF((CAST(right(@MaKH, 8) AS int) - @sott) = 1)
		BEGIN
			SET @sott = CAST(right(@MaKH, 8) AS int)
		END
	ELSE BREAK
	FETCH NEXT FROM contro INTO @MaKH
END

DECLARE @cdai int
DECLARE @i int
SET @MaKH = CAST((@sott + 1) as nchar(8))
SET @cdai = LEN(@MaKH)
SET @i = 1
while ( @i <= 8 - @cdai)
BEGIN
	SET @MaKH = '0' + @MaKH
	SET @i = @i + 1
END
SET @MaKH = 'KH' + @MaKH

INSERT INTO tblKhachThuePhong values ( @MaKH, @TenKH, @GT, @NgaySinh,@CMND)
SELECT @MaKH
CLOSE contro
DEALLOCATE contro
END

GO
/****** Object:  StoredProcedure [dbo].[ADDPhong]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ADDPhong] (@TenPhong nvarchar(50), @LoaiPhong nvarchar(10))
AS 
BEGIN
	DECLARE @MaPhong nchar(10)
	DECLARE @sott int
	DECLARE contro CURSOR FORWARD_ONLY FOR SELECT MaPhong FROM tblPhong
	SET @sott = 0
	
	OPEN contro
	FETCH NEXT FROM contro INTO @MaPhong
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		IF((CAST(right(@MaPhong, 8) AS int) - @sott) = 1)
		BEGIN
			SET @sott = CAST(right(@MaPhong, 8) AS int)
		END
	ELSE BREAK
	FETCH NEXT FROM contro INTO @MaPhong
END

DECLARE @cdai int
DECLARE @i int
SET @MaPhong = CAST((@sott + 1) as nchar(8))
SET @cdai = LEN(@MaPhong)
SET @i = 1
while ( @i <= 8 - @cdai)
BEGIN
	SET @MaPhong = '0' + @MaPhong
	SET @i = @i + 1
END
SET @MaPhong = 'PH' + @MaPhong

INSERT INTO tblPhong values ( @MaPhong, @TenPhong, @LoaiPhong)
SELECT @MaPhong
CLOSE contro
DEALLOCATE contro
END

GO
/****** Object:  StoredProcedure [dbo].[HD]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[HD] (@MaHD varchar(10),@MaCTHD varchar(10),@MaKH varchar(10),@MaNV varchar(10), @NgayLapHD varchar(50))
AS 
BEGIN
	

INSERT INTO tblHoaDon values (@MaHD ,@MaCTHD,@MaKH,@MaNV , @NgayLapHD)
END

GO
/****** Object:  StoredProcedure [dbo].[Ins_HD]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[Ins_HD] (@MaHD varchar(10),@MaCTHD varchar(10),@MaKH varchar(10),@MaNV varchar(10), @NgayLapHD varchar(50))
AS 
BEGIN
	

INSERT INTO tblHoaDon values (@MaHD ,@MaCTHD,@MaKH,@MaNV , @NgayLapHD)
END

GO
/****** Object:  StoredProcedure [dbo].[login]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[login] @Username varchar(50), @Pass varchar(50)
as
begin
	select * from tblDangNhap where (Username = @Username and Pass = @Pass)
end


GO
/****** Object:  StoredProcedure [dbo].[SuaDoDung]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaDoDung](@MaDoDung nvarchar(10), @TenDoDung nvarchar(50), @SoLuong int, @DonViTinh nvarchar(10), @TinhTrang nvarchar(10), @MaPhong nvarchar(10))
AS
BEGIN
	UPDATE tblDoDung SET TenDoDung=@TenDoDung, SoLuong=@SoLuong, DonViTinh=@DonViTinh, TinhTrang=@TinhTrang, MaPhong=@MaPhong
					WHERE MaDoDung=@MaDoDung
END
GO
/****** Object:  StoredProcedure [dbo].[SuaKhachThuePhong]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaKhachThuePhong](@MaKH nvarchar(10), @TenKH nvarchar(50), @GT nvarchar(3), @NgaySinh date, @CMND varchar(20))
AS
BEGIN
	UPDATE tblKhachThuePhong SET TenKH=@TenKH, GT=@GT, NgaySinh=@NgaySinh, CMND=@CMND
							WHERE MaKH=@MaKH
END
GO
/****** Object:  StoredProcedure [dbo].[SuaPhong]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaPhong](@MaPhong nvarchar(10), @TenPhong nvarchar(50), @LoaiPhong nvarchar(10))
AS
BEGIN
	UPDATE tblPhong SET TenPhong=@TenPhong, LoaiPhong=@LoaiPhong
					WHERE MaPhong=@MaPhong
END
GO
/****** Object:  StoredProcedure [dbo].[SuaTBTB]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SuaTBTB](@MaPhong nvarchar(10),@MaDoDung nvarchar(10),@SoLuong int,@kq int output)
as
begin
	if(@MaPhong='' or @MaDoDung='' or @SoLuong=0) set @kq=0
	else 
	if(@MaPhong not in (select MaPhong from tblDoDung))set @kq=3
		else
				if((@MaDoDung not in(select MaDoDung from tblDoDung)) or (@MaDoDung not in (select MaDoDung from tblDoDung where MaPhong=@MaPhong)))set @kq=1
			else
				begin 
					update tblDoDung
					set SoLuong=@soluong
					where MaPhong=@MaPhong and MaDoDung=@MaDoDung
					set @kq=2
				end
end
GO
/****** Object:  StoredProcedure [dbo].[TimKiemTBTB]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TimKiemTBTB](@MaPhong nvarchar(10),@MaDoDung nvarchar(10),@chose int)
as
begin
	if(@chose=1)
	begin
		select * from tblDoDung where MaPhong=@MaPhong
	end
	else
	if(@chose=2)
	begin
		select * from tblDoDung where MaDoDung=@MaDoDung
	end
end
GO
/****** Object:  StoredProcedure [dbo].[Xoa_DoDung]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Xoa_DoDung](@MaDoDung nvarchar(10))
AS
BEGIN
	DELETE FROM tblDoDung WHERE MaDoDung=@MaDoDung
END
GO
/****** Object:  StoredProcedure [dbo].[Xoa_KhachThuePhong]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Xoa_KhachThuePhong](@MaKH nvarchar(10))
AS
BEGIN
	DELETE FROM tblKhachThuePhong WHERE MaKH=@MaKH
END
GO
/****** Object:  StoredProcedure [dbo].[Xoa_Phong]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Xoa_Phong](@MaPhong nvarchar(10))
AS
BEGIN
	DELETE FROM tblPhong WHERE MaPhong=@MaPhong
END
GO
/****** Object:  StoredProcedure [dbo].[XoaTBTB]    Script Date: 12/4/2015 1:07:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[XoaTBTB](@MaPhong nvarchar(10),@MaDoDung nvarchar(10),@kq int output)
as
begin
	if(@MaPhong='' or @MaDoDung='') set @kq=0
	else
		if(@MaPhong not in (select MaPhong from tblDoDung))set @kq=1
		else 
			if(@MaDoDung not in (select MaDoDung from tblDoDung where MaPhong=@MaPhong)) set @kq=3
		else
		begin
			delete from tblDoDung where MaPhong=@MaPhong and MaDoDung=@MaDoDung
			set @kq=2
		end
end
GO
USE [master]
GO
ALTER DATABASE [QLKhachSan] SET  READ_WRITE 
GO
