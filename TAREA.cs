using System;

//1
public class Persona
{
    public string nombre;
    public int edad;
    public string ciudad;

    public void Saludar()
    {
        Console.WriteLine("Hola, mi nombre es " + nombre + " y tengo " + edad + " años.");
    }
}

//2
public class Circulo
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public double CalcularArea()
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

//3
public class Estudiante
{
    public string nombre;
    public double nota1;
    public double nota2;
    public double nota3;

    public double CalcularPromedio()
    {
        return (nota1 + nota2 + nota3) / 3;
    }

    public void MostrarDatos()
    {
        Console.WriteLine("Nombre: " + nombre + ", Promedio: " + CalcularPromedio().ToString("F2"));
    }
}

//4
public class Empleado
{
    public string nombre;
    public double salario;

    public Empleado(string nombre, double salario)
    {
        this.nombre = nombre;
        this.salario = salario;
    }
}

//4
public class Gerente : Empleado
{
    public double bono;

    public Gerente(string nombre, double salario, double bono) : base(nombre, salario)
    {
        this.bono = bono;
    }

    public double CalcularSalarioTotal()
    {
        return salario + bono;
    }
}

//5
public class Rectangulo
{
    private double baseRect;
    private double altura;

    public Rectangulo(double baseRect, double altura)
    {
        this.baseRect = baseRect;
        this.altura = altura;
    }

    public double CalcularArea()
    {
        return baseRect * altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (baseRect + altura);
    }

    public void MostrarDatos()
    {
        Console.WriteLine("Área: " + CalcularArea().ToString("F2") + ", Perímetro: " + CalcularPerimetro().ToString("F2"));
    }
}

//6
public class Calculadora
{
    public int Sumar(int a, int b)
    {
        return a + b;
    }

    public double Sumar(double a, double b)
    {
        return a + b;
    }

    public int Sumar(int a, int b, int c)
    {
        return a + b + c;
    }
}

//7
public class CuentaBancaria
{
    public string titular;
    private double saldo;

    public CuentaBancaria(string titular, double saldoInicial)
    {
        this.titular = titular;
        if (saldoInicial >= 0)
            this.saldo = saldoInicial;
        else
            this.saldo = 0;
    }

    public CuentaBancaria(string titular) : this(titular, 0)
    {
    }

    public void Depositar(double cantidad)
    {
        if (cantidad > 0)
        {
            saldo += cantidad;
        }
        else
        {
            Console.WriteLine("La cantidad a depositar debe ser positiva.");
        }
    }

    public void Retirar(double cantidad)
    {
        if (cantidad > 0 && cantidad <= saldo)
        {
            saldo -= cantidad;
        }
        else
        {
            Console.WriteLine("Cantidad inválida o saldo insuficiente.");
        }
    }

    public void MostrarSaldo()
    {
        Console.WriteLine("Saldo actual de " + titular + ": $" + saldo.ToString("F2"));
    }
}

//8
public class Vehiculo
{
    public string marca;
    public string modelo;

    public Vehiculo(string marca, string modelo)
    {
        this.marca = marca;
        this.modelo = modelo;
    }
}

//8
public class Auto : Vehiculo
{
    public Auto(string marca, string modelo) : base(marca, modelo)
    {
    }

    public void Acelerar()
    {
        Console.WriteLine("El auto " + marca + " está acelerando.");
    }
}

//9
public class Producto
{
    private string nombre;
    private double precio;

    public string getNombre()
    {
        return nombre;
    }

    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public double getPrecio()
    {
        return precio;
    }

    public void setPrecio(double valor)
    {
        if (valor < 0)
        {
            throw new ArgumentException("El precio no puede ser negativo.");
        }
        precio = valor;
    }

    public Producto(string nombre, double precio)
    {
        setNombre(nombre);
        setPrecio(precio);
    }

    public void MostrarInfo()
    {
        Console.WriteLine("Producto: " + nombre + ", Precio: $" + precio.ToString("F2"));
    }
}

//10
public abstract class Animal
{
    public abstract void HacerSonido();
}

//10
public class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("Guau");
    }
}

//10
public class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("Miau");
    }
}

class Program
{
    static void Main()
    {
        //1
        Console.WriteLine("Ejercicio 1");
        Persona p = new Persona();
        p.nombre = "Ana";
        p.edad = 25;
        p.Saludar();

        //2
        Console.WriteLine("Ejercicio 2");
        Circulo c = new Circulo(3);
        Console.WriteLine("Área: " + c.CalcularArea().ToString("F2"));
        Console.WriteLine("Perímetro: " + c.CalcularPerimetro().ToString("F2"));

        //3
        Console.WriteLine("Ejercicio 3");
        Estudiante e = new Estudiante();
        e.nombre = "Luis";
        e.nota1 = 8;
        e.nota2 = 9;
        e.nota3 = 7;
        e.MostrarDatos();

        //4
        Console.WriteLine("Ejercicio 4");
        Gerente g = new Gerente("Carlos", 5000, 1000);
        Console.WriteLine("Salario total: $" + g.CalcularSalarioTotal().ToString("F2"));

        //5
        Console.WriteLine("Ejercicio 5");
        Rectangulo r = new Rectangulo(5, 4);
        r.MostrarDatos();

        //6
        Console.WriteLine("Ejercicio 6");
        Calculadora calc = new Calculadora();
        Console.WriteLine("Suma (2,3): " + calc.Sumar(2, 3));
        Console.WriteLine("Suma (1.5,2.5): " + calc.Sumar(1.5, 2.5));
        Console.WriteLine("Suma (1,2,3): " + calc.Sumar(1, 2, 3));

        //7
        Console.WriteLine("Ejercicio 7");
        CuentaBancaria cuenta = new CuentaBancaria("María", 100);
        cuenta.Depositar(50);
        cuenta.Retirar(30);
        cuenta.MostrarSaldo();

        //8
        Console.WriteLine("Ejercicio 8");
        Auto auto = new Auto("Toyota", "Corolla");
        auto.Acelerar();

        //9
        Console.WriteLine("Ejercicio 9");
        Producto prod = new Producto("Mouse", 25.99);
        prod.MostrarInfo();

        //10
        Console.WriteLine("Ejercicio 10");
        Animal perro = new Perro();
        Animal gato = new Gato();
        perro.HacerSonido();
        gato.HacerSonido();
    }
}