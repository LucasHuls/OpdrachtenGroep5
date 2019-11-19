select What, EventDate 
from dbo.tblEvent 
where 'Teletubbies' in (What) or 'Pandy' in (What);