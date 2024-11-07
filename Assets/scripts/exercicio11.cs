using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class exercicio11 : MonoBehaviour
{
    //(Di�logos) Implemente um sistema de di�logos onde o jogador
    //pode interagir com um NPC(personagem n�o jog�vel), e o NPC
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
                print("Acabou, am�m!");
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
