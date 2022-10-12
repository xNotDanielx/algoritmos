/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo;

/**
 *
 * @author DANIEL
 */
public class autobuses extends vehiculo {
    private double precioPorKilometro;
    private double kmIniciales;
    private double kmFinales;

    public autobuses() {
        super();
    }

    public autobuses(String placa, String color, String marca, double precioPorKilometro, double kmIniciales, double kmFinales) {
        super(placa, color, marca);
        this.precioPorKilometro = precioPorKilometro;
        this.kmIniciales = kmIniciales;
        this.kmFinales = kmFinales;
    }

    public double getPrecioPorKilometro() {
        return precioPorKilometro;
    }

    public void setPrecioPorKilometro(double precioPorKilometro) {
        this.precioPorKilometro = precioPorKilometro;
    }

    public double getKmIniciales() {
        return kmIniciales;
    }

    public void setKmIniciales(double kmIniciales) {
        this.kmIniciales = kmIniciales;
    }

    public double getKmFinales() {
        return kmFinales;
    }

    public void setKmFinales(double kmFinales) {
        this.kmFinales = kmFinales;
    }
    
    public double kmRecorridos(){
        double km = this.kmFinales - this.kmIniciales;
        return km;
    }
    
    public double resultadoAutobuses(){
        double resultado = this.kmRecorridos() * precioPorKilometro;
        return resultado;
    }
    
    
}
