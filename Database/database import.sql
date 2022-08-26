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

INSERT INTO user(username,password,usertype)
VALUES("ADMIN","ADMIN","ADMIN"),
("123","123","GUEST");


 
 
 select * From user;
 select * From loginlogs;

 