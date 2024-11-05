using System;
using Unity.VisualScripting;
using UnityEngine;

public class exercicio09 : MonoBehaviour
{
    //(Placar final) Crie um script que l� o placar de uma partida entre
    //time A e time B.Depois, escreva no console qual dos tr�s
    //resultados poss�veis aconteceu: vit�ria do time A, vit�ria do time B
    //ou empate.Se o empate teve mais de 3 pontos para cada lado,
    //escreva que foi �um empate emocionante�.

    [SerializeField] int placarMax = 3;
    [SerializeField] int placarMin = 3;

    int resultadoA;
    int resultadoB;
    

    void Start()
    {
        resultadoA = UnityEngine.Random.Range(placarMin, placarMax);
        resultadoB = UnityEngine.Random.Range(placarMin, placarMax);
        print("TIME A: " + resultadoA + " TIME B: " + resultadoB);

        if (resultadoA == resultadoB && resultadoA >= 3 && resultadoB >= 3)
        {
            print("Um empate EMOCIONANTE!!!");
        } else if (resultadoA > resultadoB)
        {
            print("Vit�ria do time A!");
        } else
        {
            print("Vit�ria do time B!");
        }
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
