/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.pizzastorefactory;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ismas
 */
public abstract class Pizza {
    protected String name;
    protected String dough;
    protected String sauce;
    protected List<String> toppings = new ArrayList<String>();
    
    void prepare(){
        System.out.println("Preparing " + name);
        System.out.println("Tossing dough...");
        System.out.println("Adding sauce...");
        System.out.println("Adding toppings: ");
        for( String topping : toppings ){
            System.out.println("   " + topping);
        }
    }
    
    void bake(){
        System.out.println("Bake for 25 minutes at 350");
    }
    
    protected void cut() {
        System.out.println("Cutting the pizza into diagonal slices");
    }
    
    void box() {
        System.out.println("Place pizza in official PizzaStore box");
    }
    
    public String getName() {
        return name;
    }
}
