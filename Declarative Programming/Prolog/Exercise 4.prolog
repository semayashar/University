/*apnd1([], L2, L2).
apnd1(L1, [], L1).
apnd1([H1|T1], L, [H3|T3]):- H3 is H1, apnd2(T1, L, T3).

apnd2([], L2, L2).
apnd2(L1, [], L1).
apnd2(L, [H2|T2], [H3|T3]):- H3 is H2, apnd1(L, T2, T3).

print_list([]):-nl.
print_list([H|T]):-write(H),write(" "), print_list(T).

?- apnd1([1, 3, 5, 7, 9, 10], [2, 4, 6, 8], L), print_list(L).

length([],0).
length([H|T],L):�length(T,L1), L is L1+1.

?- len([1, 2, 3, 5, 7, 8], L).

mem(_, []):- fail.
mem(A, [A|T]):- write("yes. "), !.
mem(A,[_|T]):- write("no, "), mem(A,T).

?- mem(5, [1, 2, 3, 5, 7, 8]).

change_el (_,_,[], []).
change_el (X,Y,[X|T], [Y|T1]):- change_el(X,Y,T,T1) .
change_el (X,Y,[H|T], [H|T1]):- change_el(X,Y,T,T1).

?- ch(5, 0, [1, 2, 5, 3, 2, 5, 3, 1, 5, 6]).

multtable:- L =[1,2,3,4,5,6,7,8,9], 
			member(X,L), member(Y,L),
			Z is X * Y, assert(mult(X,Y,Z)), write(X + "*" + Y + "=" + Z).
?- multtable.

student(ani, 026345). student(ivo, 026321).
student(peter, 026225). student(elen, 026123).
student(asen, 026145). student(vasil, 026223).
student(galja, 026213).
exam(026345,mat,5). exam(026345,progr,5).
exam(026321,mat,4). exam(026321,progr,5).
exam(026123,mat,6). exam(026123,progr,6).
exam(026225,mat,2). exam(026225,progr,3).
exam(026145,mat,2). exam(026145,progr,2).
exam(026223,mat,6). exam(026223,progr,6).
exam(026213,mat,3). exam(026213,progr,4).

take(FN, SBJ):- exam(FN, SBJ, GRD), GRD > 2.
collect(NM, L):- student(NM, FN), findall(SBJ, take(FN,SBJ),L).

person(ani, 19). 
person(simeon, 19).
person(petur, 23).
person(mladen, 39).
person(ivailo, 39). 
person(stefan, 9).
person(monika, 9). 
person(violina, 20).
person(angelo, 13). 
person(jaklin, 22).
person(georgi, 19). 
person(paolina, 23).

town(ani, ruse). 
town(simeon, ruse).
town(petur, varna). 
town(mladen, burgas).
town(ivailo, burgas). 
town(stefan, svishtov).
town(monika, svishtov). 
town(violina, ruse).
town(angelo, gabrovo). 
town(jaklin, ruse).
town(georgi, ruse). 
town(paolina, varna).

isFrom(N, T):- town(N, T).
isOld(N, A):- person(N, A1), A1 > A.
%collect(A, T, L):- person(NM, A), findall(NM, isOld(NM, A), isFrom(NM, T), L).
collect(A, T, L) :- findall(NM, (isOld(NM, A), town(NM, T)), L).

print_list([]):-nl.
print_list([H|T]):-write(H),write(" "),print_list(T).

?- collect(18, ruse, L), print_list(L).

meal(palachinki, need(eggs, flour, milk, oil, salt)).
meal(cake, need(eggs, flour, milk, oil, sugar, vanile, bakvulver)).
meal(manja, need(meat, oil, garlic, water, onion, spices)).
meal(boiledEggs, need(eggs, water)).
meal(pasta, need(ppasta, water, salt, oil)).

weHave(eggs, oil, milk, water, sugar, garlic, flour, salt, ppasta).

canCook(Meal) :-
  meal(Meal, need(Ingredients)),
  forall(member(Ingredient, Ingredients), weHave(Ingredient)).

cookableMeals(Meals) :-
  findall(Meal, canCook(Meal), Meals).

book("Hello", "J.K. Rowling", 2002, 21000, 110).
book("It", "Lyuben Karavellov", 2022, 1000, 110).
book("IS", "Jake SP.", 2001, 2000, 110).
book("me", "J.K. Rowling", 2032, 210, 110).
book("!", "J.K. Rowling", 2012, 2100, 110).

print_books([]) :-
    write("No books.").
print_books([(Title, Pages)|Rest]) :-
	write("Book: "), write(Title), nl, 
	write("Pages: "), write(Pages), nl,
	nl, print_books(Rest).

author_books(Author) :-
    findall((Title, Pages), book(Title, Author, _, Pages, _), Books),
    print_books(Books).*/



