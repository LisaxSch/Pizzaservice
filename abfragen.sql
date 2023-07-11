SELECT 
    p.name, SUM(b.maenge) AS Summe
FROM
    pizza AS p
        JOIN
    pizzaBestellung AS b ON p.pizzaId = b.pizzaId
GROUP BY p.name
ORDER BY Summe DESC
LIMIT 1;

##

SELECT 
    p.name, p.preis, b.pizzaId, SUM(p.preis * b.maenge) AS sum
FROM
    pizza AS p
        JOIN
    pizzaBestellung AS b ON p.pizzaId = b.pizzaId
GROUP BY p.pizzaId;

##

select b.lieferantenId, l.firstName, l.lastName, sum(p.maenge) from bestellung as b
join lieferant as l on b.lieferantenId = l.lieferantenId
join pizzaBestellung as p on b.bestellId = p.bestellId
group by b.lieferantenId;
            

	
    


