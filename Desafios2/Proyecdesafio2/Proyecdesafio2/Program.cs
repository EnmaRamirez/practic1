static void Main(string[] args)
{
    Console.Write("Ingresa tu nombre");
    string usuario = Console.ReadLine();

    Console.Write(" Ingresa Mes 1");
    double ingresoMes1 = double.Parse(Console.ReadLine());

    Console.Write(" Ingresa Mes 2");
    double ingresoMes2 = double.Parse(Console.ReadLine());

    Console.Write(" Ingresa Mes 3");
    double ingresoMes3 = double.Parse(Console.ReadLine());

    CalcularyMostrarIngresos(usuario, ingresoMes1, ingresoMes2, ingresoMes3);
}
static void CalcularyMostrarIngresos(string usuario, double ingresoMes1, double ingresoMes2, double ingresoMes3)
{
    double sumaIngresos = ingresoMes1 + ingresoMes2 + ingresoMes3;
    double promedioIngresos = sumaIngresos / 3;

    Console.Write($"Hola{usuario}, el total ganaste ${sumaIngresos} y promediste ${promedioIngresos} En los ultimos 3 meses. ");
}







