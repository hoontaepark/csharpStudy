using System;

class Dog{
    public string Name;
    public int Weight;


    public Dog(string name){ //MethodOverLoading 메소드 오버로딩 하나의 메소드로 매개변수를 다르게 해 여러가지 작업을 할수있음. 
        Name = name;
        Console.WriteLine("Dog name =" + name);
    }

    public Dog(string name, int weight){
        Name = name;
        Weight = weight;
        Console.WriteLine("Dog name = "+ name + "Weight = " + weight);
    }

}

class Print2 {
    public Print2{
        Dog dog = new Dog("Puppy");
        Dog dog2 = new Dog("Puppy", 5);
    }
}