int opcion = -1;
int contenido = -1;
int duracion = -1;
int clasificacion = -1; 
double emicion = -1;
int nvlProduccion = -1;
bool valido = false;
string razon = "";
string impact = "";
int publicado = 0;
int rechazados = 0;
int revisando = 0;
int ingresados = 0;
int Imalto = 0;
int Immedio = 0;
int Imbajo = 0;
int predom = 0;
int cant;
double cantb;
bool seguro;
void validacion1 ()
{
    if (clasificacion == 2)
    {
        if (emicion >= 6 && emicion <= 22)
        {
            validacion2();
        }
        else
        {
            valido = false;
            razon = "El horario de emicion no es acorde a su clasificación";
        }
    }
    else if (clasificacion == 3)
    {
        if (emicion >= 22 && emicion <= 23 || emicion <= 5)
        {
            validacion2();
        }
        else
        {
            valido = false;
            razon = "El horario de emicion no es acorde a su clasificación";
        }
    }
    else
    {
        validacion2();
    }
}
void validacion2()
{
    if (contenido == 1)
    {
        if (duracion >= 60 && duracion <= 180)
        {
            validacion3();
        }
        else
        {
            valido = false;
            razon = "La duración no está en el rango permitido para el contenido que ofrece";
        }
    }
    else if (contenido == 2)
    {
        if (duracion >= 20 && duracion <= 90)
        {
            validacion3();
        }
        else
        {
            valido = false;
            razon = "La duración no está en el rango permitido para el contenido que ofrece";
        }
    }
    else if (contenido == 3)
    {
        if (duracion >= 30 && duracion <= 120)
        {
            validacion3();
        }
        else
        {
            valido = false;
            razon = "La duración no está en el rango permitido para el contenido que ofrece";
        }
    }
    else if (contenido == 4)
    {
        if (duracion >= 30 && duracion <= 240)
        {
            validacion3();
        }
        else
        {
            valido = false;
            razon = "La duración no está en el rango permitido para el contenido que ofrece";
        }
    }
}
void validacion3()
{
    if (nvlProduccion == 1)
    {
        if (clasificacion < 3)
        {
            valido = true;
        }
        else
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
string impacto(){
    if(nvlProduccion == 3 || duracion > 120 || emicion >= 20 && emicion <= 23)
    {
        return "Impacto alto";
    }else if(nvlProduccion == 2 || duracion > 60)
    {
        return "Impacto medio";
    }else
    {
        return "Impacto bajo";
    }
}
void decicion()
{
    if(valido == true && impact == "Impacto bajo" || impact == "Impacto medio")
    {
        publicado++;
        Console.WriteLine("Publicado");
    }else if(valido == true && emicion > 22)
    {
        publicado++;
        Console.WriteLine("Publicado, pero ajustar la hora de emicion 2 horas antes");
    }else if(valido == true && impact == "Impacto alto")
    {
        revisando++;
        Console.WriteLine("Enviado a revición");
    }
    else
    {
        rechazados++;
        Console.WriteLine($"Rechazado por: {razon}");
    }
}
void reinicio()
{
    contenido = -1;
    duracion = -1;
    clasificacion = -1;
    emicion = -1;
    nvlProduccion = -1;
}
void ContadorPre()
{
    if(impact == "Impacto alto")
    {
        Imalto++;
    }else if(impact == "Impacto medio")
    {
        Immedio++;
    }
    else
    {
        Imbajo++;
    }
}
void Predominante()
{
    if(Imalto > Immedio)
    {
        predom = Imalto;
    }else if(Imalto < Immedio)
    {
        predom = Immedio;
    }
    if (predom < Imbajo)
    {
        predom = Imbajo;
    }
}
void ReinicioTotal() {
    contenido = -1;
    duracion = -1;
    clasificacion = -1;
    emicion = -1;
    nvlProduccion = -1;
    valido = false;
    razon = "";
    impact = "";
    publicado = 0;
    rechazados = 0;
    revisando = 0;
    ingresados = 0;
    Imalto = 0;
    Immedio = 0;
    Imbajo = 0;
    predom = 0;
}
void Verificacion()
{
    bool verificado = int.TryParse(Console.ReadLine(), out cant);
    if (verificado)
    {
        seguro = true;   
    }
    else
    {
        Console.WriteLine("Valor invalido");
        seguro = false;
    }
}
void VerificacionDouble()
{
    bool verificado = double.TryParse(Console.ReadLine(), out cantb);
    if (verificado)
    {
        seguro = true;
    }
    else
    {
        Console.WriteLine("Valor invalido");
        seguro = false;
    }
}
    do
    {
        do
        {
        Console.WriteLine("Regulación de programas semanales. \n" +
            "Seleccione una opción: \n" +
            "1)Evaluar nuevo contenido \n" +
            "2)Mostrar las reglas del sistema \n" +
            "3)Mostrar estadísticas de la seción \n" +
            "4)Reiniciar valores \n" +
            "5)Salir_");
        Verificacion();
        if (seguro == true)
        {
            opcion = cant;
        }
        } while (seguro == false);
        switch (opcion)
        {
            case 1:
                ingresados++;
                reinicio();
                while (contenido < 0 || contenido > 4 && duracion < 0 && clasificacion < 0 || clasificacion > 3 && emicion < 0 || emicion > 23 && nvlProduccion < 0 || nvlProduccion > 3)
                {
                    do
                    {
                        Console.WriteLine("Ingrese el tipo de contenido: \n" +
                            "1)Pelicula \n" +
                            "2)Serie \n" +
                            "3)Documental \n" +
                            "4)Evento en vivo_");
                        Verificacion();
                        if (seguro == true)
                        {
                            contenido = cant;
                        }
                    } while (seguro == false);
                    do
                    {
                        Console.WriteLine("Ingrese la duración en minutos_");
                        Verificacion();
                        if (seguro == true)
                        {
                            duracion = cant;
                        }
                    } while (seguro == false);
                    do
                    {
                        Console.WriteLine("Ingrese la clasificación: \n" +
                            "1)Todo publico \n" +
                            "2)+13 \n" +
                            "3)+18_");
                        Verificacion();
                        if (seguro == true)
                        {
                            clasificacion = cant;
                        }
                    } while (seguro == false);
                    do
                    {
                        Console.WriteLine("Ingrese la hora en la que se emitira el programa_");
                        VerificacionDouble();
                        if (seguro == true)
                        {
                            emicion = cantb;
                        }
                    } while (seguro == false);
                    do
                    {
                        Console.WriteLine("Ingrese el nivel de producción: \n" +
                            "1)Bajo \n" +
                            "2)Medio \n" +
                            "3)Alto_");
                        Verificacion();
                        if (seguro == true)
                        {
                            nvlProduccion = cant;
                        }
                    } while (seguro == false);
                }
                validacion1();
                if (valido == true)
                {
                    impact = impacto();
                }
                decicion();
                ContadorPre();
                break;
            case 2:
                Console.WriteLine("Reglas de evaluación");
                Console.WriteLine();
                Console.WriteLine("REGLA DE CLASIFICACIÓN DE HORARIOS \n" +
                    "Clasificación: para todo publico, tiene libertad de horario \n" +
                    "Clasificación: +13, solo tiene habilitado el horario de 6 a 22 horas \n" +
                    "Clasificación: +18, solo tiene habilirado el horario de 22 a 5 horas");
                Console.WriteLine();
                Console.WriteLine("REGLA DE DURACIÓN POR TIPO \n" +
                    "Películas: duración permitida entre 60 a 180 minutos \n" +
                    "Series: duración permitida entre 20 a 90 minutos \n" +
                    "Documentales: duración permitida entre 30 a 120 minutos \n" +
                    "Evento en vivo: duración permitida entre 30 a 240 minutos");
                Console.WriteLine();
                Console.WriteLine("REGLA DE PRODUCCIÓN \n" +
                    "Producción baja: valido solo para, todo publico y +13 \n" +
                    "Producción alta y media: valida para cualquier clasificación");
                break;
            case 3:
                Predominante();
                Console.WriteLine($"Total evaluados: {ingresados} \n" +
                    $"Total publicados: {publicado} \n" +
                    $"Total rechasados: {rechazados} \n" +
                    $"Total en revision: {revisando} \n" +
                    $"Impacto predominante: {predom}\n" +
                    $"Porcentaje de aprobación: {(publicado / ingresados) * 100}");
                break;
            case 4:
                ReinicioTotal();
                Console.WriteLine("Valores reiniciados");
                break;
            case 5:
                Console.WriteLine("Resumen final");
                Console.WriteLine($"Total evaluados: {ingresados} \n" +
                    $"Total publicados: {publicado} \n" +
                    $"Total rechasados: {rechazados} \n" +
                    $"Total en revision: {revisando} \n");
                break;
            default: Console.WriteLine("Opcion invalida"); break;
        }
        Console.WriteLine("\n Precione cualquier tecla para continuar");
        Console.ReadLine();
        Console.Clear();
    } while (opcion != 5);