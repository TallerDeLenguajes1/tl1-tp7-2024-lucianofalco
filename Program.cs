using Empresa;

Empleado Empleado1 = new Empleado();

Console.WriteLine();
Empleado1.Nombre1 = "Favio";
Empleado1.Apellido1 = "Leguina";
Empleado1.Cargo1 = Cargos.Administrativo;
Empleado1.EstadoCivil1 = 'S';
Empleado1.FechaDeNac = new DateTime(1985, 5, 23);
Empleado1.FechaDeIngreso = new DateTime(2005, 3, 15);
Empleado1.SueldoBasico1 = 100000;
//Empleado1.MostrarInformacion();

Console.WriteLine();
Empleado Empleado2 = new Empleado();
Empleado2.Nombre1 = "Sheyla";
Empleado2.Apellido1 = "Astorga";
Empleado2.Cargo1 = Cargos.Ingeniero;
Empleado2.EstadoCivil1 = 'C';
Empleado2.FechaDeNac = new DateTime(1999, 1, 10);
Empleado2.FechaDeIngreso = new DateTime(2015, 9, 11);
Empleado2.SueldoBasico1 = 100000;
//Empleado2.MostrarInformacion();

Console.WriteLine();
Empleado Empleado3 = new Empleado();
Empleado3.Nombre1 = "Luz";
Empleado3.Apellido1 = "Arganaraz";
Empleado3.Cargo1 = Cargos.Ingeniero;
Empleado3.EstadoCivil1 = 'S';
Empleado3.FechaDeNac = new DateTime(1972, 12, 21);
Empleado3.FechaDeIngreso = new DateTime(2015, 9, 11);
Empleado3.SueldoBasico1 = 100000;
//Empleado3.MostrarInformacion();
double montoTotalSalarios = 0;

Empleado[] empleados = new Empleado[3];
empleados[0] = Empleado1;
empleados[1] = Empleado2;
empleados[2] = Empleado3;

foreach (Empleado empleado in empleados)
{
    empleado.MostrarInformacion();
    Console.WriteLine();
}

foreach (Empleado empleado in empleados)
{
    montoTotalSalarios += empleado.CalcularSalario();
}

Console.WriteLine($"Total salarios : {montoTotalSalarios}");

Empleado empleadoProximoAJubilarse = empleados[0];
int aniosProximoAJubilarse = empleadoProximoAJubilarse.CalcularAnioJub();
foreach (Empleado empleado in empleados)
{
    int aniosParaJubilacion = empleado.CalcularAnioJub();
    if (aniosParaJubilacion < aniosProximoAJubilarse)
    {
        empleadoProximoAJubilarse = empleado;
        aniosProximoAJubilarse = aniosParaJubilacion;
    }
}

// Mostrar los datos del empleado más próximo a jubilarse
Console.WriteLine("Datos del empleado más próximo a jubilarse:");
empleadoProximoAJubilarse.MostrarInformacion();







