--
--Создаем справочники
--
create table Roles --Роли пользователей
(
ID int primary key identity,
name varchar (20) unique not null
)

--
--Заполняем справочники стандартными записями
--

--Справочник ролей пользователей (постоянный, не меняется пользователями)
insert into Roles (name) values('Администратор')
insert into Roles (name) values('Работник столовой')
insert into Roles (name) values('Учитель')

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

--
--Создаем демо пользователей
--
insert into Users (login, password, role) values('admin', 'pass', 1) --Главный администратор
insert into Users (login, password, role) values('worker1', 'pass', 2) --Работник столовой (для демо)
insert into Users (login, password, role) values('teacher1', 'pass', 3) --Учитель (для демо)


