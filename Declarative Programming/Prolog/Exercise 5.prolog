man("Ivelina", 18, f, 3)
man("Petur", 20, m, 3)
man("Paolina", 18, f, 3)
man("Stefan", 19, m, 3)
man("Penya", 23, f, 3)
man("Gosho", 24, m, 3)
isLegit(A):- man(_, A1, _, _), A1>A.
isLegit1:- man(_, _, f, _).

find(A, L)- findall((name, age, sex, prob), 
				(isLegit(20), isLegit1), L).