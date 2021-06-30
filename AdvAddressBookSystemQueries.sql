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

update AddressBook set zip =58965 where firstName='Prajakta'
delete from AddressBook where firstName='Prajakta'

insert into AddressBook values
('Prajakta','Bramhe','Mumbai123','Mumbai','Maharashtra',550022,78577964412,'prajaktab@gmail.com')

select * from AddressBook where city='Mumbai' or state='Maharashtra'


select count(email) TotalPersons from AddressBook

insert into AddressBook values
('Ekta','Khan','Mumbai123','Mumbai','Maharashtra',38185,45657465,'Ekta@gmail.com')

select * from AddressBook where city ='Mumbai' order by firstName


alter table AddressBook add type varchar(20),name varchar(20)
update AddressBook set type='Superstars' where firstName='Ekta' or firstName='Prajakta'
update AddressBook set name='MumbaiContacts' where firstName='Prajakta' or firstName='Ekta'
update AddressBook set type='Me' where firstName='Shreya'
update AddressBook set name='SelfContact' where firstName='Shreya'