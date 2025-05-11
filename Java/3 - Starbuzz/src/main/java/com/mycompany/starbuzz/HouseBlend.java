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
public class HouseBlend extends Beverage {
    public HouseBlend(){
        description = "House Blend Coffe";
    }
    
    @Override
    public double cost(){
        switch(this.getSize()){
            case TALL:
                return 0.89;
            case GRANDE:
                return 0.95;
            case VENTI:
                return 0.99;
            default:
                return 0.89;
        }
    }
}
