using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class exercicio5 : MonoBehaviour
{
    //(Pontuação de missão) Após completar uma missão, o jogador
    //recebe pontos.Verifique se ele ganhou mais de 50 pontos.Se sim,
    //exiba "Missão bem-sucedida"; caso contrário, "Missão
    //incompleta".

    [SerializeField] int pontuacaoMissao = 50;
    [SerializeField] string missaoFeita;

    void Start()
    {
        missaoFeita = pontuacaoMissao >= 50 ? "Missão bem-sucedida" : "Missão incompleta";
        print(missaoFeita);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
