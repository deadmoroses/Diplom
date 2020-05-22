--
--Создаем справочники
--
create table Roles --Роли пользователей
(
ID int primary key identity,
name varchar (20) unique not null
)

create table Classes 
(
ID int identity primary key not null,
name varchar(5) unique
)

create table Years 
(
ID int identity primary key not null,
name int unique
)

--
--Заполняем справочники стандартными записями
--

--Справочник ролей пользователей (постоянный, не меняется пользователями)
insert into Roles (name) values('Администратор')
insert into Roles (name) values('Работник столовой')
insert into Roles (name) values('Учитель')

--
--Справочники классов и годов обучения
--
insert into Classes values('а')
insert into Classes values('б')
insert into Classes values('в')

insert into Years values(1)
insert into Years values(2)
insert into Years values(3)
insert into Years values(4)
insert into Years values(5)
insert into Years values(6)
insert into Years values(7)
insert into Years values(8)
insert into Years values(9)
insert into Years values(10)
insert into Years values(11)
insert into Years values(0)

--
--Создаем главные сущности БД
--
create table Users --Иденртификационные данные пользователей
(
ID int primary key identity,
login varchar(20) unique not null,
password varchar(20) not null,
name varchar(50) not null default 'Имя не указано',
role int not null default 3,
active bit not null default 'true',
foreign key (role) references Roles(ID)
)

create table Students --Таблица учеников
(
ID int identity primary key not null,
name varchar(50) not null,
birth date not null default '1.01.1990',
year int not null default 0,
class int not null default 0,
paySumm money not null default 0,
activeFlag bit not null default '1'
foreign key (year) references Years(ID),
foreign key (class) references Classes(ID)
)

--
--Создаем пользователей для демо
--
insert into Users (login, password, role) values('admin', 'pass', 1) --Главный администратор
insert into Users (login, password, role) values('worker1', 'pass', 2) --Работник столовой (для демо)
insert into Users (login, password, role) values('teacher1', 'pass', 3) --Учитель (для демо)

--
--Создаем учеников для демо
--
INSERT INTO Students([name],[birth],[year],[class],[paySumm],[activeFlag]) 
VALUES('Andrews Maile','23/07/2008',4,3,297,'1'),('Contreras Orlando','02/09/2003',3,1,85,'1'),('Stanley Timon','25/07/2005',11,1,370,'1'),('Stokes Martin','11/06/2009',10,3,483,'0'),('Weber Knox','24/09/2002',1,3,969,'1'),('Boone Garrett','12/03/2007',4,2,925,'0'),('Gillespie Miranda','21/05/2010',2,3,679,'0'),('Herman Callum','14/05/2012',12,3,846,'1'),('Dickson Chloe','18/11/2010',9,2,250,'0'),('Cooper Alexandra','22/11/2012',11,3,972,'0'),('Olson Aaron','18/03/2005',8,1,671,'0'),('Vance Bruce','20/12/2011',9,1,743,'0'),('Anderson Yuli','22/11/2000',4,3,508,'0'),('Spencer Tamara','22/05/2000',7,2,151,'0'),('Downs Ingrid','08/09/2009',2,3,254,'0'),('Alexander Jameson','15/07/2011',4,2,398,'0'),('Ferrell Timothy','13/04/2012',7,3,278,'1'),('Cotton Odette','30/03/2010',8,3,259,'0'),('Phillips Bradley','24/09/2006',7,2,943,'0'),('Douglas Yetta','09/06/2000',11,1,880,'1'),('Conrad Rinah','14/11/2001',11,3,308,'1'),('Townsend Raphael','24/11/2006',6,3,79,'1'),('Talley Amir','28/06/2012',7,2,428,'0'),('Fry Elmo','06/06/2007',2,3,700,'1'),('Hudson Cameran','03/09/2000',9,1,152,'1'),('Vincent Lydia','06/04/2004',6,1,918,'0'),('Lara Autumn','07/10/2004',3,1,981,'1'),('Petty Nichole','13/12/2001',5,2,108,'0'),('Cherry Hu','05/06/2001',2,2,929,'0'),('Hart Ralph','01/05/2012',11,2,923,'0'),('Puckett Odysseus','25/11/2000',2,1,958,'1'),('Howe Genevieve','09/11/2003',4,2,183,'1'),('Good Orli','01/12/2009',1,1,960,'1'),('Fowler Deanna','20/01/2006',11,3,321,'1'),('Page Sonia','05/01/2010',5,1,156,'0'),('Johns Jelani','07/05/2002',4,3,489,'0'),('Fletcher Stella','05/01/2010',3,2,399,'0'),('Sparks Kiayada','14/06/2006',2,1,520,'1'),('Sampson Nerea','22/10/2004',10,3,144,'1'),('Macdonald Lamar','27/06/2007',12,3,808,'1'),('Potts Catherine','03/01/2003',3,3,217,'1'),('Keith Danielle','20/02/2008',6,2,107,'0'),('Gould Aretha','08/07/2002',2,2,853,'0'),('Kane Cameron','01/11/2009',12,3,217,'0'),('Donaldson Brianna','19/02/2001',2,3,977,'1'),('Schneider Ina','23/05/2004',6,2,430,'1'),('Cox Dana','30/01/2005',9,2,432,'1'),('Mcguire Latifah','19/01/2012',4,3,510,'1'),('Ayala Sawyer','19/12/2002',5,3,615,'1'),('Bright Martina','19/07/2005',4,1,902,'1'),('Guzman Bell','21/11/2012',10,1,386,'1'),('Booth Judith','27/11/2009',3,1,779,'0'),('Puckett Iris','19/05/2006',7,2,837,'0'),('Munoz Danielle','20/05/2010',4,1,284,'0'),('Mcdowell Madeline','18/11/2002',2,2,206,'1'),('Cantrell Gabriel','26/01/2011',1,3,362,'0'),('Scott Jaden','17/04/2010',1,2,994,'1'),('Knapp Shana','19/08/2001',11,2,607,'1'),('Cantrell Nora','17/04/2003',9,1,504,'1'),('Short Dacey','29/01/2003',2,3,872,'0'),('Delaney Iliana','31/05/2007',1,1,67,'0'),('Wheeler Nero','28/07/2002',3,2,368,'0'),('Cleveland Elvis','11/02/2000',1,3,773,'1'),('Petersen Allegra','20/08/2006',5,2,877,'1'),('Jarvis Simone','29/01/2010',12,2,239,'0'),('Schmidt Wayne','11/10/2004',4,3,281,'0'),('Lynch Fatima','03/04/2006',10,1,279,'0'),('Walker Kaitlin','24/11/2009',6,2,668,'0'),('Walters Bianca','22/01/2000',1,3,466,'1'),('Terry Vance','04/07/2000',3,3,509,'1'),('Berg Rhona','02/08/2010',12,1,998,'0'),('Evans Silas','03/10/2002',4,1,213,'0'),('Gonzalez Mohammad','18/10/2001',4,1,841,'1'),('Little Allen','26/08/2000',9,1,511,'0'),('Francis Genevieve','14/10/2009',3,3,508,'0'),('Molina Addison','30/10/2009',6,1,869,'1'),('Mcdowell Quyn','01/10/2006',6,3,495,'0'),('Cameron Beau','16/07/2000',7,1,571,'1'),('Moss Caleb','05/07/2007',2,3,901,'1'),('Beach Neil','23/08/2007',11,3,363,'0'),('Williams Dustin','26/11/2001',2,3,78,'0'),('Lara Celeste','07/08/2003',3,3,863,'1'),('Nixon Lane','17/04/2008',2,1,582,'1'),('Oneal Selma','23/04/2000',7,1,426,'1'),('Short Erin','16/10/2005',7,1,186,'1'),('Riley Fredericka','17/02/2000',2,1,717,'0'),('Floyd Paula','28/02/2008',8,1,425,'1'),('Joseph Rhea','28/02/2010',1,3,963,'0'),('Erickson Bert','13/07/2004',6,1,245,'0'),('Mcmahon Derek','07/09/2001',4,3,102,'1'),('Molina Pamela','19/09/2004',6,3,765,'0'),('Rose Trevor','12/05/2001',12,1,865,'1'),('Myers Merritt','09/07/2006',7,1,532,'1'),('Sawyer Charissa','10/09/2008',7,2,323,'0'),('Clarke Lawrence','26/08/2002',9,2,170,'0'),('Bryan Cherokee','20/07/2009',9,2,25,'0'),('Ellis Linus','04/12/2011',8,3,308,'0'),('Guthrie Nero','10/03/2007',10,3,823,'1'),('Moore Louis','27/04/2000',2,2,410,'0'),('Lowery Leonard','02/06/2010',9,3,9,'0');
