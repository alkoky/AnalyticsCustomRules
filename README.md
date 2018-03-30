Sitecore - Analytics.ChannelRules
==================================

Summary
--------------

This module allows you to manage marketing channels settings rules instead of configuring it in the configure file which gives the author more flexibility and eliminate the need for a developer to apply the changes.

Usage
--------------
Manage rules under /sitecore/system/Marketing Control Panel/Taxonomies/Channel Rules

  
Setup
--------------
Either:
* Install Sitecore package: 
  https://github.com/alkoky/AnalyticsCustomRules/blob/master/releases/Analytics%20Channel%20Rules-1.0.zip
			
Or:
1. Include this project in your Helix style solution
2. Update NuGet references to match target Sitecore version
3. Install sitecore package for data or sync unicorn

Notes
--------------
This was built and tested with Sitecore 8.1 update 2.

This package adds the following files:

     /bin/Foundation.Analytics.ChannelRules.dll
     /bin/Foundation.Analytics.ChannelRules.pdb

     /App_Config/Include/Foundation/Foundation.AnalyticsCustomRules.config
     /App_Config/Include/Foundation/Foundation.AnalyticsCustomRules.Serialization.config

This package adds data items to the following locations:
    
    /sitecore/system/Settings/Rules/Channels
	/sitecore/system/Settings/Rules/Definitions/Tags/Channels
    /sitecore/system/Settings/Rules/Definitions/Elements/Channels
	
	/sitecore/system/Marketing Control Panel/Taxonomies/Channel Rules/Sample Campain
	
    /sitecore/templates/Foundation/ChannelRules/Channel Rule
	/sitecore/templates/Foundation/ChannelRules/Channel Rule Folder
	
Credit
----------
Many thanks to James Gregory https://github.com/digitalParkour
