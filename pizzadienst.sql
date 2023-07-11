use db;

insert into pizzadienst(name, location, kontakt) values
("Peppino", "9020 Klagenfurt", "+43 664 0359234");

select * from pizzadienst;

create table wagen(
	wagenId int auto_increment primary key,
    marke varchar(255),
    baujahr int,
    kennzeichen varchar(255),
    pizzaServiceId int,
    foreign key(pizzaServiceId) references pizzadienst(pizzaServiceId)
);

insert into wagen(marke, baujahr, kennzeichen, pizzaServiceId) value
("Volvo", 2010, "K-983BY", 1),
("Foard", 2021, "K-463TU", 1);


create table lieferant(
	lieferantenId int auto_increment primary key,
    firstName varchar(255),
    lastName varchar(255),
    kontakt varchar(255),
    wagenId int,
    pizzaServiceId int,
    foreign key(wagenId) references wagen(wagenId),
    foreign key(pizzaServiceId) references pizzadienst(pizzaServiceId)
);

insert into lieferant(firstName, lastName, kontakt, wagenId, pizzaServiceId) values
("Konrad", "Müller", "+43667985t7234", 2, 1),
("Paul", "Sandner", "+436602354945", 1, 1);

create table bestellung(
	bestellId int auto_increment primary key,
    gesamtpreis int,
    lieferantenId int,
    foreign key(lieferantenId) references lieferant(lieferantenId)
);

create table pizza(
	pizzaId int auto_increment primary key,
    name varchar(255),
    basiszutat varchar(255),
    extraZutat varchar(255),
    preis int
);

create table pizzaBestellung(
	maenge int,
    bestellId int,
    pizzaId int,
    primary key(bestellId, pizzaId),
    foreign key(bestellId) references bestellung(bestellId),
    foreign key(pizzaId) references pizza(pizzaId)
);
    
insert into bestellung(gesamtpreis, lieferantenId) values
(12, 1),
(29, 2),
(9, 2),
(17, 1),
(16, 2);

insert into pizza(name, basiszutat, extrazutat, preis) values
("Margaritha", "Tomatensauce und Mozarella", "Funghi", 6),
("Diavolo", "Tomatensauce und Mozarella", "Peperoni Salami", 8),
("Capricciosa", "Tomatensauce und Mozarella", "Schinken und Artischocken", 9);

insert into pizzaBestellung(maenge, bestellId, pizzaId) values
(2, 1, 1),
(2, 2, 1),
(1, 2, 2),
(1, 2, 3),
(1, 3, 3),
(1, 4, 2),
(1, 4, 3),
(2, 5, 2);