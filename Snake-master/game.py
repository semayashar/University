import pygame
from snake import Snake
from apple import Apple

class Game:

    def __init__(self):
        pygame.init()
        pygame.display.set_caption('SnakeAI')
        screen = pygame.display.set_mode((800,600))
        self.run(screen)

    def run(self, screen):
        running = True
        score = 0

        scoreFont = pygame.font.SysFont("arial", 18)
        lossFont = pygame.font.SysFont("arial", 72)

        lossText = lossFont.render('You died', True, (0, 255, 0))

        clock = pygame.time.Clock()
        snake = Snake()
        apple = Apple()

        while running:
            for event in pygame.event.get():
                if event.type == pygame.QUIT:
                        running = False

                if event.type == pygame.KEYDOWN:
                    if event.key == pygame.K_UP and snake.direction != 'DOWN':
                        snake.direction = 'UP'
                    if event.key == pygame.K_DOWN and snake.direction != 'UP':
                        snake.direction = 'DOWN'
                    if event.key == pygame.K_RIGHT and snake.direction != 'LEFT':
                        snake.direction = 'RIGHT'
                    if event.key == pygame.K_LEFT and snake.direction != 'RIGHT':
                        snake.direction = 'LEFT'
                    if event.key == pygame.K_r and not snake.alive:
                        Game()

                pygame.event.clear()

            if snake.alive:
                if apple.rect.colliderect(snake.rect):
                    snake.eatApple()
                    apple.eaten()
                    score += 1

                screen.fill((0,0,0))
                scoreText = scoreFont.render('Score: %s' % score, True, (0, 255, 0))
                screen.blit(scoreText, (25, 10))
                apple.draw(screen)
                snake.draw(screen)
                clock.tick(5)
                pygame.display.flip()

            if not snake.alive:
                screen.blit(lossText, (300, 250))
                pygame.display.update()

if __name__ == '__main__':
    Game()
