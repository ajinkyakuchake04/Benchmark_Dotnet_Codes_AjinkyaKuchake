USE [OrganizationDB]
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeeDetailsUsingEmpno]    Script Date: 11/24/2021 11:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[GetEmployeeDetailsUsingEmpno]
(@eno int)
AS
BEGIN
	select * from Employee where empno = @eno 
END
