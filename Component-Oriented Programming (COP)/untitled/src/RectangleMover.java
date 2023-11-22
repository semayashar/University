import java.awt.Color;
import java.awt.Graphics;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.JFrame;
import javax.swing.JPanel;

public class RectangleMover extends JFrame {

    private int rectangleX = 50;
    private int rectangleY = 50;
    private int rectangleWidth = 100;
    private int rectangleHeight = 50;
    private boolean isDragging = false;
    private int dragOffsetX, dragOffsetY;

    public RectangleMover() {
        setTitle("Rectangle Mover");
        setSize(400, 400);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        MyPanel panel = new MyPanel();
        panel.addMouseListener(new MyMouseListener());
        panel.addMouseMotionListener(new MyMouseMotionListener());
        add(panel);
    }

    private class MyPanel extends JPanel {
        @Override
        protected void paintComponent(Graphics g) {
            super.paintComponent(g);
            g.setColor(Color.BLUE);
            g.fillRect(rectangleX, rectangleY, rectangleWidth, rectangleHeight);
        }
    }

    private class MyMouseListener extends MouseAdapter {
        @Override
        public void mousePressed(MouseEvent e) {
            if (e.getX() >= rectangleX && e.getX() <= rectangleX + rectangleWidth
                    && e.getY() >= rectangleY && e.getY() <= rectangleY + rectangleHeight) {
                isDragging = true;
                dragOffsetX = e.getX() - rectangleX;
                dragOffsetY = e.getY() - rectangleY;
            }
        }

        @Override
        public void mouseReleased(MouseEvent e) {
            isDragging = false;
        }
    }

    private class MyMouseMotionListener extends MouseAdapter {
        @Override
        public void mouseDragged(MouseEvent e) {
            if (isDragging) {
                rectangleX = e.getX() - dragOffsetX;
                rectangleY = e.getY() - dragOffsetY;
                repaint();
            }
        }
    }

    public static void main(String[] args) {
        java.awt.EventQueue.invokeLater(() -> {
            new RectangleMover().setVisible(true);
        });
    }
}
