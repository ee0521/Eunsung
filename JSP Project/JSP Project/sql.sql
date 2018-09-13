create table guest201312011 (
	message_id int not null primary key,	
	guest_name varchar2(50) not null,	
	password varchar2(10) not null,	
	file_name varchar2(30),
	message varchar2(200) not null
);
drop table guest201312011;


create table mem201312011 (
	email varchar2(30) not null primary key,
	name varchar2(20) not null,
	pw varchar2(20) not null,
	regdate number,
	zipcode varchar2(6),
	address	varchar2(50)
);

create sequence message_id_seq increment by 1 start with 1;

select * from mem201312011;