using UnityEngine;

public class LaçoRepetição : MonoBehaviour
{
    //For - quando sei a quantidade de vezes que vai repetir

    //while ou doWhile - é usado quando nao se sabe a quantidade de repetições

    //foreach - usado em listas ou arrays para executar uma operação para cada item da lista

    //array - é uma lista

    int x = 0; //While
    int y = 10; //Do While

    void Start()
    {
        //for(inicializador: condição, incremento/decremento);

        //for (int i = 0; i <= 10; i++)
        //{

        //if(i == 5)
        //{
        //  break;
        //}

        //if(i == 6)
        //{
        //    continue;
        //}

        //print(i);    

        //}

        ////While
        //while (x <= 10 )
        //{
        //    print(x);
        //    x++;

        //}


        ////Do While
        //do
        //{
        //    print(y);
        //    y--;
        //}
        //while (y >= 0);

        int[] num = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        print(num[3]);

        num[0]++;
        print(num[0]);

        string[] nomes;

        nomes = new string[5];
        nomes[0] = "Tadeuuu";

        print(nomes[0]);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
