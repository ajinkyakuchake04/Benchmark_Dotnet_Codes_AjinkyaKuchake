USE [OrganizationDB]
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeeDetails]    Script Date: 11/24/2021 11:53:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[GetEmployeeDetails]
AS
BEGIN
	select * from Employee
END
