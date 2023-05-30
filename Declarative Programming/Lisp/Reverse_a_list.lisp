(defun reverse-list (lst)
  (if (null lst)
      nil
      (append (reverse-list (cdr lst)) (list (car lst)))))

(write (reverse-list '(1 2 3 4 5)))
