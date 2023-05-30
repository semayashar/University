(defun prime? (n)
  (cond ((<= n 1) nil)
        ((= n 2) t)
        ((evenp n) nil)
        (t (loop for i from 3 to (isqrt n) by 2
                 never (zerop (mod n i))))))

(write (prime? 17))
