/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author ismas
 */
public class ForecastDisplay implements Observer, DisplayElement {
    private WeatherData weatherData;
    private float currentPressure = 29.92f;
    private float lastPressure;
    
    public ForecastDisplay(WeatherData weatherData){
        this.weatherData = weatherData;
    }
    
    public void update(float a, float humidity, float pressure){
        lastPressure = currentPressure;
        currentPressure = weatherData.getPressure();
    }
    
    public void display(){
        System.out.println("Temperature");
    }
}
