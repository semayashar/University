import javax.swing.*;
import java.awt.*;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

public class DrawPointsAndConnect extends JFrame {
    private Point[] points = new Point[4];
    private int pointCount = 0;

    public DrawPointsAndConnect() {
        setTitle("Draw Points and Connect");
        setSize(400, 400);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLocationRelativeTo(null);

        addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                if (pointCount < 4) {
                    points[pointCount++] = e.getPoint();
                    repaint();
                }
            }
        });
    }

    @Override
    public void paint(Graphics g) {
        super.paint(g);

        // Draw points
        g.setColor(Color.BLACK);
        for (int i = 0; i < pointCount; i++) {
            g.fillOval(points[i].x - 5, points[i].y - 5, 10, 10);
        }

        // Connect points
        g.setColor(Color.RED);
        if (pointCount == 4) {
            for (int i = 0; i < 3; i++) {
                g.drawLine(points[i].x, points[i].y, points[i + 1].x, points[i + 1].y);
            }
            g.drawLine(points[3].x, points[3].y, points[0].x, points[0].y);

            // Fill the figure with color
            int[] xPoints = new int[4];
            int[] yPoints = new int[4];
            for (int i = 0; i < 4; i++) {
                xPoints[i] = points[i].x;
                yPoints[i] = points[i].y;
            }
            g.setColor(Color.YELLOW); // Set your desired fill color
            g.fillPolygon(xPoints, yPoints, 4);
        }
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            DrawPointsAndConnect drawPointsAndConnect = new DrawPointsAndConnect();
            drawPointsAndConnect.setVisible(true);
        });
    }
}
