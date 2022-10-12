/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package vista;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import modelo.autobuses;
import modelo.tractores;
import modelo.vehiculo;


/**
 *
 * @author DANIEL
 */
public class AgenciaDeRenta {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws ParseException{
        autobuses a = new autobuses("XYZ-123", "Amarillo", "volkswagen", 10000, 60, 80);
        System.out.println("La placa del vehiculo es: "+ a.getPlaca());
        System.out.println("El color del vehiculo es: "+ a.getColor());
        System.out.println("La marca del vehiculo es: "+ a.getMarca());
        System.out.println("Los kilometros recorridos durante su renta fueron: "
                            + a.kmRecorridos());
        System.out.println("El precio a pagar por su renta es de: "
                            + a.resultadoAutobuses()+ "$");
        
        System.out.println("_____________________________________________________________________________");
        
        tractores b = new tractores("ABC-321", "verde", "caterpillar", 12000, "10/05/2022", "31/05/2022");
        System.out.println("La placa del vehiculo es: "+ b.getPlaca());
        System.out.println("El color del vehiculo es: "+ b.getColor());
        System.out.println("La marca del vehiculo es: "+ b.getMarca());
        System.out.println("Cantidad de dias que se rento el tractor: "
                            + b.calcularDias());
        System.out.println("El precio a pagar por su rente es de: "
                            + b.resultadoTractores() + "$");
        
        
    }
    
    
}
