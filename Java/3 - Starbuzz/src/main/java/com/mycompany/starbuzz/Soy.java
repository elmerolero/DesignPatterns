/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.starbuzz;

/**
 *
 * @author ismas
 *
 */
public class Soy extends CondimentDecorator {
    public Soy( Beverage beverage ){
        this.beverage = beverage;
    }
    
    @Override
    public String getDescription(){
        return this.beverage.getDescription() + ", Soy";
    }
    
    @Override
    public double cost(){
        switch(this.getSize()){
            case TALL:
                return this.beverage.cost() + 0.10;
            case GRANDE:
                return this.beverage.cost() + 0.15;
            case VENTI:
                return this.beverage.cost() + 0.20;
            default:
                return this.beverage.cost() + 0.10;
        }
    }
}
