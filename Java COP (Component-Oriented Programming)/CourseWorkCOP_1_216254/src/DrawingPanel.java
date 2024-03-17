import javax.swing.*;
import java.awt.*;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.util.ArrayList;
import java.util.List;

public class DrawingPanel extends JPanel {

    private List<LineData> lines;
    private static List<LineData> intersectionLines;
    public List<LineData> getLines() {
        return lines;
    }

    public DrawingPanel() {
        lines = new ArrayList<>();
        intersectionLines = new ArrayList<>();

        MyMouseListener mouseListener = new MyMouseListener();
        addMouseListener(mouseListener);
        addMouseMotionListener(mouseListener);
    }
    private class MyMouseListener extends MouseAdapter {
        private LineData currentLine;

        @Override
        public void mousePressed(MouseEvent e) {
            if (SwingUtilities.isLeftMouseButton(e)) {
                currentLine = new LineData(e.getPoint(), e.getPoint());
            } else if (SwingUtilities.isRightMouseButton(e)) {
                selectLineAt(e.getPoint());
            }
        }
        @Override
        public void mouseReleased(MouseEvent e) {
            if (SwingUtilities.isLeftMouseButton(e)) {
                currentLine.setEndPoint(e.getPoint());
                lines.add(currentLine);
                printLinesCoordinates(currentLine);
                checkForIntersections();
                repaint();
            }
        }
        @Override
        public void mouseDragged(MouseEvent e) {
            if (SwingUtilities.isLeftMouseButton(e)) {
                currentLine.setEndPoint(e.getPoint());
                repaint();
            }
        }
        private void selectLineAt(Point point) {
            LineData selectedLine = null;

            // Find the selected line
            for (LineData line : lines) {
                if (isPointWithinLineSegment(point.x, point.y, line)) {
                    selectedLine = line;
                    break;
                }
            }
            if (selectedLine != null) {
                boolean hasIntersections = false;

                // Check for intersections with other lines
                for (LineData line : lines) {
                    if (line != selectedLine && doLinesIntersect(selectedLine, line)) {
                        hasIntersections = true;
                        break;
                    }
                }
                if (!hasIntersections) {
                    // If no intersections, rotate the line around its center
                    Point center = new Point(
                            (selectedLine.getStartPoint().x + selectedLine.getEndPoint().x) / 2,
                            (selectedLine.getStartPoint().y + selectedLine.getEndPoint().y) / 2
                    );
                    selectedLine.rotate90Degrees(center);
                    repaint();
                }
            }

            if (selectedLine != null) {
                // Check for intersections with the rotated line and paint intersecting lines in red
                for (LineData line : lines) {
                    if (line != selectedLine && doLinesIntersect(selectedLine, line)) {

                        Point intersectionPoint = DrawingPanel.findIntersectionPoint(selectedLine, line);
                        // Rotate the other lines by 90 degrees around the intersection point
                        selectedLine.rotate90Degrees(intersectionPoint);
                        line.rotate90Degrees(intersectionPoint);
                    }
                }
                repaint();
            }
            if (selectedLine != null) {
                // Check for intersections with the selected line and paint intersecting lines in red
                for (LineData line : lines) {
                    if (line != selectedLine && doLinesIntersect(selectedLine, line)) {
                        // Rotate the lines by 90 degrees
                        drawIntersectionLines(selectedLine, line);
                    }
                }
                repaint();
            }
        }
    }

    public void printLinesCoordinates(LineData currentLine) {
        System.out.println("Line " + (lines.size()) +
                ": Start(" + currentLine.getStartPoint().x + ", " + currentLine.getStartPoint().y +
                "), End(" + currentLine.getEndPoint().x + ", " + currentLine.getEndPoint().y + ")");
    }

    public void checkForIntersections() {
        for (int i = 0; i < lines.size() - 1; i++) {
            for (int j = i + 1; j < lines.size(); j++) {
                LineData line1 = lines.get(i);
                LineData line2 = lines.get(j);

                if (doLinesIntersect(line1, line2)) {
                    System.out.println("Lines " + (i + 1) + " and " + (j + 1) + " intersect.");
                    drawIntersectionLines(line1, line2);
                }
            }
        }
    }

    public static Point findIntersectionPoint(LineData firstLine, LineData secondLine) {
        double x1 = firstLine.getStartPoint().x;
        double y1 = firstLine.getStartPoint().y;
        double x2 = firstLine.getEndPoint().x;
        double y2 = firstLine.getEndPoint().y;

        double x3 = secondLine.getStartPoint().x;
        double y3 = secondLine.getStartPoint().y;
        double x4 = secondLine.getEndPoint().x;
        double y4 = secondLine.getEndPoint().y;

        double denominator = (x1 - x2) * (y3 - y4) - (y1 - y2) * (x3 - x4);

        // Check if lines are parallel
        if (denominator == 0) {
            return null; // Lines are parallel, no intersection point
        }

        double numerator1 = (x1 * y2 - y1 * x2) * (x3 - x4) - (x1 - x2) * (x3 * y4 - y3 * x4);
        double numerator2 = (x1 * y2 - y1 * x2) * (y3 - y4) - (y1 - y2) * (x3 * y4 - y3 * x4);

        double intersectionX = numerator1 / denominator;
        double intersectionY = numerator2 / denominator;

        Point intersectionPoint = new Point((int) intersectionX, (int) intersectionY);

        if (isPointWithinLineSegment(intersectionX, intersectionY, firstLine)
                && isPointWithinLineSegment(intersectionX, intersectionY, secondLine)) {
            return intersectionPoint;
        } else {
            return null; // Intersection point is not within line segments
        }
    }

    public static void drawIntersectionLines(LineData line1, LineData line2) {
        intersectionLines.add(new LineData(line1.getStartPoint(), line2.getStartPoint()));
        intersectionLines.add(new LineData(line2.getStartPoint(), line1.getEndPoint()));
        intersectionLines.add(new LineData(line1.getEndPoint(), line2.getEndPoint()));
        intersectionLines.add(new LineData(line2.getEndPoint(), line1.getStartPoint()));
    }
    void deleteIntersectionLines() {
        for (LineData line : intersectionLines) {
            // Assuming LineData has a clear method, replace it with the correct method
            line.clear(); // Make sure your LineData class has a clear method
        }
        intersectionLines.clear(); // Clear the list after clearing individual lines
        repaint();
    }


    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);

        for (LineData line : lines) {
            g.drawLine(line.getStartPoint().x, line.getStartPoint().y, line.getEndPoint().x, line.getEndPoint().y);
        }

        for (LineData intersectionLine : intersectionLines) {
            g.drawLine(intersectionLine.getStartPoint().x, intersectionLine.getStartPoint().y,
                    intersectionLine.getEndPoint().x, intersectionLine.getEndPoint().y);
        }
    }

    static boolean doLinesIntersect(LineData firstLine, LineData secondLine) {
        double x1 = firstLine.getStartPoint().x;
        double y1 = firstLine.getStartPoint().y;
        double x2 = firstLine.getEndPoint().x;
        double y2 = firstLine.getEndPoint().y;

        double x3 = secondLine.getStartPoint().x;
        double y3 = secondLine.getStartPoint().y;
        double x4 = secondLine.getEndPoint().x;
        double y4 = secondLine.getEndPoint().y;

        double denominator = (x1 - x2) * (y3 - y4) - (y1 - y2) * (x3 - x4);

        // Check if lines are parallel
        if (denominator == 0) {
            return false;
        }

        double numerator1 = (x1 * y2 - y1 * x2) * (x3 - x4) - (x1 - x2) * (x3 * y4 - y3 * x4);
        double numerator2 = (x1 * y2 - y1 * x2) * (y3 - y4) - (y1 - y2) * (x3 * y4 - y3 * x4);

        double intersectionX = numerator1 / denominator;
        double intersectionY = numerator2 / denominator;

        return isPointWithinLineSegment(intersectionX, intersectionY, firstLine)
                && isPointWithinLineSegment(intersectionX, intersectionY, secondLine);
    }

    static double calculateSlope(LineData line) {
        return (line.getEndPoint().y - line.getStartPoint().y) / (line.getEndPoint().x - line.getStartPoint().x);
    }

    static double calculateIntersectionX(LineData firstLine, LineData secondLine, double m1, double m2) {
        return (m1 * firstLine.getStartPoint().x - m2 * secondLine.getStartPoint().x +
                secondLine.getStartPoint().y - firstLine.getStartPoint().y) / (m1 - m2);
    }

    static double calculateIntersectionY(LineData line, double intersectionX) {
        return line.getStartPoint().y + calculateSlope(line) * (intersectionX - line.getStartPoint().x);
    }

    static boolean isPointWithinLineSegment(double x, double y, LineData line) {
        return (x >= Math.min(line.getStartPoint().x, line.getEndPoint().x) &&
                x <= Math.max(line.getStartPoint().x, line.getEndPoint().x) &&
                y >= Math.min(line.getStartPoint().y, line.getEndPoint().y) &&
                y <= Math.max(line.getStartPoint().y, line.getEndPoint().y));
    }

    public void clear() {
        lines.clear();
        repaint();
    }
}
