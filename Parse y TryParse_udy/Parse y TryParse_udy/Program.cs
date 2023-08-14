//Parse y TryParse
//Convertir de String hacia otro tipo de dato
//enteros
var cantString = "5";
int cantidad = int.Parse(cantString);
cantidad++;
Console.WriteLine(cantidad);    //6

var cantidadDecimalString = "4.9";
//decimal
var cantidadDecimal = decimal.Parse(cantidadDecimalString);
cantidadDecimal++;//5.9

//booleanos
var booleanoString = "true";

var boolean = bool.Parse(booleanoString);
if (boolean) {
    Console.WriteLine("CONVERTIMOS DE STRING A BOOLEANO");
}
// FECHAS
var fechaString = "2022-05-09";
var fecha = DateTime.Parse(fechaString);   
Console.WriteLine(fecha.AddYears(1)); //2023-05-09

//tryParse
var supuestoNumero = "9";
int numero;
var pudoParsear = int.TryParse(supuestoNumero, out numero);//permitir modificar el valor de la variable
if (pudoParsear)
{
    //lugar seguro para usar variable numero
    numero++;
    Console.WriteLine(numero);
}
else
{
    Console.WriteLine($"El valor {supuestoNumero} no tiene el fromato correcto.");
}