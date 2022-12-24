> Note: All ServerDataBuilder Class Is Static.

+ Class: ServerDataBuilder
	- Method: GetInfo
		- Parameter Value: String ApiToken
			- Model Name For Add Value: GetInfoData
				- Request Method: Get
				
+ Class: ServerDataBuilder
	- Method: GetServerInfo
		- Parameter Value: String ApiToken
			- Model Name For Add Value: GetInfoData
				- Request Method: Get
				
+ Class: ServerDataBuilder
	- Method: GetServerLocations
		- Parameter Value: String ApiToken
			- Model Name For Add Value: GetInfoData
				- Request Method: Get
				
+ Class: ServerDataBuilder
	- Method: ShotDownServer
		- Parameter Value: String ApiToken ,Int Id 
			- Model Name For Add Value: SettingServerData
				- Request Method: Get
				
+ Class: ServerDataBuilder
	- Method: StartServer
		- Parameter Value: ApiToken ,Int Id
			- Model Name For Add Value: SettingServerData
				- Request Method: Get
				
+ Class: ServerDataBuilder
	- Method: 
		- Parameter Value: ApiToken ,Int Id
			- Model Name For Add Value: SettingServerData
				- Request Method: Get

+ Class: ServerDataBuilder
	- Method: RestartServer
		- Parameter Value: ApiToken ,Int Id
			- Model Name For Add Value: SettingServerData
				- Request Method: Get

+ Class: ServerDataBuilder
	- Method: PauseServer
		- Parameter Value: ApiToken ,Int Id
			- Model Name For Add Value: SettingServerData
				- Request Method: Get

+ Class: ServerDataBuilder
	- Method: SaveServer
		- Parameter Value: ApiToken ,Int Id
			- Model Name For Add Value: SettingServerData
				- Request Method: Get

+ Class: ServerDataBuilder
	- Method: CheckServer
		- Parameter Value: ApiToken ,Int Id
			- Model Name For Add Value: SettingServerData
				- Request Method: Get

+ Class: ServerDataBuilder
	- Method: GetPlans
		- Parameter Value: ApiToken ,Int LocationId ,Int PlanId ,PeriodType PeriodType 
			- Model Name For Add Value: GetPlanData
				- Request Method: Get

+ Class: ServerDataBuilder
	- Method: ByServer
		- Parameter Value: ApiToken ,String Coupon ,Int LocationId ,Int PlanId ,PeriodType PeriodType ,Int DiskId ,Int Count
			- Model Name For Add Value: ByServerData
				- Request Method: post
					-ContentType: application/json
				
+ Class: ServerDataBuilder
	- Method: RenewServer
		- Parameter Value: ApiToken ,String Coupon ,Int VMId ,PeriodType PeriodType ,Int Count
			- Model Name For Add Value: RenewServerData
				- Request Method: post
					-ContentType: application/json

+ Class: ServerDataBuilder
	- Method: ChnageOsServer
		- Parameter Value: ApiToken ,String Coupon ,Int VMId ,Int DiskId
			- Model Name For Add Value: ChangeOsServerData
				- Request Method: post
					-ContentType: application/json
					
					
# Programmer: Iliya4lx | Telegram: Skill_IliyaAsghari	


![This is an image](https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYEIZk-4mKGflGMQT02zuzNmfX9LKje2GNig&usqp=CAU)
