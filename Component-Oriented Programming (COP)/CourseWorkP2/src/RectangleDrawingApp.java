import javax.swing.*;
import java.awt.*;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.util.ArrayList;
import java.util.List;

public class RectangleDrawingApp extends JFrame {
    private int rectangleWidth;
    private int rectangleHeight;
    private final int pointRadius = 5;
    private Point selectedPoint = null;
    private List<Point> pointsInsideRectangle = new ArrayList();

    public RectangleDrawingApp(int width, int height) {
        rectangleWidth = width;
        rectangleHeight = height;

        setTitle("Rectangle Drawing App");
        setSize(600, 400);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLocationRelativeTo(null);

        addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                if (SwingUtilities.isLeftMouseButton(e)) {
                    int x = e.getX();
                    int y = e.getY();

                    if (isPointInsideRectangle(x, y)) {
                        pointsInsideRectangle.add(new Point(x, y));
                        repaint();
                    }
                }
            }
        });
    }

    private boolean isPointInsideRectangle(int x, int y) {
        int rectX = (getWidth() - rectangleWidth) / 2;
        int rectY = (getHeight() - rectangleHeight) / 2;

        return x >= rectX + pointRadius && x <= rectX + rectangleWidth - pointRadius
                && y >= rectY + pointRadius && y <= rectY + rectangleHeight - pointRadius;
    }

    @Override
    public void paint(Graphics g) {
        super.paint(g);

        int rectX = (getWidth() - rectangleWidth) / 2;
        int rectY = (getHeight() - rectangleHeight) / 2;

        g.setColor(Color.BLUE);
        g.drawRect(rectX, rectY, rectangleWidth, rectangleHeight);

        for (Point point : pointsInsideRectangle) {
            g.setColor(Color.RED);
            g.fillOval(point.x - pointRadius, point.y - pointRadius, 2 * pointRadius, 2 * pointRadius);
        }
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            int width = Integer.parseInt(JOptionPane.showInputDialog("Enter the rectangle width:"));
            int height = Integer.parseInt(JOptionPane.showInputDialog("Enter the rectangle height:"));
            RectangleDrawingApp app = new RectangleDrawingApp(width, height);
            app.setVisible(true);
        });
    }
}
