using System;
using Unity.VisualScripting;
using UnityEngine;

public class exercicio09 : MonoBehaviour
{
    //(Placar final) Crie um script que lê o placar de uma partida entre
    //time A e time B.Depois, escreva no console qual dos três
    //resultados possíveis aconteceu: vitória do time A, vitória do time B
    //ou empate.Se o empate teve mais de 3 pontos para cada lado,
    //escreva que foi “um empate emocionante”.

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
            print("Vitória do time A!");
        } else
        {
            print("Vitória do time B!");
        }
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
