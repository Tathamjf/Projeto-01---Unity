using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class exercicio5 : MonoBehaviour
{
    //(Pontua��o de miss�o) Ap�s completar uma miss�o, o jogador
    //recebe pontos.Verifique se ele ganhou mais de 50 pontos.Se sim,
    //exiba "Miss�o bem-sucedida"; caso contr�rio, "Miss�o
    //incompleta".

    [SerializeField] int pontuacaoMissao = 50;
    [SerializeField] string missaoFeita;

    void Start()
    {
        missaoFeita = pontuacaoMissao >= 50 ? "Miss�o bem-sucedida" : "Miss�o incompleta";
        print(missaoFeita);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
