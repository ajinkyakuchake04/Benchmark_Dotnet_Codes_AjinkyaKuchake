USE [OrganizationDB]
GO
/****** Object:  StoredProcedure [dbo].[InsertEmployee]    Script Date: 11/24/2021 11:55:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[InsertEmployee]
(@empno int,
@ename varchar(30),
@designation varchar(30),
@salary int)
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Employee (empno,ename,designation,salary) values (@empno,@ename,@designation,@salary)
END
