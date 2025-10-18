/* Solicita al usuario un número entre 1 y 7 y muestra el día de la
semana correspondiente, pero solo considerando los días laborables. */


Boolean validar = true;
int num = 0;

while (validar == true){
Console.WriteLine("Digita un numero entre 1 y 7: ");
num = int.Parse(Console.ReadLine());
if (num > 7 || num < 1) 
{
    Console.WriteLine("El numero no esta dentro del rango solicitado");
}
else 
{
    validar =false;
}
}

string dia = num switch
            {
                1 => "Lunes",
                2 => "Martes",
                3 => "Miércoles",
                4 => "Jueves",
                5 => "Viernes",
                _ => "Número inválido. Solo se consideran días laborables (1-5)."
            };
Console.WriteLine(dia);