USE master

DROP DATABASE ContactProject_DB 

CREATE DATABASE ContactProject_DB
 
USE ContactProject_DB;

CREATE TABLE Contact(
	ID nvarchar(10) NOT NULL PRIMARY KEY,
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	Gender bit NOT NULL,
	Birthdate date NOT NULL,
	OwnerUsername nvarchar(50) NOT NULL);

CREATE TABLE ContactEmails(
	ID int NOT NULL PRIMARY KEY,
	ContactID nvarchar(10) NOT NULL,
	Email nvarchar(50) NOT NULL,
	IsAccepted bit not null);

CREATE TABLE ContactPhones(
	ID int NOT NULL PRIMARY KEY,
	ContactID nvarchar(10) NOT NULL,
	PhoneNumber nvarchar(11) NOT NULL,
	IsAccepted bit not null);

CREATE TABLE [User](
	Username nvarchar(50) NOT NULL PRIMARY KEY,
	Password nvarchar(500) NOT NULL,
	RoleID int NOT NULL);

CREATE TABLE ContactTransactions(
	ID nvarchar(10) NOT NULL primary key,
	ContactID nvarchar(10) NOT NULL,
	Value money NOT NULL,
	TransactionDate datetime NOT NULL,
	IsAccepted bit NOT NULL,
	IsPayment bit NOT NULL);
	
	
INSERT [User] (Username, Password, RoleID) VALUES (N'a', N'0cc175b9c0f1b6a831c399e269772661', 0);

ALTER TABLE Contact  WITH CHECK ADD  CONSTRAINT FK_Contact_User FOREIGN KEY(OwnerUsername)
REFERENCES [User] (Username)

ALTER TABLE Contact CHECK CONSTRAINT FK_Contact_User

ALTER TABLE ContactEmails  WITH CHECK ADD  CONSTRAINT FK_ContactEmails_Contact FOREIGN KEY(ContactID)
REFERENCES Contact (ID)

ALTER TABLE ContactEmails CHECK CONSTRAINT FK_ContactEmails_Contact

ALTER TABLE ContactPhones  WITH CHECK ADD  CONSTRAINT FK_ContactPhones_Contact FOREIGN KEY(ContactID)
REFERENCES Contact (ID)

ALTER TABLE ContactTransactions WITH CHECK ADD  CONSTRAINT FK_ContactTransactions_Contact FOREIGN KEY(ContactID)
REFERENCES Contact (ID)

ALTER TABLE ContactTransactions CHECK CONSTRAINT FK_ContactTransactions_Contact

ALTER TABLE ContactPhones CHECK CONSTRAINT FK_ContactPhones_Contact
