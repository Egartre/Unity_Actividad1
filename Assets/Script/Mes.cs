using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mes : MonoBehaviour
{
    public string nombreMes = " ";
    private int numeroCardinal = 0;
    public class Valor { };

void Start()
    {
        switch (this.nombreMes)
        { 
            case "Enero":
                Debug.Log("Mes: " + (this.numeroCardinal = 1));
                break;
            
            case "Febrero":
                Debug.Log("Mes: " + (this.numeroCardinal = 2));
                break;
            
            case "Marzo":
                Debug.Log("Mes: " + (this.numeroCardinal = 3));
                break;
            
            case "Abril":
                Debug.Log("Mes: " + (this.numeroCardinal = 4));
                break;
            
            case "Mayo":
                Debug.Log("Mes: " + (this.numeroCardinal = 5));
                break;
            
            case "Junio":
                Debug.Log("Mes: " + (this.numeroCardinal = 6));
                break;
            
            case "Julio":
                Debug.Log("Mes: " + (this.numeroCardinal = 7));
                break;

            case "Agosto":
                Debug.Log("Mes: " + (this.numeroCardinal = 8));
                break;

            case "Septiembre":
                Debug.Log("Mes: " + (this.numeroCardinal = 9));
                break;

            case "Octubre":
                Debug.Log("Mes: " + (this.numeroCardinal = 10));
                break;

            case "Noviembre":
                Debug.Log("Mes: " + (this.numeroCardinal = 11));
                break;

            case "Diciembre":
                Debug.Log("Mes: " + (this.numeroCardinal = 12));
                break;



        }

        var p1 = new Valor();
        if 
            (this.numeroCardinal == 1 || this.numeroCardinal == 3 || 
            this.numeroCardinal == 5 || this.numeroCardinal == 7 || 
            this.numeroCardinal == 9 || this.numeroCardinal == 11) 
        {
            Debug.Log("Es impar");
        }
        else 
            {Debug.Log("Es par");} 
        
        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
