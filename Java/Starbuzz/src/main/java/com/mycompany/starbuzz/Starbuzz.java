/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.starbuzz;

/**
 *
 * @author ismas
 * I don't agree too much with this pattern because there are more efficient ways to achieve the result
 * shown.
 * As example, you can create a class (maybe) where you implement the cost and descriptions methods
 * and you add them in a list and iterate over all your condiments in order to get the sum of all costs.
 * But I know that the purpose of this example is to show the pattern, so it's OK.
 */
public class Starbuzz {

    public static void main(String[] args){
        Beverage beverage = new Espresso();
        System.out.println(beverage.getDescription() + " $" + beverage.cost());
        
        Beverage beverage2 = new DarkRoast();
        beverage2 = new Mocha(beverage2);
        beverage2 = new Mocha(beverage2);
        beverage2 = new Whip(beverage2);
        System.out.println(beverage2.getDescription() + " $" + beverage2.cost());
        
        Beverage beverage3 = new HouseBlend();
        beverage3 = new Soy(beverage3);
        beverage3 = new Mocha(beverage3);
        beverage3 = new Whip( beverage3 );
        System.out.println(beverage3.getDescription() + " $" + beverage3.cost());
    }
}
