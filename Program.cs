
using System;
using System.Collections.Generic;
using TareasEmpleados;

namespace TareasEmpleados
{
public class Program 
{ 
  public static void Main(string[] args)
     {
        List<Tarea> tareasPendientes = Tarea.CrearTareasAleatorias(5);
        List<Tarea> tareasRealizadas = new List<Tarea>();

        Console.WriteLine("Tareas pendientes:");
        Tarea.BuscarTareaPorDescripcion(tareasPendientes, "");

         Tarea.MoverTarea(tareasPendientes, tareasRealizadas, 3);

        Console.WriteLine("\nTareas pendientes después de mover:");
        Tarea.BuscarTareaPorDescripcion(tareasPendientes, "");

        Console.WriteLine("\nTareas realizadas:");
        Tarea.BuscarTareaPorDescripcion(tareasRealizadas, "");
     }
}

 }


