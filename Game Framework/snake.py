#python3 -u "/Users/sunny_yeung/Downloads/YAT/Winter2024/CSE310/sunny-project/Game Framework/snake.py"

import pygame
import time
import random

pygame.init()

# Set up the display
WIDTH, HEIGHT = 500, 500
win = pygame.display.set_mode((WIDTH, HEIGHT))
pygame.display.set_caption("Snake Game")

# Colors
GRAY = (200, 200, 200)
RED = (200, 0, 0)
BLUE = (0, 100, 200)
GREEN = (0, 0, 100)

# Snake properties
snake_block = 10
snake_speed = 15

# Initialize snake
snake = [(WIDTH // 2, HEIGHT // 2)]
snake_direction = 'RIGHT'

# Initialize food
food_position = (random.randrange(0, WIDTH - snake_block, snake_block),
                 random.randrange(0, HEIGHT - snake_block, snake_block))

# Functions
def draw_snake(snake):
    for segment in snake:
        pygame.draw.rect(win, GREEN, (segment[0], segment[1], snake_block, snake_block))

def draw_food(food_pos):
    pygame.draw.rect(win, RED, (food_pos[0], food_pos[1], snake_block, snake_block))

def game_loop():
    global snake_direction
    global food_position

    run = True
    while run:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                run = False
            elif event.type == pygame.KEYDOWN:
                if event.key == pygame.K_UP and snake_direction != 'DOWN':
                    snake_direction = 'UP'
                elif event.key == pygame.K_DOWN and snake_direction != 'UP':
                    snake_direction = 'DOWN'
                elif event.key == pygame.K_LEFT and snake_direction != 'RIGHT':
                    snake_direction = 'LEFT'
                elif event.key == pygame.K_RIGHT and snake_direction != 'LEFT':
                    snake_direction = 'RIGHT'

        # Move the snake
        head = list(snake[0])
        if snake_direction == 'UP':
            head[1] -= snake_block
        elif snake_direction == 'DOWN':
            head[1] += snake_block
        elif snake_direction == 'LEFT':
            head[0] -= snake_block
        elif snake_direction == 'RIGHT':
            head[0] += snake_block

        # Check for collision with the walls
        if head[0] < 0 or head[0] >= WIDTH or head[1] < 0 or head[1] >= HEIGHT:
            run = False

        # Check for collision with itself
        if head in snake[1:]:
            run = False

        snake.insert(0, tuple(head))

        # Check for collision with food
        if head[0] == food_position[0] and head[1] == food_position[1]:
            food_position = (random.randrange(0, WIDTH - snake_block, snake_block),
                             random.randrange(0, HEIGHT - snake_block, snake_block))
        else:
            snake.pop()

        # Clear the screen
        win.fill(GRAY)

        # Draw the snake and food
        draw_snake(snake)
        draw_food(food_position)

        # Update the display
        pygame.display.update()

        # Control the snake's speed
        pygame.time.Clock().tick(snake_speed)

    pygame.quit()
    quit()

# Run the game
game_loop()
