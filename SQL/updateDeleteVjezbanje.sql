

--select * from grupe;


select * from polaznici;

----update grupe set smjer=11;


--update polaznici set prezime='kartik';

select * from polaznici;

update polaznici set prezime='kartik' 
where sifra=17;
--1 kolona

update polaznici set prezime='Šuler' ,
oib='12345678911',
brojugovora='23/2023'
where sifra=17;
--3 kolone
select * from polaznici where sifra=17;

select * from smjerovi;

update smjerovi set cijena=1500
where sifra>1;

update smjerovi set cijena=1500
where sifra in (2,3);

update smjerovi set cijena=cijena*1.2;


update smjerovi set cijena=cijena*0.8;


select * from smjerovi;
--uvecanje cijena za 20 i umanjive za 20 posto--

update smjerovi set cijena=cijena-15;

select * from smjerovi;

update smjerovi set cijena=cijena+15;

--uvecano i smanjeno za 15

select * from smjerovi; 

update smjerovi set upisnina=cijena*0.1;

--svaka upisnina je 10 posto od cijene-

update smjerovi set cijena=1489.52 
where sifra=2;

--delete--

select * from smjerovi;

delete from smjerovi;

insert into smjerovi (naziv) values
('Python programiranje');

 delete from smjerovi where sifra=4;

 insert into smjerovi (naziv) values
('Python programiranje');

 delete from smjerovi where sifra=4;

 select * from smjerovi;

 delete from clanovi where polaznik=25;

 select * from clanovi;

select * from polaznici;

delete from clanovi;