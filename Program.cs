IdentificarMes(5);

static void IdentificarMes(int mes)
{
    string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
    Console.WriteLine(meses[mes -1]);
    Console.WriteLine($"El mes con el número {mes} es: {meses[(mes - 1)]}");


}
Console.WriteLine("Introduce el Número del mes: ");
int mesRecibido = int.Parse(Console.ReadLine());
IdentificarMes(mesRecibido);

