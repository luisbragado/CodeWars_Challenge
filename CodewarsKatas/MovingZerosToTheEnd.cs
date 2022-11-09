/* 21-Abril-2022

Write an algorithm that takes an array and moves all of the zeros to the end, 
preserving the order of the other elements.

Kata: https://www.codewars.com/kata/52597aa56021e91c93000cb0
*/

using System.Linq;

namespace CodewarsKatas
{
    public class MovingZerosToTheEnd
    {
        public static int[] MoveZeroes(int[] arr)
        {
            //Solución 1: recorremos el arreglo para ir intercambiando los valores igual a cero para recorrerlos al final del array
            for (int a = 0; a < arr.Length; a++)
            {
                if (arr[a] > 0)
                    continue;

                //Intercambiamos el valor en la posición A cuando es cero a la posición B cuando esta
                //última sea mayor a cero
                for (int b = a + 1; b < arr.Length; b++)
                {
                    if (arr[b] > 0)
                    {
                        arr[a] = arr[b];
                        arr[b] = 0;
                        break;
                    }
                }
            }
            return arr;

            //Solución 2: uso de Linq
            //return arr.OrderBy(x => x == 0).ToArray();            

            //Solución 3: filtrar números mayores a cero y concatenar un segundo array sólo con los ceros
            //return arr.Where(x => x > 0).Concat(arr.Where(y => y==0)).ToArray();
        }
    }
}
