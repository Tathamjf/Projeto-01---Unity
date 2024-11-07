using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class exercicio11 : MonoBehaviour
{
    //(Diálogos) Implemente um sistema de diálogos onde o jogador
    //pode interagir com um NPC(personagem não jogável), e o NPC
    //responde com diferentes frases dependendo do estado do jogo.
    //Use switch case para definir as respostas baseadas no estado do
    //jogador.

    [SerializeField] int estado;

    void Start()
    {
        switch (estado)
        {
            case 0:
                print("Ola viajante! tudo bem???");
                break;

            case 1:
                print("Boa Viagem!");
                break;

            case 2:
                print("Acabou, amém!");
                break;

            default:
                print("Ferrou :(");
                break;
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
