/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.simuduck;

/**
 *
 * @author ismas
 */
public abstract class Duck {
    protected FlyBehavior flyBehavior;
    protected QuackBehavior quackBehavior;
    
    public Duck() {}
    
    public abstract void display();
    
    public void performFly()
    {
        flyBehavior.fly();
    }
    
    public void performQuack()
    {
        quackBehavior.quack();
    }
    
    public void swim()
    {
        System.out.println("All ducks float, even decoys");
    }
}
