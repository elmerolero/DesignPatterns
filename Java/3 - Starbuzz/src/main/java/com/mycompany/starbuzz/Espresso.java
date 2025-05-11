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
public class Espresso extends Beverage{
    public Espresso(){
        description = "Espresso";
    }
    
    @Override
    public double cost(){
        switch(this.getSize()){
            case TALL:
                return 1.99;
            case GRANDE:
                return 2.49;
            case VENTI:
                return 2.89;
            default:
                return 1.99;
        }
    }
}
