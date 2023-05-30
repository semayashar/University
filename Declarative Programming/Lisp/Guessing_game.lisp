(defun play-guessing-game ()
  (let* ((target (random 100))
         (guesses 0)
         (game-over nil))
    (format t "Welcome to the Guessing Game!~%")
    (loop until game-over do
      (let* ((guess (read-from-string (read-line)))
             (guess-valid (and (integerp guess) (<= 1 guess 100))))
        (cond
          (guess-valid
           (incf guesses)
           (if (= guess target)
               (progn
                 (format t "Congratulations! You guessed the number in ~d guesses!~%" guesses)
                 (setq game-over t))
               (if (> guess target)
                   (format t "Too high. Try again.~%")
                   (format t "Too low. Try again.~%"))))
          (t (format t "Invalid input. Please enter a number between 1 and 100.~%")))))))
