using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exerc�cio007 : MonoBehaviour
{
    //7. (Maior n�mero em uma lista) Dada uma lista de n�meros,
    //encontre o maior valor.

    int[] numeros = { 3, 5, 45, 7, 9, 8, 20, 47 };
    int maior = 0;

    void Start()
    {
        //List<int> n = new List<int>();
        //n.Add(1);
        //n.Add(15);
        //n.Add(100);
        //n.Add(34);
        //n.Add(235);
        //n.Add(220);
        //n.Add(126);

        //int num = n.Max();
        //print("O maior n�mero dessa lista � o: " + num);

        maior = numeros[0];

        foreach (var item in numeros)
        {
            if (item > maior)
            {
                maior = item;
            }
        }

        print("O maior numero �: " + maior);
        



    }

    // Update is called once per frame
    void Update()
    {

    }
}