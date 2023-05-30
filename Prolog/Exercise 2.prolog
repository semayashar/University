magazine("vsichko za jenata",publisher("IDG",sofia),3.90).
magazine("Neshto",publisher("NILA",carna),2.50).
magazine("sdta",publisher("IDG",ruse),1.90).
two_magazines(X):�magazine(Y,publisher(X,_),_),
magazine(Z,publisher(X,_),_), Y\=Z.
/*?- magazine(X, publisher(IDG, _), _), write(X), nl.
?- magazine(X, publisher(_, _), Y), Y<3, write(X), nl.
?-magazine(Y,publisher(X,_),Z), Z < 3,write(Y),nl.
?- magazine(Y, publisher(_,sofia),_), write(Y), nl.
?- two_magazines(Y), write(Y),nl.
?- magazine(Y,publisher(_,sofia),_), write(Y),nl.
?- magazine(Y, publisher(_, T), _), T \= ruse, write(Y), nl.
?- magazine(Y, publisher(T, _), _), T \= "IDG", write(Y), nl.*/