SELECT        COUNT(Teachers.schools_schoolId) AS NoOfTeachers, Schools.schoolName, Addresses.streetName, Addresses.streetNumber, Addresses.cityName, 
                         Addresses.cityNumber, SchoolOIB.oibValue AS SchoolOIB, Principals.firstName AS PrincipalFirstName, Principals.lastName AS PrincipalLastName, 
                         PrincipalOIB.oibValue AS PrincipalOIB, CASE WHEN Principals.firstName IS NULL OR
                         Principals.lastName IS NULL THEN 1 ELSE 0 END AS ContactInfo
FROM            Schools LEFT OUTER JOIN
                         Addresses ON Addresses.addressId = Schools.addresses_addressId LEFT OUTER JOIN
                         OIBs AS SchoolOIB ON SchoolOIB.oibId = Schools.OIBs_oibId LEFT OUTER JOIN
                         Principals ON Principals.schools_schoolId = Schools.schoolId LEFT OUTER JOIN
                         OIBs AS PrincipalOIB ON PrincipalOIB.oibId = Principals.OIBS_oibId LEFT OUTER JOIN
                         Teachers ON Teachers.schools_schoolId = Schools.schoolId
GROUP BY Schools.schoolName, Addresses.streetName, Addresses.streetNumber, Addresses.cityName, Addresses.cityNumber, SchoolOIB.oibValue, 
                         Principals.firstName, Principals.lastName, PrincipalOIB.oibValue