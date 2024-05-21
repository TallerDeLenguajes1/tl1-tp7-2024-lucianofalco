namespace Empresa ; 

public enum Cargos{
    Auxiliar, 
    Administrativo,
    Ingeniero,
    Especialista, 
    Investigador 
}

public class Empleado
{
    private string Nombre   ;
    private string Apellido ;
    private char EstadoCivil ;
    private double SueldoBasico ;
    private DateTime fechaDeIngreso ;
    private DateTime fechaDeNac ;
    private Cargos Cargo ;

    public string Nombre1 { get => Nombre; set => Nombre = value; }
    public string Apellido1 { get => Apellido; set => Apellido = value; }
    public char EstadoCivil1 { get => EstadoCivil; set => EstadoCivil = value; }
    public double SueldoBasico1 { get => SueldoBasico; set => SueldoBasico = value; }
    public DateTime FechaDeIngreso { get => fechaDeIngreso; set => fechaDeIngreso = value; }
    public DateTime FechaDeNac { get => fechaDeNac; set => fechaDeNac = value; }
    public Cargos Cargo1 { get => Cargo; set => Cargo = value; }

    public int CalcularAntiguedad(){
        DateTime hoy = DateTime.Now;
        int antiguedad = hoy.Year - FechaDeIngreso.Year ;
        if (hoy.Month < FechaDeIngreso.Month || (hoy.Month == FechaDeIngreso.Month && hoy.Day < FechaDeIngreso.Day))
            {
                antiguedad--;
            }
        return antiguedad;
    }

    public int CalcularEdad(){
        DateTime hoy = DateTime.Now;
        int edad = hoy.Year - FechaDeNac.Year ;
        if (hoy.Month < FechaDeNac.Month || (hoy.Month == FechaDeNac.Month && hoy.Day < FechaDeNac.Day))
            {
                edad--;
            }
        return edad;
    }

    public int CalcularAnioJub(){
        DateTime hoy = DateTime.Now;
        int antiguedad = CalcularAntiguedad();
        int edad = CalcularEdad();
        int EdadIngreso = hoy.Year - FechaDeIngreso.Year;
        int anios = 65 - (EdadIngreso + antiguedad );
        return anios ;
    }

    public double CalcularSalario(){
        double adicional = 0 ;
        int antiguedad = CalcularAntiguedad();
        if (antiguedad < 20)
        {
            adicional += SueldoBasico1 * antiguedad * 0.01;
        }
        else
        {
            adicional += SueldoBasico1 * 0.25;
        }

        if ( Cargo1 == Cargos.Ingeniero || Cargo1 == Cargos.Especialista )
        {
            adicional *= 1.5;
        }

        if (EstadoCivil1 == 'C')
        {
            adicional += 150000;
        }

        double Salario = SueldoBasico1 + adicional;
        return Salario;
    }

     public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Fecha de Nacimiento: {fechaDeNac.ToShortDateString()}");
            Console.WriteLine($"Estado Civil: {EstadoCivil}");
            Console.WriteLine($"Fecha de Ingreso: {fechaDeIngreso.ToShortDateString()}");
            Console.WriteLine($"Sueldo Básico: {SueldoBasico}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Antigüedad: {CalcularAntiguedad()} años");
            Console.WriteLine($"Edad: {CalcularEdad()} años");
            Console.WriteLine($"Años para la Jubilación: {CalcularAnioJub()} años");
            Console.WriteLine($"Salario: {CalcularSalario()}");
        }
}
