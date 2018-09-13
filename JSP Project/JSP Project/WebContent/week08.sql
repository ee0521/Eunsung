select * from tab;

create sequence message_id_seq increment by 1 start with 1;

drop sequence message_id_seq;

create table guestbook_message (
	message_id int not null primary key,	
	guest_name varchar2(50) not null,	
	password varchar2(10) not null,	
	file_name varchar2(30),
	message varchar2(200) not null
);

drop table guestbook_message;

select * from guestbook_message;

insert into guestbook_message(message_id, guest_name, password, message) values (message_id_seq.nextval, 'egyou', 'come', 'hi!');
insert into guestbook_message(message_id, guest_name, password, message) values (message_id_seq.nextval, 'egyou1', 'come1', 'hi!1');
insert into guestbook_message(message_id, guest_name, password, message) values (message_id_seq.nextval, 'egyou2', 'come2', 'hi!2');
insert into guestbook_message(message_id, guest_name, password, message) values (message_id_seq.nextval, 'egyou3', 'come3', 'hi!3');
insert into guestbook_message(message_id, guest_name, password, message) values (message_id_seq.nextval, 'egyou4', 'come4', 'hi!4');

select * from guestbook_message where message_id between 4 and 6 order by message_id desc; 

create user dream identified by "cometrue";

grant resource, connect to dream;

select * from member2a;

insert into member2a(email, name, pw) 
values('egyou@induk.ac.kr', 'egyou', 'cometrue');

select * from member2a where email='66' and pw='66';

update member2a set name='egyou', regdate=2016, zipcode='12345', address='���赿' 
where email='66';

create table member2a (
	email varchar2(30) not null primary key,
	name varchar2(20) not null,
	pw varchar2(20) not null,
	regdate number,
	zipcode varchar2(6),
	address	varchar2(50)
);



select email, name from ( select rownum rnum, email, name 
from ( select * from m_201312011 m where m.email != 'admin' order by m.email desc ) 
where rownum <= 5 ) where rnum >= 1; 