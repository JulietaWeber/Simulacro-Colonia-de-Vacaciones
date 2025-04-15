using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colonia : MonoBehaviour
{
    public int cantidadInfantiles;
    public int cantidadJuveniles;

    // int cantidadMaxima = 100;
    // int maxInfantilesPorGrupo = 10;
    // int maxJuvenilesPorGrupo = 20;
    // int maxProfesPorCoordi = 5;

    int profesIRequeridos;
    int profesJRequeridos;
    int profesTotal;
    int coordisRequeridos;
    int listaDeEspera;


    // Start is called before the first frame update
    void Start()
    {
        if (cantidadInfantiles < 0 || cantidadJuveniles < 0)
        {
            Debug.Log("La cantidad de alumnos no puede ser negativa");
            return;
        }

          //  if (cantidadInfantiles > cantidadMaxima || cantidadJuveniles > cantidadMaxima)
        if (cantidadInfantiles > 100 || cantidadJuveniles > 100)
        {
            Debug.Log("La cantidad de alumnos inscriptos no puede ser mayor que 100");
            return;
        }

        // profesIRequeridos = cantidadInfantiles / maxInfantilesPorGrupo;
        profesIRequeridos = cantidadInfantiles / 10;
        // profesJRequeridos = cantidadJuveniles / maxJuvenilesPorGrupo;
        profesJRequeridos = cantidadJuveniles / 20;
        profesTotal = profesIRequeridos + profesJRequeridos;
        // coordisRequeridos = (profesTotal / maxProfesPorCoordi;
        coordisRequeridos = profesTotal / 5;
        if (profesTotal % 5 != 0)
        {
            coordisRequeridos ++;
        }

        listaDeEspera = (cantidadInfantiles % 10) + (cantidadJuveniles % 20);

        Debug.Log("Se necesitan " + profesIRequeridos + " profesor/es para los inscriptos infantiles");
        Debug.Log("Se necesitan " + profesJRequeridos + " profesor/es para los inscriptos juveniles");
        Debug.Log("Se necesitan " + coordisRequeridos + " coordinador/es para los profesores");
        Debug.Log("Hay " + listaDeEspera + " alumno/s en la lista de espera");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
