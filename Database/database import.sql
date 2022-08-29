 DROP DATABASE IF EXISTS projlogin;
 CREATE DATABASE projlogin;
USE projlogin; 
 
 DROP TABLE IF EXISTS user;
 CREATE TABLE if not exists user(
 id bigint auto_increment primary key,
 username varchar(50),
 password varchar(50),
 usertype varchar(50)
);


 DROP TABLE IF EXISTS loginlogs;
 CREATE TABLE if not exists loginlogs(
 id bigint auto_increment primary key,
 username varchar(50),
 password varchar(50),
 date datetime
);

 DROP TABLE IF EXISTS cars;
 CREATE TABLE if not exists cars(
 id bigint auto_increment primary key,
 model varchar(50),
 brand varchar(50),
 price int
);

INSERT INTO user(username,password,usertype)
VALUES("1","1","ADMIN"),
("2","2","GUEST");

INSERT INTO cars(model,brand,price)
VALUES("TESLA","X",20000),
("BMW","X6",20700);
 
 
 select * From user;
 select * From loginlogs;

 