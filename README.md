# Vending_Machine


Problema:
Exista un aparat de cafea/sandvisuri unde clientul poate selecta un numar de produse pentru cumparare.

Aparatul nu accepta decat hartii de 10 lei si nu da rest decat monede de 50 si 10 bani.

Din partea aparatului se primeste un array de valori produse selectate.

Se cere o functie simpla, care sa primeasca ca parametru array-ul mai sus mentionat si sa returneze urmatoarele:

1.           Numarul de bancnote de 10 lei care sunt necesare pentru a acoperi valoarea tuturor produselor din array.

2.           Numarul de monede de 50 si 10 bani pe care aparatul va trebui sa le returneze ca rest daca primeste bancnotele solicitate.

In asa fel incat numarul total de monede sa fie minim.

Exemple date intrare:

             [3, 2.5, 1]

             [2, 14, 2.3]

             [1, 2.6, 3]

             [3, 3, 3.9]


Output:


Please add 3 products:
3 3 3.9
Please insert 10 lei coin for 1 time :
(Press any key to insert)
Wait for your tips:
0.10 lei in 0 on 50 coins and 1 in 10 coins


Please add 3 products:
3 2.5 1
Please insert 10 lei coin for 1 time :
(Press any key to insert)
Wait for your tips:
3.50 lei in 7 on 50 coins and 0 in 10 coins


Please add 3 products:
3 2.5 1
Please insert 10 lei coin for 1 time :
(Press any key to insert)
Wait for your tips:
3.50 lei in 7 on 50 coins and 0 in 10 coins


Please add 3 products:
2 14 2.3
Please insert 10 lei coin for 2 time :
(Press any key to insert)
Please insert 10 lei coin for 1 time :
(Press any key to insert)
Wait for your tips:
1.70 lei in 3 on 50 coins and 2 in 10 coins
