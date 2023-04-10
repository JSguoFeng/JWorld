using System;
namespace Demo1{
    public class Students{
    int age{get;set;}
    float health{get; set;}
    public Students(){

    }
    public Students(int age, float health){
        this.age = age ;
        this.health = health;
    }
    public void Prin(){
        Console.WriteLine("学生的姓名是：{0},学生的健康度是：{1}",this.age,this.health);
    }
}
}