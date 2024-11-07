using System;
using Unity.Collections;
using UnityEditor;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class exercicio08 : MonoBehaviour
{
    //(Contador de horas e dias) Crie um script que em que uma
    //variável inteira hora seja incrementada de uma unidade a cada 10
    //segundos e volte a ser 0 quando alcançar o valor 24. Quando
    //completar um ciclo, incremente uma variável dias e escreva o
    //número de dias que se passaram no console. (Coloque o código
    //dentro da função-evento Update).

    [SerializeField] int hora = 0;
    [SerializeField] int dias = 0;
    [SerializeField] float segundos = 0;
    
    void Start()
    {
       


    }

    // Update is called once per frame
    void Update()
    {

        segundos += Time.deltaTime;

        if (segundos >= 10)
        {
            hora++;
            segundos = 0;

            if (hora == 24)
            {
                dias++;
                hora = 0;
                print(dias);
            }

        }

    }
}
