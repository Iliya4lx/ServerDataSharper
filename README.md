> Note: All ServerDataBuilder Class Is Static.

+ Class: ServerDataBuilder
	- Method: GetInfo
		- Parametrs Method: String ApiToken
			- Model Name For Add Value: GetInfoData
				- Request Method: Get
				
+ Class: ServerDataBuilder
	- Method: GetServerInfo
		- Parametrs Method: String ApiToken
			- Model Name For Add Value: GetInfoData
				- Request Method: Get
				
+ Class: ServerDataBuilder
	- Method: GetServerLocations
		- Parametrs Method: String ApiToken
			- Model Name For Add Value: GetInfoData
				- Request Method: Get
				
+ Class: ServerDataBuilder
	- Method: ShotDownServer
		- Parametrs Method: String ApiToken ,Int Id 
			- Model Name For Add Value: SettingServerData
				- Request Method: Get
				
+ Class: ServerDataBuilder
	- Method: StartServer
		- Parametrs Method: ApiToken ,Int Id
			- Model Name For Add Value: SettingServerData
				- Request Method: Get
				
+ Class: ServerDataBuilder
	- Method: 
		- Parametrs Method: ApiToken ,Int Id
			- Model Name For Add Value: SettingServerData
				- Request Method: Get

+ Class: ServerDataBuilder
	- Method: RestartServer
		- Parametrs Method: ApiToken ,Int Id
			- Model Name For Add Value: SettingServerData
				- Request Method: Get

+ Class: ServerDataBuilder
	- Method: PauseServer
		- Parametrs Method: ApiToken ,Int Id
			- Model Name For Add Value: SettingServerData
				- Request Method: Get

+ Class: ServerDataBuilder
	- Method: SaveServer
		- Parametrs Method: ApiToken ,Int Id
			- Model Name For Add Value: SettingServerData
				- Request Method: Get

+ Class: ServerDataBuilder
	- Method: CheckServer
		- Parametrs Method: ApiToken ,Int Id
			- Model Name For Add Value: SettingServerData
				- Request Method: Get

+ Class: ServerDataBuilder
	- Method: GetPlans
		- Parametrs Method: ApiToken ,Int LocationId ,Int PlanId ,PeriodType PeriodType 
			- Model Name For Add Value: GetPlanData
				- Request Method: Get

+ Class: ServerDataBuilder
	- Method: ByServer
		- Parametrs Method: ApiToken ,String Coupon ,Int LocationId ,Int PlanId ,PeriodType PeriodType ,Int DiskId ,Int Count
			- Model Name For Add Value: ByServerData
				- Request Method: post
					-ContentType: application/json
				
+ Class: ServerDataBuilder
	- Method: RenewServer
		- Parametrs Method: ApiToken ,String Coupon ,Int VMId ,PeriodType PeriodType ,Int Count
			- Model Name For Add Value: RenewServerData
				- Request Method: post
					-ContentType: application/json

+ Class: ServerDataBuilder
	- Method: ChnageOsServer
		- Parametrs Method: ApiToken ,String Coupon ,Int VMId ,Int DiskId
			- Model Name For Add Value: ChangeOsServerData
				- Request Method: post
					-ContentType: application/json
					
					
# Programmer: Iliya4lx | Telegram: Skill_IliyaAsghari	


![This is an image](https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYEIZk-4mKGflGMQT02zuzNmfX9LKje2GNig&usqp=CAU)