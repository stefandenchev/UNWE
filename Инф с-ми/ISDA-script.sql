/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     2/10/21 1:01:50 PM                           */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Student') and o.name = 'FK_STUDENT_STUDENTSP_SPECIALT')
alter table Student
   drop constraint FK_STUDENT_STUDENTSP_SPECIALT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StudentSubject') and o.name = 'FK_STUDENTS_STUDENTSU_STUDENT')
alter table StudentSubject
   drop constraint FK_STUDENTS_STUDENTSU_STUDENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StudentSubject') and o.name = 'FK_STUDENTS_STUDENTSU_SUBJECT')
alter table StudentSubject
   drop constraint FK_STUDENTS_STUDENTSU_SUBJECT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Specialty')
            and   type = 'U')
   drop table Specialty
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Student')
            and   type = 'U')
   drop table Student
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StudentSubject')
            and   name  = 'StudentSubject2_FK'
            and   indid > 0
            and   indid < 255)
   drop index StudentSubject.StudentSubject2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StudentSubject')
            and   name  = 'StudentSubject_FK'
            and   indid > 0
            and   indid < 255)
   drop index StudentSubject.StudentSubject_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('StudentSubject')
            and   type = 'U')
   drop table StudentSubject
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Subject')
            and   type = 'U')
   drop table Subject
go

/*==============================================================*/
/* Table: Specialty                                             */
/*==============================================================*/
create table Specialty (
   SpecialtyId          int                  not null,
   Name                 varchar(50)          not null,
   constraint PK_SPECIALTY primary key nonclustered (SpecialtyId)
)
go

/*==============================================================*/
/* Table: Student                                               */
/*==============================================================*/
create table Student (
   FNumber              varchar(10)          not null,
   SpecialtyId          int                  not null,
   FName                varchar(50)          not null,
   MName                varchar(50)          not null,
   LName                varchar(50)          not null,
   Address              varchar(100)         null,
   Phone                varchar(20)          null,
   EMail                varchar(50)          null,
   constraint PK_STUDENT primary key nonclustered (FNumber)
)
go

/*==============================================================*/
/* Table: StudentSubject                                        */
/*==============================================================*/
create table StudentSubject (
   FNumber              varchar(10)          not null,
   SubjectID            int                  not null,
   FinalGrade           float                null,
   constraint PK_STUDENTSUBJECT primary key (FNumber, SubjectID)
)
go

/*==============================================================*/
/* Index: StudentSubject_FK                                     */
/*==============================================================*/
create index StudentSubject_FK on StudentSubject (
FNumber ASC
)
go

/*==============================================================*/
/* Index: StudentSubject2_FK                                    */
/*==============================================================*/
create index StudentSubject2_FK on StudentSubject (
SubjectID ASC
)
go

/*==============================================================*/
/* Table: Subject                                               */
/*==============================================================*/
create table Subject (
   SubjectID            int                  not null,
   Name                 varchar(50)          not null,
   constraint PK_SUBJECT primary key nonclustered (SubjectID)
)
go

alter table Student
   add constraint FK_STUDENT_STUDENTSP_SPECIALT foreign key (SpecialtyId)
      references Specialty (SpecialtyId)
go

alter table StudentSubject
   add constraint FK_STUDENTS_STUDENTSU_STUDENT foreign key (FNumber)
      references Student (FNumber)
go

alter table StudentSubject
   add constraint FK_STUDENTS_STUDENTSU_SUBJECT foreign key (SubjectID)
      references Subject (SubjectID)
go

