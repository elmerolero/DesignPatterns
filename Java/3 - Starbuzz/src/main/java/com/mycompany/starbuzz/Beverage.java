/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.starbuzz;

/**
 *
 * @author ismas
 */
public abstract class Beverage {
    String description = "Unknown Beberage";
    
    public enum Size { TALL, GRANDE, VENTI };
    Size size = Size.TALL;
    
    public String getDescription(){
        return description;
    }
    
    public abstract double cost();
    
    public void setSize( Size size ){
        this.size = size;
    }
    
    public Size getSize(){
        return this.size;
    }
}
