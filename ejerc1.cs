namespace TareasEmpleados
{
    class Tarea
    {   

    private int TareaID;
     private string Descripcion ;
     private int Duracion ;

    public Tarea(int id, string descripcion, int duracion)
     {
        TareaID = id;
        Descripcion = descripcion;
        Duracion = duracion;
     }

        public int TareaID1 { get => TareaID; set => TareaID = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public int Duracion1 { get => Duracion; set => Duracion = value; }

        private static Random random = new Random();
        private static string[] descripciones = { "Tarea A", "Tarea B", "Tarea C", "Tarea D", "Tarea E" };
    
    //crear Tareas
      public static Tarea CrearTarea(int id)
     {
          string descripcion = descripciones[random.Next(descripciones.Length)];
          int duracion = random.Next(10, 101); // Duración entre 10 y 100
          return new Tarea(id, descripcion, duracion);
      }

     //crear tareas Aleatorias
      public static List<Tarea> CrearTareasAleatorias(int N)
     {
         List<Tarea> tareas = new List<Tarea>();
         for (int i = 0; i < N; i++)
         {
            tareas.Add(CrearTarea(i + 1));
         }
          return tareas;
     }
     //BUSCAR TAREA POR DESCRIPCION
      public static void BuscarTareaPorDescripcion(List<Tarea> lista, string descripcion)
    {
        bool encontrado = false;

        foreach (var tarea in lista)
        {
            if (tarea.Descripcion.Contains(descripcion, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Tarea ID: {tarea.TareaID}, Descripción: {tarea.Descripcion}, Duración: {tarea.Duracion}");
                encontrado = true;
            }
        }
         if (!encontrado)
        {
            Console.WriteLine($"No se encontraron tareas con la descripción \"{descripcion}\".");
        }
     }


      public static void MoverTarea(List<Tarea> pendientes, List<Tarea> realizadas, int tareaID)
    {
        Tarea tarea = pendientes.Find(t => t.TareaID == tareaID);

        if (tarea != null)
        {
            pendientes.Remove(tarea);
            realizadas.Add(tarea);
            Console.WriteLine($"Tarea con ID {tareaID} movida a realizadas.");
        }
        else
        {
            Console.WriteLine($"Tarea con ID {tareaID} no encontrada.");
        }
    }
  }

}

    


