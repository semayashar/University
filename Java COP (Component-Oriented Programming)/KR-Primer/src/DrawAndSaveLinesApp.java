import javax.swing.*;
import java.awt.*;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.util.ArrayList;
import java.util.List;

class LineData {
    private Point startPoint;
    private Point endPoint;

    public LineData() {
        this.startPoint = new Point(0, 0);
        this.endPoint = new Point(0, 0);
    }

    public LineData(Point startPoint, Point endPoint) {
        this.startPoint = startPoint;
        this.endPoint = endPoint;
    }

    public Point getStartPoint() {
        return startPoint;
    }

    public Point getEndPoint() {
        return endPoint;
    }

    public void setStartPoint(Point p) {
        startPoint.x = p.x;
        startPoint.y = p.y;
    }

    public void setEndPoint(Point p) {
        endPoint.x = p.x;
        endPoint.y = p.y;
    }
}

class DrawingPanel extends JPanel {
    private LineData[] lines;
    private int currentIndex;
    private List<LineData> intersectionLines;

    private class MyMouseListener extends MouseAdapter {
        LineData currentLine;

        @Override
        public void mousePressed(MouseEvent e) {
            currentLine = new LineData();
            currentLine.setStartPoint(e.getPoint());
        }

        @Override
        public void mouseReleased(MouseEvent e) {
            currentLine.setEndPoint(e.getPoint());
            lines[currentIndex++] = currentLine;
            printLinesCoordinates(currentLine);
            repaint();
        }

        @Override
        public void mouseDragged(MouseEvent e) {
            currentLine.setEndPoint(e.getPoint());
            repaint();
        }
    }

    public void printLinesCoordinates(LineData currentLine) {
        System.out.println("Line " + (currentIndex) +
                ": Start(" + currentLine.getStartPoint().x + ", " + currentLine.getStartPoint().y +
                "), End(" + currentLine.getEndPoint().x + ", " + currentLine.getEndPoint().y + ")");
    }

    public DrawingPanel(int maxSize) {
        lines = new LineData[maxSize];
        currentIndex = 0;
        intersectionLines = new ArrayList<>();

        MyMouseListener mouseListener = new MyMouseListener();
        addMouseListener(mouseListener);
        addMouseMotionListener(mouseListener);
    }

    public void checkForIntersections() {
        for (int i = 0; i < currentIndex - 1; i++) {
            for (int j = i + 1; j < currentIndex; j++) {
                LineData line1 = lines[i];
                LineData line2 = lines[j];

                if (doLinesIntersect(line1, line2)) {
                    System.out.println("Lines " + (i + 1) + " and " + (j + 1) + " intersect.");
                    drawIntersectionLines(line1, line2);
                }
            }
        }
    }

    public void drawIntersectionLines(LineData line1, LineData line2) {
        intersectionLines.add(new LineData(line1.getStartPoint(), line2.getStartPoint()));
        intersectionLines.add(new LineData(line2.getStartPoint(), line1.getEndPoint()));
        intersectionLines.add(new LineData(line1.getEndPoint(), line2.getEndPoint()));
        intersectionLines.add(new LineData(line2.getEndPoint(), line1.getStartPoint()));
    }

    @Override
    public void paint(Graphics g) {
        super.paint(g);

        for (int i = 0; i < currentIndex; i++) {
            g.drawLine(lines[i].getStartPoint().x,
                    lines[i].getStartPoint().y,
                    lines[i].getEndPoint().x,
                    lines[i].getEndPoint().y);
        }

        for (LineData intersectionLine : intersectionLines) {
            g.drawLine(intersectionLine.getStartPoint().x,
                    intersectionLine.getStartPoint().y,
                    intersectionLine.getEndPoint().x,
                    intersectionLine.getEndPoint().y);
        }
        checkForIntersections();
    }

    public LineData[] getLines() {
        return lines;
    }

    static boolean doLinesIntersect(LineData firstLine, LineData secondLine) {
        double m1 = (firstLine.getEndPoint().y - firstLine.getStartPoint().y) / (firstLine.getEndPoint().x - firstLine.getStartPoint().x);
        double m2 = (secondLine.getEndPoint().y - secondLine.getStartPoint().y) / (secondLine.getEndPoint().x - secondLine.getStartPoint().x);

        if (m1 == m2) {
            return false;
        }

        double intersectionX = (m1 * firstLine.getStartPoint().x - m2 * secondLine.getStartPoint().x + secondLine.getStartPoint().y - firstLine.getStartPoint().y) / (m1 - m2);
        double intersectionY = m1 * (intersectionX - firstLine.getStartPoint().x) + firstLine.getStartPoint().y;

        boolean withinLine1 = isPointWithinLineSegment(intersectionX, intersectionY, firstLine);
        boolean withinLine2 = isPointWithinLineSegment(intersectionX, intersectionY, secondLine);

        return withinLine1 && withinLine2;
    }

    static boolean isPointWithinLineSegment(double x, double y, LineData line) {
        return (x >= Math.min(line.getStartPoint().x, line.getEndPoint().x) &&
                x <= Math.max(line.getStartPoint().x, line.getEndPoint().x) &&
                y >= Math.min(line.getStartPoint().y, line.getEndPoint().y) &&
                y <= Math.max(line.getStartPoint().y, line.getEndPoint().y));
    }
}

public class DrawAndSaveLinesApp {
    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            JFrame frame = new JFrame("Draw and Save Lines App");
            frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            frame.setSize(400, 400);

            DrawingPanel drawingPanel = new DrawingPanel(10);

            frame.getContentPane().setLayout(new BorderLayout());
            frame.getContentPane().add(drawingPanel, BorderLayout.CENTER);

            frame.setVisible(true);
        });
    }
}
