/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.pizzastorefactory.ChicagoStylePizza;

import com.mycompany.pizzastorefactory.Pizza;

/**
 *
 * @author ismas
 */
public class ChicagoStyleCheesePizza extends Pizza {
    public ChicagoStyleCheesePizza(){
        name = "Chicago Style Deep Dish Cheese Pizza";
        dough = "Extra Thick Crust Dough";
        sauce = "Plum Tomato Sauce";
        
        toppings.add("Shredded Mozzarela Cheese");
    }
    
    @Override
    protected void cut(){
        System.out.println("Cutting the pizza into square slices");
    }
}
