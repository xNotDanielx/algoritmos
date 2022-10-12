/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo;

import java.util.Date;
import java.text.SimpleDateFormat;
import java.text.ParseException;
import java.util.concurrent.TimeUnit;

/**
 *
 * @author DANIEL
 */
public class tractores extends vehiculo {
    private double precioPorDia;
    private String diaInicial;
    private String diaFinal;

    public tractores(){
        super();
    }

    public tractores(String placa, String color, String marca, double precioPorDia, String diaInicial, String diaFinal) {
        super(placa, color, marca);
        this.precioPorDia = precioPorDia;
        this.diaInicial = diaInicial;
        this.diaFinal = diaFinal;
    }

    public double getPrecioPorDia() {
        return precioPorDia;
    }

    public void setPrecioPorDia(double precioPorDia) {
        this.precioPorDia = precioPorDia;
    }

    public String getDiaInicial() {
        return diaInicial;
    }

    public void setDiaInicial(String diaInicial) {
        this.diaInicial = diaInicial;
    }

    public String getDiaFinal() {
        return diaFinal;
    }

    public void setDiaFinal(String diaFinal) {
        this.diaFinal = diaFinal;
    }
    

    public long calcularDias() throws ParseException{
        SimpleDateFormat fecha = new SimpleDateFormat("dd/mm/yyyy");
        Date fechaInicio = fecha.parse(diaInicial);
        Date fechaFin = fecha.parse(diaFinal);
        
        long tiempoTranscurrido = fechaFin.getTime()- fechaInicio.getTime();
        
        TimeUnit unidad = TimeUnit.DAYS;
        
        long dias = unidad.convert(tiempoTranscurrido, TimeUnit.MILLISECONDS);
        
        
        return dias;
    }
    
    public double resultadoTractores() throws ParseException{
        double resultado = calcularDias() * precioPorDia;
        return resultado;
    }
    
}
