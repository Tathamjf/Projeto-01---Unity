using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Desafio01 : MonoBehaviour
{
    //Escreva um programa que conta o número de consoantes em uma string.

    [SerializeField] string palavra = "";
    [SerializeField] int consoante;


    char[] vogais = { 'a', 'e', 'i', 'o', 'u' };
    void Start()
    {
        for (int i = palavra.Length - 1; i >= 0; i--)
        {
            char c = palavra[i];
            vogais.Contains(c);
            if (!vogais.Contains(c))
            {
                consoante++;
            }
        }
        print(consoante);
    }

    // Update is called once per frame
    void Update()
    {

    }
}