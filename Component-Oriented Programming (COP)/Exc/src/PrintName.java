import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class PrintName extends JFrame implements ActionListener {
    private JTextField nameField1;
    private JButton saveButton;
    private JComboBox<String> colorComboBox;  // Added JComboBox for selecting colors
    private String name = "";
    private Color[] colorOptions = {Color.RED, Color.BLUE, Color.GREEN, Color.YELLOW, Color.BLACK}; // Predefined color options

    public PrintName() {
        super("Print Name");
        setSize(600, 400);
        setLocation(200, 100);
        setBackground(Color.LIGHT_GRAY);

        // Create and add text fields for input
        nameField1 = new JTextField(20);

        // Create a button for saving names
        saveButton = new JButton("Save Name");
        saveButton.addActionListener(this);

        // Create a combo box for selecting colors
        colorComboBox = new JComboBox<>();
        for (Color color : colorOptions) {
            colorComboBox.addItem(getColorName(color));
        }
        colorComboBox.addActionListener(this);

        // Create a layout to organize components
        setLayout(new FlowLayout());

        // Add components to the frame
        add(nameField1);
        add(saveButton);
        add(colorComboBox);

        // Set default close operation
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        setVisible(true);
    }

    private String getColorName(Color color) {
        // Helper method to get a human-readable name for a color
        if (color.equals(Color.RED)) return "Red";
        else if (color.equals(Color.BLUE)) return "Blue";
        else if (color.equals(Color.GREEN)) return "Green";
        else if (color.equals(Color.YELLOW)) return "Yellow";
        else if (color.equals(Color.BLACK)) return "Black";
        else return "Unknown";
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            new PrintName();
        });
    }

    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == saveButton) {
            // Retrieve text from the text field and save it to the 'name' variable
            name = nameField1.getText();

            // Clear the text field
            nameField1.setText("");
            nameField1.hide();
            colorComboBox.hide();
            saveButton.hide();

            // Repaint the frame to draw the name
            repaint();
        } else if (e.getSource() == colorComboBox) {
            // Change the main color when a new color is selected from the combo box
            int selectedIndex = colorComboBox.getSelectedIndex();
            if (selectedIndex >= 0 && selectedIndex < colorOptions.length) {
                Color selectedColor = colorOptions[selectedIndex];
                repaint();
            }
        }
    }

    public void paint(Graphics g) {
        super.paint(g); // Call super.paint to ensure proper painting

        // Draw the name in the center of the frame with the selected main color
        g.setColor(Color.GRAY);
        g.setFont(new Font("Times New Roman", Font.ITALIC, 50));

        FontMetrics gm = g.getFontMetrics();
        int x = (getWidth() - gm.stringWidth(name)) / 2;
        int y = getHeight() / 2;
        g.drawString(name, x+2, y+2);

        //Shadow
        g.setColor(getSelectedColor());
        g.setFont(new Font("Times New Roman", Font.ITALIC, 50));

        FontMetrics fm = g.getFontMetrics();
        x = (getWidth() - fm.stringWidth(name)) / 2;
        y = getHeight() / 2;
        g.drawString(name, x, y);

    }

    private Color getSelectedColor() {
        // Helper method to get the currently selected color from the combo box
        int selectedIndex = colorComboBox.getSelectedIndex();
        if (selectedIndex >= 0 && selectedIndex < colorOptions.length) {
            return colorOptions[selectedIndex];
        } else {
            // Default to red if no valid selection is made
            return Color.RED;
        }
    }
}
