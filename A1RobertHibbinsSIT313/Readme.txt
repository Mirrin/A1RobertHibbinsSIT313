*Name : Shop Track
*Description: ShopTrack was made with the intentions of being able to track your shopping list simply via editing a simple data base based on i.d's the functions it will support are edit,update, create and delete.
this application will be designed in 5 weeks with ever week il add a new feature.

The capabilities of the application allow the users to easily navigate a user friendly UI to update and insert data into a data base using SQLite technology.
The functions are based off searching for Key I.D the user is shown notifications to successful changes within the data base unfortunately the UI function of displaying a list was incomplete 
due to not finding a simple way of doing this.

The api i used to create this and emulate are API 19 4.4 android due to not being able to run the latest emulator and android OS at the time of installation and this was the only stable version i could get to work.


packages required to run this are 
the NUget SQlite data base packages listed below,

		  <package id="sqlite-net" version="1.0.8" targetFramework="monoandroid60" />
		  <package id="sqlite-net-pcl" version="1.1.2" targetFramework="monoandroid60" />
		  <package id="SQLitePCL.bundle_green" version="0.9.2" targetFramework="monoandroid60" />
		  <package id="SQLitePCL.plugin.sqlite3.android" version="0.9.3" targetFramework="monoandroid60" />
		  <package id="SQLitePCL.raw" version="0.9.2" targetFramework="monoandroid60" />

The developing process was fine but User interface changed from the purposed out look i thought of in week 1 design video and i wasnt successfully able to implement every function with the lack of the list view function
users are still able to use the application but only via the Toast notifications that pop up.


User can insert name within the main application page and press Welcome this will display name within a new activity, user presses the generic android back button down the bottom to return to home screen, user can then press shopping list this enables user to create and store list items within a data base, each function requires the user to either leave the function page to return back to the main menu setting of activity 2 (shoppinglist)