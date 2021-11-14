create database BookAudioProject
go
use BookAudioProject
go

create table Book
(
	BookID int IDENTITY(1,1) NOT NULL,
	BookName varchar(100) NULL,
	AudioPath varchar(100) NULL,
	AddedDate datetime NOT NULL,
	constraint PK_Book PRIMARY KEY(BookID) 
)
go
create table Member(
	MemberId int IDENTITY(1,1) NOT NULL,
	Username varchar(100) NULL,
	[Password] varchar(30) NULL,
	constraint PK_Member PRIMARY KEY(MemberId)
 )
 go
 create table MemberAudioHistory(
	HistoryID int IDENTITY(1,1) NOT NULL,
	MemberId int NOT NULL,
	BookName varchar(100) NULL,
	AudioPath varchar(100) NULL,
	AddedDate datetime NOT NULL,
	constraint PK_MemberAudioHistory PRIMARY KEY(HistoryID),
 	constraint FK_MAH_Member FOREIGN KEY(MemberId) REFERENCES Member(MemberId)
 )
 go
 insert Member(Username,[Password]) values
(N'trang',N'trang'),
(N'ha', N'ha'),
(N'thinh', N'thinh')