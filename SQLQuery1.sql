use master
use users
CREATE TABLE users
(
	id int primary key identity (1,1),
	username varchar(max) null,
	password varchar(max) null,
	role varchar(max) null,
	status varchar(max) null,
	date_reg date null
)

select * from users
INSERT INTO users (username, password, role, status, date_reg) Values ('admin', 'admin123', 'admin', 'Active', '2024-11-23')

select * from users where role = 'Staff'