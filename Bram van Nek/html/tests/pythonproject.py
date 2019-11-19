import turtle

wn= turtle.Screen()
wn.title("dodge ball")
wn.bgcolor("black")
wn.setup(width=800, height=600)
wn.tracer(1)

# paddle a
paddle_a = turtle.Turtle()
paddle_a.speed(0)
paddle_a.shape("square")
paddle_a.color("white")
paddle_a.shapesize(stretch_wid=3, stretch_len=1)
paddle_a.penup()
paddle_a.goto(0, -250)

# ball 1
ball = turtle.Turtle()
ball.speed(0)
ball.shape("square")
ball.color("white")
ball.penup()
ball.goto(0, 250)
ball.dx = -1 
ball.dy = -5


# funcion
def paddle_a_left():
    x = paddle_a.xcor()
    x -= 20
    paddle_a.setx(x)

def paddle_a_right():
    x = paddle_a.xcor()
    x += 20
    paddle_a.setx(x)

# keyboard  binding
wn.listen()
wn.onkeypress(paddle_a_left, "Left")
wn.onkeypress(paddle_a_right, "Right")


# main game loop
while True:
    wn.update()

     # move the ball 
    ball.setx(ball.xcor() + ball.dx)
    ball.sety(ball.ycor() + ball.dy)

    if ball.xcor() > 290:
        ball.setx(290)
        ball.dx *= -1


    if ball.xcor() < -290:
        ball.setx(-290)
        ball.dx *= -1

    if ball.xcor() > 390:
        ball.goto(0, 0)
        ball.dx *= -1

    if ball.xcor() < -390:
        ball.goto(0, 0)
        ball.dx *= -1

    