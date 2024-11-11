using System;
using System.Diagnostics.Tracing;
using UnityEngine;

public class desafio02 : MonoBehaviour
{
    // Faça um algoritmo que receba o dia, o mês e o ano em que uma pessoa nasceu,
    // imprima na tela quantos anos, meses e dias essa pessoa já viveu.
    // Leve em consideração o ano com 365 dias e o mês com 30 dias.

    [SerializeField] int diaRecebido;
    [SerializeField] int mesRecebido;
    [SerializeField] int anoRecebido;


    void Start()
    {
        // data atual
        DateTime dataAtual = DateTime.Now;

        int diaAtual = dataAtual.Day;
        int mesAtual = dataAtual.Month;
        int anoAtual = dataAtual.Year;

        int anosVividos = (anoAtual - anoRecebido);
        int mesesVividos = (mesAtual - mesRecebido);
        //int diasVividos = (anoAtual - anoRecebido) * 365 + (mesAtual - mesRecebido) * 30 + (diaAtual - diaRecebido);
        int diasVividos = (diaRecebido - diaAtual);
        

        print("Anos vividos: " + anosVividos + "\n Meses vividos: " + mesesVividos + "\n Dias vividos: " + diasVividos);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
