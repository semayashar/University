(defun factorial (n)
  (if (zerop n)
      1
      (* n (factorial (- n 1)))))

(write (factorial 5))
