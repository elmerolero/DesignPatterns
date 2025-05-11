/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.starbuzz;

import static com.mycompany.starbuzz.Beverage.Size.GRANDE;
import static com.mycompany.starbuzz.Beverage.Size.TALL;
import static com.mycompany.starbuzz.Beverage.Size.VENTI;

/**
 *
 * @author ismas
 */
public class Mocha extends CondimentDecorator {
    public Mocha(Beverage beverage){
        this.beverage = beverage;
    }
    
    public String getDescription(){
        return beverage.getDescription() + ", Mocha";
    }
    
    public double cost(){
        switch(this.getSize()){
            case TALL:
                return this.beverage.cost() + 0.20;
            case GRANDE:
                return this.beverage.cost() + 0.25;
            case VENTI:
                return this.beverage.cost() + 0.29;
            default:
                return this.beverage.cost() + 0.20;
        }
    }
}
