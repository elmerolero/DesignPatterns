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
public class Whip extends CondimentDecorator {
    public Whip( Beverage beverage ){
        this.beverage = beverage;
    }
    
    @Override
    public String getDescription(){
        return this.beverage.getDescription() + ", Whip";
    }
    
    @Override
    public double cost(){
        switch(this.getSize()){
            case TALL:
                return this.beverage.cost() + 0.09;
            case GRANDE:
                return this.beverage.cost() + 0.12;
            case VENTI:
                return this.beverage.cost() + 0.14;
            default:
                return this.beverage.cost() + 0.09;
        }
    }
}
