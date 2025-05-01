
import java.util.ArrayList;
import java.util.List;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author ismas
 */
public class WeatherData implements Subject {
    private List<Observer> observers;
    private float temperature;
    private float humidity;
    private float pressure;
    
    public WeatherData(){
        observers = new ArrayList<Observer>();
    }
    
    public void registerObserver( Observer observer ){
        observers.add( observer );
    }
    
    public void removeObserver( Observer observer ){
        observers.remove( observer );
    }
    
    public void notifyObservers(){
        for( Observer observer : observers ){
            observer.update(temperature, humidity, pressure);
        }
    }
    
    public float getTemperature(){
        return temperature;
    }
    
    public float getHumidity(){
        return humidity;
    }
    
    public float getPressure(){
        return pressure;
    }
    
    public void measurementsChanged(){
        notifyObservers();
    }
    
    public void setMeasurements( float temperature, float humidity, float pressure ){
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        measurementsChanged();
    }
}
