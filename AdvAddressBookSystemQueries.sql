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