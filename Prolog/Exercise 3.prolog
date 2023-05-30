/*fun(X,Y,D):- X < Y, D is X * 2, write("D is "), write(D), nl.
fun(X,Y,D):- X > Y, D is Y * 2, write("D is "), write(D), nl. 
fun(X,Y,X):- X == Y, write("D is "), write(X), nl.

?- fun(1,3,D).
?- fun(5,3,D).
?- fun(1,1,D).

fun(X, Y, S):-integer(X), integer(Y), S is X+Y,
			write("Sum is "), write(S), nl.
?- fun(1,3,D).
?- fun(5,-3,D).
?- fun(1.5,-2,D).

fun(X,Y):- X >= -20, X =< 10,
		 Y is X-4,
		 write("Res is "), write(Y), nl.
fun(X,Y):- X > 10, X =< 20,
		 Y is 10/((X*X)+5),
		 write("Res is "), write(Y), nl.
fun(X,-1):- write("Res is -1."), nl.

?- fun(3, X).
?- fun(15, X).
?- fun(40, X).*/







