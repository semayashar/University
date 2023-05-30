(defun sorted? (lst)
  (if (or (null lst) (null (cdr lst)))
      t
      (and (<= (car lst) (cadr lst)) (sorted? (cdr lst)))))

(write (sorted? '(1 2 3 4 5)))
