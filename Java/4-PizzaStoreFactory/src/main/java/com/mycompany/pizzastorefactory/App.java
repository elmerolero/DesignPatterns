/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.pizzastorefactory;

import com.mycompany.pizzastorefactory.ChicagoStylePizza.ChicagoPizzaStore;
import com.mycompany.pizzastorefactory.NewYorkPizzaStore.NewYorkPizzaStore;

/**
 *
 * @author ismas
 */
public class App {

    public static void main(String[] args) {
        PizzaStore nyStore = new NewYorkPizzaStore();
        PizzaStore chicagoStore = new ChicagoPizzaStore();
        
        Pizza pizza = nyStore.orderPizza("cheese");
        System.out.println("Ethan ordered a " + pizza.getName() + "\n");
        
        pizza = chicagoStore.orderPizza("cheese");
        System.out.println("Joel ordered a " + pizza.getName() + "\n");
    }
}
