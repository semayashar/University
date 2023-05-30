;Създаване на обект, представляващ филм:
(defun make_film (name_film director_film screenwriter_film actors_film)
  (setf (get name_film 'name) name_film)
  (setf (get name_film 'director) director_film)
  (setf (get name_film 'screenwriter) screenwriter_film)
  (setf (get name_film 'actors) actors_film)
  name_film)

;Създава нов обект за всяка една от филмите и ги добавя в списъка от филми:
(defun create-films (L)
  (loop
   (princ "Enter film name: ") (setq name_f (intern (read-line)))
   (princ "Enter director: ") (setq director_f (read-line))
   (princ "Enter screenwriter: ") (setq screenwriter_f (read-line))
   (princ "Enter actor 1: ") (setq actor1 (read-line))
   (princ "Enter actor 2: ") (setq actor2 (read-line))
   (princ "Enter actor 3: ") (setq actor3 (read-line))
   (princ "Enter actor 4: ") (setq actor4 (read-line))
   (princ "Enter actor 5: ") (setq actor5 (read-line))
   (setq L (append L (list (make_film name_f director_f screenwriter_f (list actor1 actor2 actor3 actor4 actor5)))))
   (loop
   (format t "Do you want to continue? (yes/no): ")
      (let ((response (read)))
       (cond ((equal response 'YES) (return T))
             ((equal response 'NO) (return-from create-films L))
             (t (format t "Invalid response. Please enter 'yes' or 'no'.~%")))))))

;Принтиране на списък от филми:
 (defun print-films (films)
  (dolist (film films)
    (format t "Film: ~a~%" (get film 'name))
    (format t "Director: ~a~%" (get film 'director))
    (format t "Screenwriter: ~a~%" (get film 'screenwriter))
    (format t "Actors: ~{~a~^, ~}~% " (get film 'actors))))

;Намиране на филмите, които даден актьор е играл:
(defun print-films-actor-plays (films name)
  (dolist (film films)
    (dolist (actor (get film 'actors))
      (if (string= actor name)
          (format t "~a~%" (get film 'name))))))
