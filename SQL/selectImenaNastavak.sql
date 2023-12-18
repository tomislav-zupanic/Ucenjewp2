use svastara;

select count(*) from kupci;
--554
select * from kupci where ime like '%Tomislav%';

select distinct ime, prezime
from kupci where ime='Tomislav';