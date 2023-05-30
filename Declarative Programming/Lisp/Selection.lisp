(defun selection-sort (lst)
  (if (null lst)
      nil
      (let ((min-elem (reduce #'min lst))
            (rest (remove (reduce #'min lst) lst)))
        (cons min-elem (selection-sort rest)))))

(write (selection-sort '(5 2 4 1 3)))
