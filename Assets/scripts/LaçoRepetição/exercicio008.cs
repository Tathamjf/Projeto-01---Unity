using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Exercício008 : MonoBehaviour
{
    //8. (Reverter uma string) Escreva um programa que inverte uma
    //string usando um loop for.

    string nome = "Agatha";
    string inverter;
    void Start()
    {
        for (int i = nome.Length - 1; i >= 0; i--)
        {
            char word = nome[i];
            string letra = word.ToString();
            inverter += letra;

        }
        print("A palavra " + nome + " invertido é : " + inverter);

    }

    // Update is called once per frame
    void Update()
    {

    }
}