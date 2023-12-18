select * from smjerovi;

select naziv, cijena from smjerovi;


select naziv, 'Osijek',8,7.6 from smjerovi;

select naziv as smjer, 'Osijek' as grad from smjerovi;

select naziv, len(naziv) as duzina,
getdate() as datum from smjerovi;

select 1;

select sifra, naziv, 'Edunova' as skola,
len(naziv) as duzina, * from smjerovi;

select * from smjerovi where sifra=1;

--operatori usporedivanja <,>,=, >=, <=
--razlicito jednako !=
select * from polaznici where sifra!=7;

select * from polaznici where ime='Ivan';
select * from polaznici where ime>'Ivan';

select * from grupe where datumpocetka>'2023-09-01';

--logicki operatori

select * from polaznici where 
sifra>7 and sifra<10;

select * from polaznici where 
sifra>=72 and sifra=100;

select * from polaznici where 
sifra=7 or sifra=10;

select * from polaznici where 
sifra=10 or sifra=10;


select * from polaznici where 
ime='Ivan' or sifra=10;

select * from polaznici where 
not ime='Ivan';

select * from polaznici where 
ime!='Ivan';

--ostali operatori-like=kao

select * from polaznici where ime not like '%a%';

select * from polaznici where prezime like 'b%';
--prije b nesmije biti nista 
select * from polaznici where prezime like 'b%žić';
--pocima sa b ,a zavrsava na žic
select* from polaznici where prezime like '%nt'
--kaladont

select * from polaznici where 
sifra=2 or sifra=4 or sifra=7;

--jednostavnija sintaksa
select * from polaznici where sifra in (2,4,7);

select * from polaznici where sifra not in (2,4,7);

select * from polaznici where 
sifra>=6 and sifra<=10;
select * from polaznici where 
sifra between 6 and 10;--jednostavnije

select * from grupe where
datumpocetka between '2023-01-01' and '2023-12-31';

select * from smjerovi;
select * from smjerovi where brojsati=null;

--null  se samo  2 operatora mogu primjenjivati,is null-is not null

select * from smjerovi where
brojsati is not  null;
select * from smjerovi where 
brojsati is  null ;

select isnull (brojsati,30) from smjerovi ;

--slaganje podataka

select * from polaznici order by prezime;
select * from polaznici order by prezime desc;
select * from polaznici order by prezime desc, 2desc;

--limitiranje podataka
select top 10 * from polaznici;
select top 10 percent *from polaznici;


select ime as djever, brojugovora as racun 
into nova
from polaznici;

select* from nova;

drop table nova;

