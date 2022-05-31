/*UPDATE Table
SET
	column = value,
	column = value
WHERE
	row = id
*/

USE pending
GO

INSERT INTO Situation (typeSituation)
VALUES ('green'),
	   ('red'),
	   ('yellow');
GO
SELECT * FROM Situation;
GO


INSERT INTO User_ (emailUser_, passwordUser_)
VALUES ('adm@pending.com', 'adm123');
GO
SELECT * FROM User_;
GO

INSERT INTO Client (nameClient, phoneClient)
VALUES ('Diego Almeida', '551194872679'),
	   ('Sofia Martins','5541901546875');
GO
SELECT * FROM Client;
GO

INSERT INTO TypeTransaction_ (nameTypeTransaction)
VALUES ('payment'),
	   ('purchase');
GO
SELECT * FROM TypeTransaction_;
GO

INSERT INTO Transaction_ (idClient, idTypeTransaction, valueTransaction_, dateTransaction_)
VALUES (1, 1, '-20.50', '07/04/2022'),
	   (1, 2, '30.50', '06/04/2022'),
	   (2, 1, '-10.20', '05/04/2022'),
	   (2, 2, '15.10', '04/04/2022');
GO
SELECT * FROM Transaction_;
GO

INSERT INTO C_Account (idClient, idSituation, balance)
VALUES (1, 3, '0'),
	   (2, 3, '0');
GO
SELECT * FROM C_Account;
GO

INSERT INTO B_Address (idUser_, street, number, neighborhood, city, zipcode)
VALUES (1, 'Alameda Barão de Limeira', '539', 'Santa Cecilia', 'São Paulo', '01202001');
GO
SELECT * FROM B_Address;
GO

INSERT INTO Business(idUser_, idB_Address, nameBusiness, profitBusiness, expenseBusiness)
VALUES (1, 1, 'SENAI de Informática', '0', '0');
GO
SELECT * FROM Business;
GO

INSERT INTO CashFlow (idBusiness, idSituation, realBalance, monthBalance, estimatedBalance, totalExpenses, monthExpenses, totalProfits, monthProfits, expensesClients, profitsClients, oweClients)
VALUES (1, 3, '0', '0', '0', '0', '0', '0', '0', '0', '0', '0');
GO
SELECT * FROM CashFlow;
GO
