SELECT * FROM Apartments LEFT JOIN Users ON Apartments.ApartmentNumber=Users.ApartmentNr WHERE Users.LastName='Kowalski'