using UnityEngine;
using static UnityEditor.Progress;

public class exercicio10 : MonoBehaviour
{

    //(Itens do inventário) Crie um script onde o jogador pode coletar
    //diferentes tipos de itens (como moedas, poções, ou power-ups)
    //que têm efeitos diferentes dependendo do tipo coletado.Use um
    //switch case para determinar o efeito de cada tipo de item.,

    [SerializeField] int inventario;


    void Start()
    {
        switch (inventario)
        {
            case 1:
                print("Moeda coletada! \n Valor obtido: \n 100 moedas.");
                break;

            case 2:
                print("Poção de Cura coletada! \n Efeitos da poção: \n Regenera 20% da vida inical.");
                break;

            case 3:
                print("Power Up coletado! \n Efeitos do Power Up coletado: \n Eleva os atributos de força e velocidade do personagem em 15%");
                break;

            default:
                print("Nenhum item coletado.");
                break;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
