using System;

class Hello
{
    static void Main()
   
    {
         double hawaiana = 150;
            double pepperoni = 155;
            double quesos = 145;
            double margarita = 168;
            double salami = 159;
            double envio = 45;

            Console.WriteLine("Seleccione la pizza que desea comprar:");
            Console.WriteLine("1. Hawaiana - $150");
            Console.WriteLine("2. Pepperoni - $155");
            Console.WriteLine("3. Quesos - $145");
            Console.WriteLine("4. Margarita - $168");
            Console.WriteLine("5. Salami - $159");

            Console.Write("Opción: ");
            int opcion = int.Parse(Console.ReadLine());

            double precio = 0;
            switch (opcion)
            {
                case 1:
                    precio = hawaiana;
                    break;
                case 2:
                    precio = pepperoni;
                    break;
                case 3:
                    precio = quesos;
                    break;
                case 4:
                    precio = margarita;
                    break;
                case 5:
                    precio = salami;
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

            Console.Write("¿Requiere servicio a domicilio? (S/N): ");
            string respuesta = Console.ReadLine();
            bool servicioADomicilio = respuesta.Equals("S") || respuesta.Equals("s");

            Console.Write("¿Desea pagar con tarjeta? (S/N): ");
            respuesta = Console.ReadLine();
            bool pagoConTarjeta = respuesta.Equals("S") || respuesta.Equals("s");

            double montoFinal = precio;
            if (servicioADomicilio)
            {
                montoFinal += envio;
            }
            if (pagoConTarjeta)
            {
                montoFinal *= 1.03;
            }

            Console.WriteLine("Monto a pagar: $" + montoFinal);
            Console.WriteLine("Gracias por su compra.");
    }
}