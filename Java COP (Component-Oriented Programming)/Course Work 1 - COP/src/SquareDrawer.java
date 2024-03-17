import javax.swing.*;
import java.awt.*;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;

class Square {
    int x1, y1, x2, y2;

    public Square(int x1, int y1, int x2, int y2) {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }
}

public class SquareDrawer extends JPanel {
    private ArrayList<Square> squares;

    public SquareDrawer(ArrayList<Square> squares) {
        this.squares = squares;
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        for (Square square : squares) {
            g.drawRect(square.x1, square.y1, square.x2 - square.x1, square.y2 - square.y1);
        }
    }

    public static void main(String[] args) {
        /*
        --------------------------------УСЛОВИЕ-----------------------------------
        1.17. В един текстов файл са зададени данни за квадрати, имащи страни
        съответно успоредни на координатните оси. На първия ред е число,
        указващо броя на фигурите, а на следващите редове са данните за тях.
        В един ред са данните х и Y за горната лява точка, последвани от Х и Y
        за долната дясна точка. Като разделител служи интервал. Да се състави
        Application на Java за прочитане на този файл и за графично представяне
        на квадратите.
        --------------------------------------------------------------------------
        */

        ArrayList<Square> squares = new ArrayList<>();

        // Въвеждане на информацията за квадратите от конзолата
        Scanner scanner = new Scanner(System.in);
        System.out.print("Брой на квадратите: ");
        int numSquares = scanner.nextInt();

        for (int i = 0; i < numSquares; i++) {
            System.out.print("Въведете координати за квадрат " + (i + 1) + " (x1 y1 x2 y2): ");
            int x1 = scanner.nextInt();
            int y1 = scanner.nextInt();
            int x2 = scanner.nextInt();
            int y2 = scanner.nextInt();
            squares.add(new Square(x1, y1, x2, y2));
        }

        // Създаване на файл "squares_info" и запис на информацията
        try {
            FileWriter writer = new FileWriter("squares_info.txt");
            writer.write(numSquares + "\n");
            for (Square square : squares) {
                writer.write(square.x1 + " " + square.y1 + " " + square.x2 + " " + square.y2 + "\n");
            }
            writer.close();
        } catch (IOException e) {
            e.printStackTrace();
        }

        // Създаване на графично прозорец и изчертаване на квадратите
        JFrame frame = new JFrame("Square Drawer");
        SquareDrawer squareDrawer = new SquareDrawer(squares);
        frame.add(squareDrawer);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(500, 500);
        frame.setVisible(true);
    }
}
