SELECT 
tblEvent.EventName, 
tblEvent.EventDate, 
tblCountry.CountryName, 
tblContinent.ContinentName, 
tblEvent.EventID, 
tblCOuntry.CountryID, 
tblContinent.ContinentID

from [dbo].[tblEvent]
 left join [dbo].[tblCountry]
	 on tblCountry.CountryID = tblEvent.CountryID
 left join [dbo].[tblContinent]
	 on tblContinent.ContinentID  = tblCountry.ContinentID

WHERE tblContinent.ContinentName = 'Antarctic'   
or tblCountry.CountryName = 'Russia';


 

