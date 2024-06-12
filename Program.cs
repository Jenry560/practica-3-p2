using System;
using System.Collections.Generic;

class Estudiante
{
    public string Nombre { get; set; }
    public double Calificacion { get; set; }

    public Estudiante(string nombre, double calificacion)
    {
        Nombre = nombre;
        Calificacion = calificacion;
    }
}

class Program
{
    static List<Estudiante> estudiantes = new List<Estudiante>();
    static Queue<string> colaAtencion = new Queue<string>();
    static Stack<string> tareasPendientes = new Stack<string>();

    static void AgregarEstudiante(string nombre, double calificacion)
    {
        estudiantes.Add(new Estudiante(nombre, calificacion));
    }

    static void MostrarEstudiantes()
    {
        Console.WriteLine("Lista de estudiantes:");
        foreach (var estudiante in estudiantes)
        {
            Console.WriteLine($"{estudiante.Nombre}: {estudiante.Calificacion}");
        }
    }

    static void AgregarCliente(string nombre)
    {
        colaAtencion.Enqueue(nombre);
    }

    static void AtenderCliente()
    {
        if (colaAtencion.Count > 0)
        {
            string clienteAtendido = colaAtencion.Dequeue(); 
            Console.WriteLine("Atendiendo al cliente: " + clienteAtendido);
        }
        else
        {
            Console.WriteLine("No hay clientes en la cola.");
        }
    }

    static void AgregarTarea(string descripcion)
    {
        tareasPendientes.Push(descripcion);
    }

    static void CompletarTarea()
    {
        if (tareasPendientes.Count > 0)
        {
            string tareaCompletada = tareasPendientes.Pop();
            Console.WriteLine("Tarea completada: " + tareaCompletada);
        }
        else
        {
            Console.WriteLine("No hay tareas pendientes.");
        }
    }

    static void MostrarTareasPendientes()
    {
        Console.WriteLine("Tareas pendientes:");
        foreach (var tarea in tareasPendientes)
        {
            Console.WriteLine(tarea);
        }
    }

    static void Main(string[] args)
    {
        
        AgregarEstudiante("Juan", 8.5);
        AgregarEstudiante("María", 9.2);
        MostrarEstudiantes();

        AgregarCliente("Cliente 1");
        AgregarCliente("Cliente 2");
        AtenderCliente();

        AgregarTarea("Tarea 1");
        AgregarTarea("Tarea 2");
        CompletarTarea();
        MostrarTareasPendientes();
    }
}
