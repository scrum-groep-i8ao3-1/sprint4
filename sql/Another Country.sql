SELECT tblCountry.CountryName, tblEvent.EventName 
FROM tblCountry
FULL OUTER JOIN tblEvent
on tblCountry.CountryID = tblEvent.CountryID
WHERE tblEvent.EventName IS NULL;