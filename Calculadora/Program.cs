using EspacioCalculadora;

        Calculadora calc = new Calculadora();
        string? entrada;
        double numero;
        int opcion;

        do
        {
            Console.WriteLine("\nCalculadora:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Limpiar");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
            entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcion))
            {
                Console.WriteLine("Opción inválida. Intente nuevamente.");
                continue;
            }

            if (opcion >= 1 && opcion <= 4)
            {
                Console.Write("Ingrese un número: ");
                if (!double.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Número inválido.");
                    continue;
                }
            }
            else
            {
                numero = 0; // No se usa, pero lo inicializamos
            }

            switch (opcion)
            {
                case 1:
                    calc.Sumar(numero);
                    break;
                case 2:
                    calc.Restar(numero);
                    break;
                case 3:
                    calc.Multiplicar(numero);
                    break;
                case 4:
                    calc.Dividir(numero);
                    break;
                case 5:
                    calc.Limpiar();
                    Console.WriteLine("Calculadora reiniciada.");
                    break;
                case 6:
                    Console.WriteLine("Saliendo de la calculadora.");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.WriteLine($"Resultado actual: {calc.Resultado}");

        } while (opcion != 6);

