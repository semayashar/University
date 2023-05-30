(defun list-length (lst)
  (if (null lst)
      0
      (+ 1 (list-length (cdr lst)))))

(write (list-length '(1 2 3 4 5)))
