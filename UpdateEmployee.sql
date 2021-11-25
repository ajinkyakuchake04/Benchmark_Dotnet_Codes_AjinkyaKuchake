USE [OrganizationDB]
GO
/****** Object:  StoredProcedure [dbo].[UpdateEmployee]    Script Date: 11/24/2021 11:55:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[UpdateEmployee]
(@empno int,
@ename varchar(30),
@designation varchar(30),
@salary int)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Employee set ename = @ename, designation = @designation, salary = @salary where empno = @empno
END
