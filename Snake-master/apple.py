import pygame
import random

class Apple:

    def __init__(self):
        self.color = (255,0,0)
        self.size = 32
        self.coordinates = (random.randint(32,768), random.randint(32,368))
        self.rect = pygame.Rect(random.randint(32,768), random.randint(32,368), self.size, self.size)

    def draw(self, screen):
        self.rect = pygame.Rect(self.coordinates[0], self.coordinates[1], self.size, self.size)
        pygame.draw.rect(screen, self.color, self.rect)

    def eaten(self):
        self.coordinates = (random.randint(32,768), random.randint(32,368))
