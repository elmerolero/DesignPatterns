/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.javaiodecorator;

import java.io.BufferedInputStream;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;

/**
 *
 * @author ismas
 */
public class InputTest {
    public static void main(String[] args) throws IOException{
        int c;
        
        try {
            InputStream in = new LowerCaseInputStream( new BufferedInputStream( new FileInputStream("testFile.txt")));
            
            while( (c = in.read()) >= 0){
                System.out.print((char) c);
            }
            
            in.close();
        }
        catch(IOException e){
            e.printStackTrace();
        }
    }
}
