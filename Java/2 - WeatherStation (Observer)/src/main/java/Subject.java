/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */

/**
 *
 * @author ismas
 */
public interface Subject {
    public void registerObserver( Observer observer );
    public void removeObserver( Observer observer );
    public void notifyObservers();
}
