double area, altura, volumen, ladoBase;
int contadorPiramides;

contadorPiramides = 0;
try
{


do
{
    Console.WriteLine("Ingrese la altura de la pirámide: (0 Para salir)");
    altura = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la base de la pirámide: (0 Para salir)");
    ladoBase = double.Parse(Console.ReadLine());

    area = ladoBase * (ladoBase + Math.Sqrt(4 * Math.Pow(altura, 2) + Math.Pow(ladoBase, 2)));
    volumen = (Math.Pow(ladoBase, 2) * altura) / 3;
    contadorPiramides = contadorPiramides + 1;
    Console.Write("El área total de la pirámide es: " + area);
    Console.Write("El volumen de la pirámide es: " + volumen);

} while (ladoBase != 0 && altura != 0);

}
catch (Exception)
{

    Console.WriteLine("Valor ingresado no es válido");
}
Console.ReadLine();

Console.WriteLine(" Se ingresaron " + contadorPiramides + " pirámides");
