Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Bienvenido al casino The King dice");
bool valido = false;
bool Salir = false;
double saldo = 0;
string? texto;
string? Textoopcion;
do
{
    Console.WriteLine("Inserta tu saldo para jugar en la maquina");
    texto = Console.ReadLine();
    if (!string.IsNullOrEmpty(texto) && double.TryParse(texto, out saldo))
    {
        valido = true;
    }
    else
    {
        Console.WriteLine("Respuesta no valida ingrese un saldo ");
    }
} while (!valido);

if (saldo < 19)
{
    Console.WriteLine("su saldo no es suficiente");
    return;
}
else
{
    Console.WriteLine("Bienvenido al tragaperras 3000");
}

int option=0;
do { 
Console.Clear();
Console.WriteLine("1 Jugar");
Console.WriteLine("2 Salir ");
Console.WriteLine("Escoge una opción");
Textoopcion =Console.ReadLine();
    if (!string.IsNullOrEmpty(Textoopcion) && int.TryParse(Textoopcion, out option) && (option >= 1 && option <= 2))
    {
       valido=true;
    }
    else
    {
        Console.WriteLine("Opcion no valida, presione un tecla para intentar otra vez");
        Console.ReadKey();
        valido = false;
    }
    switch (option)
{
    case 1:
        Console.WriteLine("Jugar");
        valido = true;
        break;
    case 2:
        Console.WriteLine("Salir");

        return;
}
}while (!valido);

bool jugar = false; 
int Fichas = 0;
int Costo = 20;
string? Rcompra;
string? Posiblecompra;
int Cantidad = 0;
Salir = false;

if (valido == true)
{
    do
    {
        Console.Clear();
        Console.WriteLine("1 Jugar");
        Console.WriteLine("2 Cambiar saldo a fichas");
        Console.WriteLine("3 Consultar numero de fichas");
        Console.WriteLine("4 salir");
        Console.WriteLine("Esocge una opción");
        Textoopcion = Console.ReadLine();
        if (!string.IsNullOrEmpty(Textoopcion) && int.TryParse(Textoopcion, out option) && (option >= 1 && option <= 4))
        {
            valido = true;
        }
        else
        {
            Console.WriteLine("Opcion no valida, presione un tecla para intentar otra vez");
            Console.ReadKey();
            valido = false;
        }
        switch (option)
        {
            case 2:
                bool Salircompra=false;
                do
                {
                    Console.WriteLine($"Su saldo acutal es de: {saldo}, Ingrese la cantidad de fichas que quiere comprar: (1 ficha = 20)");
                    texto = Console.ReadLine();
                    if (!string.IsNullOrEmpty(texto) && int.TryParse(texto, out Cantidad))
                    {
                        int Total = Cantidad * Costo;
                        if (saldo >= Total)
                        {
                            saldo -= Total;
                            Fichas += Cantidad;


                            Console.WriteLine($"Su numero de fichas es: {Fichas}, ¿Quiere comprar más? (si/no) ");
                            Rcompra = Console.ReadLine();
                            Rcompra = Rcompra?.ToLower();
                            if (string.IsNullOrEmpty(Rcompra))
                            {
                                Console.WriteLine("Este campo no puede estar vacio, intente otra vez");
                            }
                            else if (Rcompra == "si")
                            {
                                Salircompra = false;
                            }
                            else if (Rcompra == "no")
                            {
                                Salircompra = true;
                            }
                            else
                            {
                                Console.WriteLine("Opción no valida, intente otra vez");
                            }


                        }
                        else
                        {
                            int Fichasposibles = (int)(saldo / Costo);
                            Console.WriteLine($"Saldo insuficiente, la cantidad de fichas que puede comprar con este saldo es de: {Fichasposibles}, ¿quiere comprar estas fichas? (si/no)");
                            Posiblecompra = Console.ReadLine();
                            Posiblecompra = Posiblecompra?.ToLower();
                            if (string.IsNullOrEmpty(Posiblecompra))
                            {
                                Console.WriteLine("Este campo no puede estar vacio, intente otra vez");
                            }
                            else if (Posiblecompra == "si")
                            {
                            }
                            else if (Posiblecompra == "no")
                            {
                                Salircompra = true;
                            }
                            else
                            {
                                Console.WriteLine("Opción no valida, intente otra vez");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Respuesta no valida ingrese un saldo ");
                    }

                } while (!Salircompra);
                Console.WriteLine("\n Presione una tecla para volver al menu");
                Console.ReadKey();
                break;
            case 1:
                Console.WriteLine("Jugar");
                jugar = true;
                Salir = true;
                break;

            case 3:
                Console.WriteLine($"Su numero de fichas es de: {Fichas}");
                Console.WriteLine("\n Presione una tecla para volver al menu");
                Console.ReadKey();
                Salir = false;
                break;

            case 4:
                Console.WriteLine("Saliendo del programa");
                
              return;

        }
    } while (!Salir);
}
Salir = false;
Random random = new Random();
string[] simbolos = { "🍒", "🍋", "🔔", "⭐", "💎", "🍀", "🎲" };
if (jugar == true)
{
    do
    {
        Console.Clear();
        Console.WriteLine("1 Jugar con 1 ficha");
        Console.WriteLine("2 Jugar con 2 fichas");
        Console.WriteLine("3 Jugar con 3 fichas");
        Console.WriteLine("4 salir");
        Console.WriteLine("Esocge una opción");
        Textoopcion = Console.ReadLine();
        if (!string.IsNullOrEmpty(Textoopcion) && int.TryParse(Textoopcion, out option) && (option >= 1 && option <= 4))
        {
            valido = true;
        }
        else
        {
            Console.WriteLine("Opcion no valida, presione un tecla para intentar otra vez");
            Console.ReadKey();
            continue;
        }

            switch (option)
        {
            case 1:
                if (Fichas < 1)
                {
                    Console.WriteLine("No tienes suficientes fichas para jugar");
                    break;
                }

                Fichas -= 1;
              
                int s1 = random.Next(0, 7);
                int s2 = random.Next(0, 7);
                int s3 = random.Next(0, 7);

                Console.WriteLine($"| {simbolos[s1]} | {simbolos[s2]} | {simbolos[s3]} |");

                if(s1==s2 && s2 == s3)
                {
                    Console.WriteLine("Felicidades, has ganado 5 fichas");
                    Fichas += 5;
                }
                else if(s1==s2 || s1 == s3 || s2==s3)
                {
                    Console.WriteLine("Has ganado 2 fichas");
                    Fichas+= 2;
                }
                else
                {
                    Console.WriteLine("No tuviste suerte, perdiste una ficha");
                }
                Console.WriteLine($"Te quedan {Fichas} Fichas");

                Console.WriteLine("\n Presione una tecla para volver al menu");
                Console.ReadKey();
                break;
            case 2:
                if (Fichas < 2)
                {
                    Console.WriteLine("No tienes suficientes fichas para jugar");
                    break;
                }

                Fichas -= 2;
               
                 s1 = random.Next(0, 7);
                 s2 = random.Next(0, 7);
                 s3 = random.Next(0, 7);

                Console.WriteLine($"| {simbolos[s1]} | {simbolos[s2]} | {simbolos[s3]} |");

                if (s1 == s2 && s2 == s3)
                {
                    Console.WriteLine("Felicidades, has ganado 7 fichas");
                    Fichas += 7;
                }
                else if (s1 == s2 || s1 == s3 || s2 == s3)
                {
                    Console.WriteLine("Has ganado 4 fichas");
                    Fichas += 4;
                }
                else
                {
                    Console.WriteLine("No tuviste suerte, perdiste dos ficha");
                }
                Console.WriteLine($"Te quedan {Fichas} Fichas");

                Console.WriteLine("\n Presione una tecla para volver al menu");
                Console.ReadKey();
                break;

            case 3:
                if (Fichas < 3)
                {
                    Console.WriteLine("No tienes suficientes fichas para jugar");
                    break;
                }

                Fichas -= 3;

                s1 = random.Next(0, 7);
                s2 = random.Next(0, 7);
                s3 = random.Next(0, 7);

                Console.WriteLine($"| {simbolos[s1]} | {simbolos[s2]} | {simbolos[s3]} |");

                if (s1 == s2 && s2 == s3)
                {
                    Console.WriteLine("Felicidades, has ganado 10 fichas");
                    Fichas += 10;
                }
                else if (s1 == s2 || s1 == s3 || s2 == s3)
                {
                    Console.WriteLine("Has ganado 6 fichas");
                    Fichas += 6;
                }
                else
                {
                    Console.WriteLine("No tuviste suerte, perdiste dos ficha");
                }
                Console.WriteLine($"Te quedan {Fichas} Fichas");

                Console.WriteLine("\n Presione una tecla para volver al menu");
                Console.ReadKey();
                break;
            case 4:
                Console.WriteLine("Saliendo del juego");
                
            return;
                
            default: 
                Console.WriteLine("Opcion no valida, presione una tecla para intentar otra vez");
                Console.ReadKey();
                break;

        }
    } while (!Salir) ;
}    