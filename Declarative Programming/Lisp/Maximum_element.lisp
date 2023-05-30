(defun find-max (lst)
  (if (null (cdr lst))
      (car lst)
      (max (car lst) (find-max (cdr lst)))))

(write (find-max '(1 2 3 4 5)))
