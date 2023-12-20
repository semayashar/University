import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.io.*;
import java.util.ArrayList;

class SceneObject {
    // Клас, представляващ общата структура на всички обекти в сцената
    // Можете да добавите други полета, ако са необходими
}

class Line extends SceneObject {
    Point start;
    Point end;

    Line(Point start, Point end) {
        this.start = start;
        this.end = end;
    }
}

class Rectangle extends SceneObject {
    Point topLeft;
    Point bottomRight;

    Rectangle(Point topLeft, Point bottomRight) {
        this.topLeft = topLeft;
        this.bottomRight = bottomRight;
    }
}

class DrawingPanel extends JPanel {
    private ArrayList<SceneObject> sceneObjects = new ArrayList<>();

    DrawingPanel() {
        setBackground(Color.white);

        // Добавяне на слушатели за мишка
        addMouseListener(new MouseAdapter() {
            @Override
            public void mousePressed(MouseEvent e) {
                // Обработка на натискане на левия или десния бутон на мишката
                if (e.getButton() == MouseEvent.BUTTON1) {
                    // Левият бутон - добавяне на отсечка или правоъгълник
                    // Имплементирайте логиката за добавяне на обекти към сцената
                } else if (e.getButton() == MouseEvent.BUTTON3) {
                    // Десният бутон - завъртане на фигурата на 90 градуса
                    // Имплементирайте логиката за завъртане
                }
            }
        });
    }

    // Имплементирайте методи за добавяне на обекти към сцената и за завъртане на фигурата
    // ...

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);

        // Имплементирайте логиката за рисуване на сцената
    }

    public void saveSceneToFile(String filename) {
        // Имплементирайте логиката за съхраняване на сцената във файл
    }

    public void loadSceneFromFile(String filename) {
        // Имплементирайте логиката за зареждане на сцената от файл
    }
}

public class SceneEditor extends JFrame {
    private DrawingPanel drawingPanel;

    public SceneEditor() {
        setTitle("Scene Editor");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setSize(800, 600);

        drawingPanel = new DrawingPanel();
        getContentPane().add(drawingPanel, BorderLayout.CENTER);

        // Добавяне на меню
        JMenuBar menuBar = new JMenuBar();
        setJMenuBar(menuBar);

        JMenu fileMenu = new JMenu("File");
        menuBar.add(fileMenu);

        JMenuItem newMenuItem = new JMenuItem("New");
        newMenuItem.addActionListener(e -> handleNew());
        fileMenu.add(newMenuItem);

        JMenuItem saveMenuItem = new JMenuItem("Save");
        saveMenuItem.addActionListener(e -> handleSave());
        fileMenu.add(saveMenuItem);

        JMenuItem loadMenuItem = new JMenuItem("Load");
        loadMenuItem.addActionListener(e -> handleLoad());
        fileMenu.add(loadMenuItem);
    }

    private void handleNew() {
        // Имплементирайте логиката за нова сцена
    }

    private void handleSave() {
        // Имплементирайте логиката за съхраняване на сцената
    }

    private void handleLoad() {
        // Имплементирайте логиката за зареждане на сцената
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            SceneEditor editor = new SceneEditor();
            editor.setVisible(true);
        });
    }
}
