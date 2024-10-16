using System.Collections;

//Crear un ArrayList
ArrayList miAL = new ArrayList();

//Agregar elementos diferentes en el ArrayList
miAL.Add(1);                //Entero
miAL.Add("Programación");   //Cadena
miAL.Add("!");
miAL.Add("&");

//Mostrar las propiedades y valores del ArrayList
Console.WriteLine("miAL");
Console.WriteLine("Cantidad: {0}", miAL.Count); 
Console.WriteLine("Capacidad: {0}", miAL.Capacity);
Console.WriteLine("Valores:");
ImprimirValores(miAL);

void ImprimirValores(IEnumerable miColection)
{
    //Recorrer y mostrar el ArrayList
    foreach (var item in miColection)
    {
        Console.WriteLine("{0}", item);
        Console.WriteLine();
    }
}

Console.WriteLine("--------------------------");
//Crear un Cola (Queue)
Queue miQ = new Queue();

//Agregar elementos
miQ.Enqueue("Primero");
miQ.Enqueue("Segundo");
miQ.Enqueue("Tercero");

//Mostrar propiedades y valores de Queue
Console.WriteLine("miQ");
Console.WriteLine("\tCantidad: {0}", miQ.Count);
Console.WriteLine("\tValores:");
ImprimirValores(miQ);

//Remover y mostrar elementos
Console.WriteLine($"Elemento removido: {miQ.Dequeue()}");
ImprimirValores(miQ);

//Mostrar el siguiente elemento en la Cola sin removerlo
Console.WriteLine($"Siguiente en la Cola: {miQ.Peek()}");
ImprimirValores(miQ);

Console.WriteLine("---------------------------");

//Crear una pila (Stack)
Stack miS = new Stack();

//Agregar elementos 
miS.Push("Primero");
miS.Push("Segundo");
miS.Push("Tercero");

//Muestra las propiedades y valos de la pila
Console.WriteLine("miS");
Console.WriteLine("\tCantidad: {0}", miS.Count);
Console.WriteLine("\tValores:");
ImprimirValores(miS);

//Remover y mostrar elementos 
Console.WriteLine($"Elemento removido: {miS.Pop()}");
ImprimirValores(miS);

//Mostrar el siguiente elemento 
Console.WriteLine($"Siguiente en la Cola: {miS.Peek()}");
ImprimirValores(miS);

Console.WriteLine("-----------------------------");

//Crear un HastTable
Hashtable abrirCon = new Hashtable();

//Agregar elementos al Hashtable
//No hay claves duplicadas, pero si podemos duplicar valores 

abrirCon.Add("txt", "notepad.exe");
abrirCon.Add("bmp", "paint.exe");
abrirCon.Add("dib", "paint.exe");
abrirCon.Add("rtf", "wordpad.exe");

//El método Add lanza una excepción si la nueva clave ya está disponible 
try
{
    abrirCon.Add("txt", "winmord.exe");
}
catch
{
    Console.WriteLine("Ya existe un elemento con la clave \"txt\".");
}

//La propiedasd item es la propiedad predeterminada, por lo tanto puede omitir su nombre al
//Acceder a los elementos;

Console.WriteLine("Para la clave = \"rtf\", el valor es {0}.", abrirCon["rtf"]);