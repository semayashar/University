import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class DrawAndSaveLinesApp {
    private static JToolBar createToolBar(DrawingPanel drawingPanel, JFrame frame) {
        JToolBar toolBar = new JToolBar();

        JButton saveButton = new JButton("Save");
        saveButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                saveLinesToFile(drawingPanel.getLines());
            }
        });

        JButton newButton = new JButton("New");
        newButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                int option = JOptionPane.showConfirmDialog(null,
                        "Do you want to save the current drawing before creating a new one?",
                        "Save Confirmation", JOptionPane.YES_NO_CANCEL_OPTION);

                if (option == JOptionPane.YES_OPTION) {
                    saveLinesToFile(drawingPanel.getLines());
                } else if (option == JOptionPane.NO_OPTION) {
                    drawingPanel.clear();
                    drawingPanel.deleteIntersectionLines();
                    frame.setTitle("Draw and Save Lines App");
                }
            }
        });

        JButton openButton = new JButton("Open");
        openButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                int option = JOptionPane.showConfirmDialog(null,
                        "Do you want to save the current drawing before opening a file?",
                        "Save Confirmation", JOptionPane.YES_NO_CANCEL_OPTION);

                if (option == JOptionPane.YES_OPTION) {
                    saveLinesToFile(drawingPanel.getLines());
                } else if (option == JOptionPane.NO_OPTION) {
                    openFileAndLoadLines(drawingPanel);
                }
            }
        });

        toolBar.add(saveButton);
        toolBar.add(newButton);
        toolBar.add(openButton);

        return toolBar;
    }
    private static void openFileAndLoadLines(DrawingPanel drawingPanel) {
        JFileChooser fileChooser = new JFileChooser();
        int userSelection = fileChooser.showOpenDialog(null);

        if (userSelection == JFileChooser.APPROVE_OPTION) {
            try {
                File selectedFile = fileChooser.getSelectedFile();
                List<LineData> loadedLines = readLinesFromFile(selectedFile);
                drawingPanel.clear();
                drawingPanel.getLines().addAll(loadedLines);
                drawingPanel.repaint();
                JOptionPane.showMessageDialog(null, "Lines loaded from file: " + selectedFile.getAbsolutePath());
            } catch (IOException ex) {
                ex.printStackTrace();
                JOptionPane.showMessageDialog(null, "Error loading lines from file.");
            }
        }
    }

    private static List<LineData> readLinesFromFile(File file) throws IOException {
        List<LineData> loadedLines = new ArrayList<>();
        BufferedReader reader = new BufferedReader(new FileReader(file));

        String line;
        LineData currentLine = null;

        while ((line = reader.readLine()) != null) {
            if (line.startsWith("Line")) {
                currentLine = new LineData();
                loadedLines.add(currentLine);
                try {
                    String[] coordinates = line.substring(line.indexOf("(") + 1, line.indexOf(")")).split(", ");
                    if (coordinates.length == 4) {
                        currentLine.setStartPoint(new Point(Integer.parseInt(coordinates[0]), Integer.parseInt(coordinates[1])));
                        currentLine.setEndPoint(new Point(Integer.parseInt(coordinates[2]), Integer.parseInt(coordinates[3])));
                    } else {
                        // Handle invalid format for coordinates
                        System.err.println("Invalid number of coordinates for line: " + line);
                    }
                    for (int i = 0; i < loadedLines.size() - 1; i++) {
                        for (int j = i + 1; j < loadedLines.size(); j++) {
                            LineData line1 = loadedLines.get(i);
                            LineData line2 = loadedLines.get(j);

                            if (DrawingPanel.doLinesIntersect(line1, line2)) {
                                System.out.println("Lines " + (i + 1) + " and " + (j + 1) + " intersect.");
                                DrawingPanel.drawIntersectionLines(line1, line2);
                            }
                        }
                    }

                } catch (NumberFormatException | ArrayIndexOutOfBoundsException ex) {
                    // Handle invalid format for coordinates
                    ex.printStackTrace();
                }
            }
        }

        reader.close();
        return loadedLines;
    }


    private static void saveLinesToFile(List<LineData> lines) {
        JFileChooser fileChooser = new JFileChooser();
        int userSelection = fileChooser.showSaveDialog(null);

        if (userSelection == JFileChooser.APPROVE_OPTION) {
            try {
                String filePath = fileChooser.getSelectedFile().getAbsolutePath();
                BufferedWriter writer = new BufferedWriter(new FileWriter(filePath));

                for (LineData line : lines) {
                    writer.write("Line ");
                    writer.write("(" + line.getStartPoint().x + ", " + line.getStartPoint().y+ ", "  + line.getEndPoint().x + ", " + line.getEndPoint().y + ")");
                    writer.newLine();
                }

                writer.close();
                JOptionPane.showMessageDialog(null, "Lines saved to file: " + filePath);
            } catch (IOException ex) {
                ex.printStackTrace();
                JOptionPane.showMessageDialog(null, "Error saving lines to file.");
            }
        }
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            JFrame frame = new JFrame("Draw and Save Lines App");
            frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            frame.setSize(400, 400);

            DrawingPanel drawingPanel = new DrawingPanel();
            JToolBar toolBar = createToolBar(drawingPanel, frame);

            frame.getContentPane().setLayout(new BorderLayout());
            frame.getContentPane().add(toolBar, BorderLayout.NORTH);
            frame.getContentPane().add(drawingPanel, BorderLayout.CENTER);

            frame.setVisible(true);
        });
    }
}