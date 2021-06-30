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

select count(email) from AddressBook where type='Superstars'


insert into AddressBook values
('Ritik','Pal','Nagpur','Nagpur','MH',729,76788,'ritik@gmail.com','Family','Brother'),
('Pranay','Pal','Betul','MH','MP',729,76788,'pranay@gmail.com','Friend','Friend'),
('Abbhi','G','KKatol','Nagp','MH',727,76688,'abhi@gmail.com','Family','BigBrother'),
('pragya','G','Kolkata123','Nagpur','MH',727,76688,'pragya@gmail.com','Friend','Sister'),
('Pragati','Banerjee','Amravati','Amravati','MH',123,77777,'pragati@gmail.com','Family','Mom'),
('Tushar','Banerjee','Nagpur','Nagpur','MH',123,78888,'tushar@gmail.com','Family','Father'),
('Rounak','Ghosh','Kolkata123','Kolkata','West Bengal',345,77888,'ranak@gmail.com','Friend','Bro'),
('Sameer','Ali','Delhi123','Delhi','Haryana',789,77788,'sameer@gmail.com','Friend','Uncle')