using UnityEngine;

public class exercicio006 : MonoBehaviour
{
    //6. (Fizz Buzz) Para cada n�mero entre 0 e 10000, escreva apenas
    //�fizz� no console quando for divis�vel por 3, �buzz� quando for
    //divis�vel por 5 e �fizz buzz� quando for divis�vel pelos dois.Se o
    //n�mero n�o for divis�vel por nenhum deles, escreva-o no console.

    [SerializeField] int fizz;
    [SerializeField] float buzz;
    [SerializeField] float fizz_buzz;
    void Start()
    {
        for (int i = 0; i < 10000; i++)
        {
            if (i % 5 == 0 && i % 3 == 0)
            {
                print("fizz buzz");
            }
            else if (i % 3 == 0)
            {
                print("fizz");
            }
            else if (i % 5 == 0)
            {
                print("buzz");
            }
            else
            {
                print(i);
            }


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
