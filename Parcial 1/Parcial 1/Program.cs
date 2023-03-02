using System;
{
    Console.WriteLine("\tJUAN CARLOS ADOLFO ALAY ANTONIO\n");
    Console.WriteLine("\tPor favor ingrese su número de carnet. \n\t Ejemplo. 09052012345");
    //Almacenamos el carnet dentro de la variable carnet
    long carnet = Convert.ToInt64(Console.ReadLine());

    if (carnet % 2 == 0)
    {   par:
        Console.Clear();
        Console.WriteLine($"\tSu carnet: {carnet} es par\n");
        Console.WriteLine("\tIngrese un número positivo que sea mayor que 0 \n");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n > 0)
        {   
            //Inciso 4
            int i = 1;
            do
            {
                Console.WriteLine("\tNÚMEROS MENORES O IGUALES A: " + n +" \n");
                for (; i <= n; i++)
                {
                    if (i <= n)
                    {
                        Console.WriteLine("\t" + i);
                    }
                }
            } while (i <= n);

            //Inciso 5
            int k = 1;
            do
            {
                Console.WriteLine("\n\tNÚMEROS IMPARES MENORES O IGUALES QUE: "+ n + "\n");
                for (; k <= n; k++)
                {
                    if (k % 2 > 0)
                    {
                        Console.WriteLine("\t" + k);
                    }
                }
            } while (k <= n);

            //Inciso 6
            int l = 1;
            do 
            {
                Console.WriteLine("\n\tTABLA DE MULTIPLICAR DE: " + n);
                for (; l <= 10; l++)
                {
                    Console.WriteLine($"\t{n} x {l} = {n*l}"); 
                }
               
            } while (l <= n);
        }
        else
        {
            Console.WriteLine("\tEl número deber ser mayor que 0\n\tSe le redireccionará al menú seleccionado luego de que presione ENTER");
            Console.ReadKey();
            goto par; 
        }
    }
    else
    {   impar:
        Console.Clear();
        Console.WriteLine($"\tSu carnet: {carnet} es impar\n");
        //Inciso 1
        int n, factorial = 1;

        //Acá se le solicita al usuario ingresar un número positivo
        Console.WriteLine("\tIngrese un número entero positivo mayor que 0: \n");
        n = int.Parse(Console.ReadLine());
        //acá verificamos que el número sea mayor que 0 
        if (n > 0)
        {
            for (int i = 1; i <= n; i++) { 
                //acá calculamos el factorial 
                factorial *= i;
            }
            //Inciso 2
            int j = 1;
            do
            {
                Console.WriteLine("\tNÚMEROS DIVISIBLES ENTRE 3: \n");
                for (; j <= n; j++)
                {
                    if (j % 3 == 0)
                    {
                        Console.WriteLine("\t" + j);
                    }
                } 
            } while ( j <= n);
            // Inciso 3
            int k = 1;
            do
            {
                Console.WriteLine("\n\tNÚMEROS DIVISBLES ENTRE 5: \n");
                for (; k <= n; k++)
                {
                    if (k % 5 == 0)
                    {   
                        Console.WriteLine("\t" + k);
                    }
                }
            } while (k <= n);
            // Inciso 4
            int l = 0;
            Console.WriteLine("\n\tLa secuencia de números enteros positivos que incrementan en 2 hasta alcanzar un valor mayor que n: "+ n + "\n");
            while (l <= n)
            {
                Console.WriteLine("\t" + (l + 1));
                l += 2;
            }
            //Acá se imprime el inciso número 5 que es el resultado del factorial
            Console.WriteLine("\n\tEl valor del factorial es de: " + factorial);
        }
        else
        {
            Console.WriteLine("\tEl número deber ser mayor que 0\n\tSe le redireccionará al menú seleccionado luego de que presione ENTER");
            Console.ReadKey();
            goto impar;

        }
    }
}