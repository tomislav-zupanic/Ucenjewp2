--izlistaj ime i prezimena autora
select* from autor;
select top 10 ime, prezime from autor;
--koliko autora
select count(*) from autor;

--svi autori koji su rodeni u vasoj godini rodenja

select *from autor where
datumrodenja between'2001-01-01' and '2001-01-01';

select *from autor where
datumrodenja between'1976-01-01' and '1976-01-01';
--unesi sebe kao autora
insert into autor (sifra,ime,prezime) values
(4,'Tomislav','Županić');

select * from autor where
sifra=4;

--mladica ostavila djevojka


select * from katalog where
(naslov like '%ljubav%' or naslov like '%bol%')
and sifra not in (2541,2596,2680) ;

--izlistaj sve neaktivne izdavace

select * from izdavac where aktivan=0; 

--izlistajte sve izdavace koji su drustva sa ogranicenom odgovornoscu
select * from izdavac where
naziv like '%d.o.o.%';

--izlistaj sva mjesta u os baranjskoj zupaniji

select* from mjesto where 
postanskiBroj like '31%';

--s najmanjom pogreskom izlistaj sve autorice
select * from autor where ime like '%a';

select distinct ime from autor where ime like '%a';









