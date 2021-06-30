create database AddressBookServiceDB

use AddressBookServiceDB
create table AddressBook
(
firstName varchar(25),
lastName varchar(25),
address varchar(200),
city varchar(25),
state varchar(25),
zip int,
phoneNumber bigint,
email varchar(100)
);
select * from AddressBook;


insert into AddressBook values
('Shreya','Malviya','Ngp','Nagpur','MH',440022,8596859685,'malviyashreya26@gmail.com'),
('Prajakta','Bramhe','Mumbai123','Mumbai','Maharashtra',550022,78577964412,'prajaktab@gmail.com')

