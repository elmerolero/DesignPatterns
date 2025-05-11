/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.pizzastorefactory.NewYorkPizzaStore;

import com.mycompany.pizzastorefactory.Pizza;
import com.mycompany.pizzastorefactory.PizzaStore;

/**
 *
 * @author ismas
 */
public class NewYorkPizzaStore extends PizzaStore {
    protected Pizza createPizza(String item){
        switch(item){
            case "cheese":
                return new NYStyleCheesePizza();
            default:
                return null;
        }
    }
}
