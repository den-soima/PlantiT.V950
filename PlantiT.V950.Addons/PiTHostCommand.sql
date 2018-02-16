 --    
DECLARE     @szHostCommand         NVARCHAR (255)       
		  , @nType                 INT                 
		  ,	@bSystem               BIT                  
		  ,	@szAssemblyName        NVARCHAR (255)       
		  ,	@uidPolicyRight        UNIQUEIDENTIFIER     
		  ,	@bSuspendPolicy        BIT                  
		  , @bSupportGotoByContext BIT                  
		  ,	@tLastModified         [dbo].[utIdcTime]    


SELECT		@szHostCommand			= N'PIT_CHARTS_MVALINECHART'
		  , @nType					= 0
		  , @bSystem				= 1
		  , @szAssemblyName			= N'PlantiT.V950.Addons.Charts'
		  , @uidPolicyRight			= N'91255D3A-D27E-4961-9816-6F94A7475D27'
		  , @bSuspendPolicy			= 0
		  , @bSupportGotoByContext  = 0

EXECUTE sp_IdcGetCurrentTimeStamp @tLastModified OUTPUT

IF NOT EXISTS (SELECT 1 FROM tblPiTHostCommand WHERE szHostCommand = @szHostCommand)
BEGIN
	INSERT INTO tblPiTHostCommand 
	VALUES (@szHostCommand, @nType, @bSystem, @szAssemblyName, @uidPolicyRight, @bSuspendPolicy, @bSupportGotoByContext, @tLastModified)
END
ELSE BEGIN 
	UPDATE tblPiTHostCommand
		SET szHostCommand		  = @szHostCommand
		  , nType				  = @nType
		  , bSystem				  = @bSystem
          , szAssemblyName	      = @szAssemblyName
		  , uidPolicyRight		  = @uidPolicyRight
	      , bSuspendPolicy		  = @bSuspendPolicy
		  , bSupportGotoByContext = @bSupportGotoByContext
    WHERE szHostCommand = @szHostCommand
END

