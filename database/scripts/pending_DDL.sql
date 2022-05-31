CREATE DATABASE pending
GO

USE pending
GO

CREATE TABLE Situation(
	idSituation smallint PRIMARY KEY IDENTITY(1,1),
	typeSituation varchar(50) not null,
);
GO

CREATE TABLE User_(
	idUser_ smallint PRIMARY KEY IDENTITY(1,1),
	emailUser_ varchar(500) unique not null,
	passwordUser_ varchar(500) not null,
);
GO

CREATE TABLE Client(
	idClient smallint PRIMARY KEY IDENTITY(1,1),
	nameClient varchar(100) not null,
	phoneClient varchar(15),
);
GO

CREATE TABLE TypeTransaction_ (
	idTypeTransaction smallint PRIMARY KEY IDENTITY(1,1),
	nameTypeTransaction varchar(20) not null,
);
GO

CREATE TABLE Transaction_(
	idClient smallint FOREIGN KEY REFERENCES Client(idClient) not null,
	idTypeTransaction smallint FOREIGN KEY REFERENCES TypeTransaction_(idTypeTransaction) not null,
	idTransaction_ smallint PRIMARY KEY IDENTITY(1,1),
	valueTransaction_ money not null,
	dateTransaction_ varchar(10) not null,
);
GO

CREATE TABLE C_Account(
	idClient smallint FOREIGN KEY REFERENCES Client(idClient) unique not null,
	idSituation smallint FOREIGN KEY REFERENCES Situation(idSituation) not null,
	idC_Account smallint PRIMARY KEY IDENTITY(1,1),
	balance varchar(50),
);
GO

CREATE TABLE B_Address (
	idUser_ smallint FOREIGN KEY REFERENCES User_(idUser_) unique not null,
	idB_Address smallint PRIMARY KEY IDENTITY(1,1),
	street varchar(50),
	number varchar(10),
	neighborhood varchar(50),
	city varchar(50),
	zipcode varchar(8),
);
GO

CREATE TABLE Business(
	idUser_ smallint FOREIGN KEY REFERENCES User_(idUser_) unique not null,
	idB_Address smallint FOREIGN KEY REFERENCES B_Address(idB_Address) unique not null,
	idBusiness smallint PRIMARY KEY IDENTITY(1,1),
	nameBusiness varchar(50) not null,
	profitBusiness varchar(50),
	expenseBusiness varchar(50),
);
GO

CREATE TABLE CashFlow(
	idBusiness smallint FOREIGN KEY REFERENCES Business(idBusiness) unique not null,
	idSituation smallint FOREIGN KEY REFERENCES Situation(idSituation) unique not null,
	idCashFlow smallint PRIMARY KEY IDENTITY(1,1),
	realBalance money not null,
	monthBalance money not null,
	estimatedBalance money not null,
	totalExpenses money not null,
	monthExpenses money not null,
	totalProfits money not null,
	monthProfits money not null,
	expensesClients money not null,
	profitsClients money not null,
	oweClients money not null,
);
GO

/*CREATE TABLE Report(
	idClient smallint FOREIGN KEY REFERENCES Client(idClient) unique not null,
	idSituation smallint FOREIGN KEY REFERENCES Situation(idSituation) unique not null,
	idCashFlow smallint FOREIGN KEY REFERENCES CashFlow(idCashFlow) unique not null,
	idReport smallint PRIMARY KEY IDENTITY(1,1),
);
GO
*/