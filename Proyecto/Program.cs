//Inicio, creacion del menu
int opcion;
int contenido;
int duracion;
int clasificacion;
double emicion;
int nvlProduccion;
bool valido;
string razon;
void validacion () {
    if (clasificacion == 2)
    {
        if (emicion >= 6 && emicion <= 22)
        {
            valido = true;
        }
        else
        {
            valido = false;
            razon = "El horario de emicion no es acorde a su clasificación";
        }
    }
    else if (clasificacion == 3)
    {
        if(emicion >= 22 && emicion <= 23 || emicion <= 5)
        {
            valido = true;
        }
        else
        {
            valido = false;
            razon = "El horario de emicion no es acorde a su clasificación";
        }
    }
    switch (contenido)
    {
        case 1:
            if(duracion >= 60 && duracion <= 180)
            {
                valido = true;
            }else
            {
                valido = false;
                razon = "La duración no está en el rango permitido para el contenido que ofrece";
            }
            break;
        case 2:
            if (duracion >= 20 && duracion <= 90)
            {
                valido = true;
            }
            else
            {
                valido = false;
                razon = "La duración no está en el rango permitido para el contenido que ofrece";
            }
            break;
        case 3:
            if (duracion >= 30 && duracion <= 120)
            {
                valido = true;
            }
            else
            {
                valido = false;
                razon = "La duración no está en el rango permitido para el contenido que ofrece";
            }
            break;
        case 4:
            if (duracion >= 30 && duracion <= 240)
            {
                valido = true;
            }
            else
            {
                valido = false;
                razon = "La duración no está en el rango permitido para el contenido que ofrece";
            }
            break;
    }
    if(nvlProduccion == 1)
    {
        if(clasificacion < 3)
        {
            valido = true;
        }else
        {
            valido = false;
            razon = "La producción no cumple con los estandares para su clasificación";
        }
    }
    else
    {
        valido = true;
    }
}

do
{
    Console.WriteLine("Regulación de programas semanales. \n" +
        "Seleccione una opción: \n" +
        "1)Evaluar nuevo contenido \n" +
        "2)Mostrar las reglas del sistema \n" +
        "3)Mostrar estadísticas de la seción \n" +
        "4)Reiniciar valores \n" +
        "5)Salir_");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el tipo de contenido: \n" +
                "1)Pelicula \n" +
                "2)Serie \n" +
                "3)Documental \n" +
                "4)Evento en vivo_");
            contenido = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la duración en minutos_");
            duracion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la clasificación: \n" +
                "1)Todo publico \n" +
                "2)+13 \n" +
                "3)+18_");
            clasificacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la hora en la que se emitira el programa_");
            emicion = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nivel de producción: \n" +
                "1)Bajo \n" +
                "2)Medio \n" +
                "3)Alto_");
            nvlProduccion = int.Parse(Console.ReadLine());
            if(contenido > 0 && contenido < 5 && duracion > 0 && clasificacion > 0 && clasificacion < 4 && emicion > 0 && emicion < 24 &&  nvlProduccion > 0 && nvlProduccion < 4)
            {
                validacion();
                if(valido == true)
                {
                    //funcion 2 
                }
                //funcion 3
            }else
            {
                Console.WriteLine("Una o más respuestas son invalidas, verifique nuevamente");
            }
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        default: break;
    }
    Console.WriteLine("Precione cualquier tecla para continuar");
    Console.ReadLine();
    Console.Clear();
} while (opcion != 5);