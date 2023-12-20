import java.awt.*;

class LineData {
    private Point startPoint;
    private Point endPoint;
    private Color lineColor;

    public LineData() {
        this(new Point(0, 0), new Point(0, 0));
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

    public void setStartPoint(Point startPoint) {
        this.startPoint.setLocation(startPoint);
    }

    public void setEndPoint(Point endPoint) {
        this.endPoint.setLocation(endPoint);
    }

    public void rotate90Degrees(Point intersectionPoint) {
        // Translate the line to the origin
        double startX = startPoint.x - intersectionPoint.x;
        double startY = startPoint.y - intersectionPoint.y;
        double endX = endPoint.x - intersectionPoint.x;
        double endY = endPoint.y - intersectionPoint.y;

        // Rotate the line by 90 degrees
        double rotatedStartX = -startY;
        double rotatedStartY = startX;
        double rotatedEndX = -endY;
        double rotatedEndY = endX;

        // Translate the rotated line back to its original position
        double originalStartX = rotatedStartX + intersectionPoint.x;
        double originalStartY = rotatedStartY + intersectionPoint.y;
        double originalEndX = rotatedEndX + intersectionPoint.x;
        double originalEndY = rotatedEndY + intersectionPoint.y;

        // Update the endpoints
        startPoint.setLocation(originalStartX, originalStartY);
        endPoint.setLocation(originalEndX, originalEndY);
    }

    public void clear() {
        this.startPoint.setLocation(0, 0);
        this.endPoint.setLocation(0, 0);
    }

}
