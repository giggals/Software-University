SELECT TOP(30) CountryName , [Population]
FROM Countries
WHERE Countries.ContinentCode = 'EU'
ORDER BY Population DESC

