USE [OrganizationDB]
GO
/****** Object:  StoredProcedure [dbo].[DeleteEmployee]    Script Date: 11/24/2021 11:52:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DeleteEmployee]
(@empno int)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from Employee where empno = @empno 	
END
