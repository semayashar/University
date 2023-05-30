(defun sum-list (lst)
  (if (null lst)
      0
      (+ (car lst) (sum-list (cdr lst)))))

(write (sum-list '(1 2 3 4 5)))
