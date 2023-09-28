
--create database query

Create Database Assignment_6;

Create table Teacher
(
	TeacherID int identity(1,1) primary key not null,
	FirstName nvarchar(20) not null,
	LastName nvarchar(25) not null,
	Gender nvarchar(6) not null,
	[Subject] nvarchar(25) not null,
)

create table Pupil
(
	PupilID int identity(1,1) primary key not null,
	FirstName nvarchar(20) not null,
	LastName nvarchar(25) not null,
	Gender nvarchar(6) not null,
	Class nvarchar(2) not null,
)

create table TeacherPupil
(
	TeacherID int not null,
	PupilID int not null,

	primary key (TeacherID, PupilID),
	foreign key (TeacherID) references Teacher(TeacherID),
	foreign key (PupilID) references Pupil(PupilID),
)




--search query

select Teacher.FirstName, Teacher.LastName 
from Teacher
inner join TeacherStudent on Teacher.TeacherID = TeacherStudent.TeacherID
inner join Student on TeacherStudent.StudentID = Student.StudentID
where Student.FirstName = N'??????'