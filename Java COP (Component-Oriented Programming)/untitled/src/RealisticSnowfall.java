import javafx.animation.AnimationTimer;
import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.layout.StackPane;
import javafx.stage.Stage;
import javafx.scene.paint.Color;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class RealisticSnowfall extends Application {
    private List<Snowflake> snowflakes;

    public static void main(String[] args) {
        launch(args);
    }

    @Override
    public void start(Stage primaryStage) {
        primaryStage.setTitle("Realistic Snowfall");

        snowflakes = new ArrayList<>();

        Canvas canvas = new Canvas(800, 600);
        GraphicsContext gc = canvas.getGraphicsContext2D();

        StackPane root = new StackPane();
        root.getChildren().add(canvas);

        Scene scene = new Scene(root, 800, 600);

        scene.setOnMouseClicked(event -> generateSnowflakes(event.getX(), event.getY()));

        scene.setOnKeyPressed(event -> {
            if (event.getCode().toString().equals("ENTER")) {
                startSnowfallAnimation(gc);
            }
        });

        primaryStage.setScene(scene);
        primaryStage.show();
    }

    private void generateSnowflakes(double x, double y) {
        Random random = new Random();
        int numFlakes = 30;

        for (int i = 0; i < numFlakes; i++) {
            int size = random.nextInt(20) + 5;
            int speed = random.nextInt(5) + 1;
            snowflakes.add(new Snowflake(x, y, size, speed));
        }
    }

    private void startSnowfallAnimation(GraphicsContext gc) {
        new AnimationTimer() {
            @Override
            public void handle(long now) {
                updateSnowflakes();
                drawSnowflakes(gc);
            }
        }.start();
    }

    private void updateSnowflakes() {
        for (Snowflake snowflake : snowflakes) {
            snowflake.fall();
        }
    }

    private void drawSnowflakes(GraphicsContext gc) {
        gc.clearRect(0, 0, 800, 600);
        for (Snowflake snowflake : snowflakes) {
            snowflake.draw(gc);
        }
    }

    private static class Snowflake {
        private double x;
        private double y;
        private int size;
        private int speed;

        public Snowflake(double x, double y, int size, int speed) {
            this.x = x;
            this.y = y;
            this.size = size;
            this.speed = speed;
        }

        public void fall() {
            y += speed;
            if (y > 600) {
                y = 0;
            }
        }

        public void draw(GraphicsContext gc) {
            gc.setFill(Color.LIGHTSKYBLUE);
            gc.setStroke(Color.LIGHTSKYBLUE);

            double angle = Math.toRadians(60);
            double branchLength = size / 2;

            for (int i = 0; i < 6; i++) {
                double x2 = x + branchLength * Math.cos(angle * i);
                double y2 = y + branchLength * Math.sin(angle * i);

                gc.strokeLine(x, y, x2, y2);
            }
        }
    }
}
