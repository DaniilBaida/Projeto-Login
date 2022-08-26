 DROP DATABASE IF EXISTS projLogin;
 CREATE DATABASE projLogin;
 use projLogin; 
 
 DROP TABLE IF EXISTS user;
 CREATE TABLE if not exists user(
 id bigint auto_increment primary key,
 username varchar(50),
 password varchar(50),
 usertype varchar(50)
);


INSERT INTO user(username,password,usertype)
VALUES("ADMIN","ADMIN","ADMIN");
 
 