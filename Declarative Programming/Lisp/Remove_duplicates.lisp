(defun remove-duplicates (lst)
  (cond ((null lst) nil)
        ((member (car lst) (cdr lst)) (remove-duplicates (cdr lst)))
        (t (cons (car lst) (remove-duplicates (cdr lst))))))

(write (remove-duplicates '(1 2 3 2 4 5 3)))
