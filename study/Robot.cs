using System;

class Robot{

    public void Move(){
        Console.WriteLine("Robot is moving");
    }
}

class CleanRobot:Robot{ //Robot 클래스 상속 
    public void clean(){
        Console.WriteLine("Robot is cleaning");
    }
}

class Print3{
    public void prrint(){
        CleanRobot cleanRobot = new CleanRobot();
        cleanRobot.Move();
        cleanRobot.clean();
    }
}