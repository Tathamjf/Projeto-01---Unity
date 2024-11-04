using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    //(Escolha de personagem) O jogador pode escolher entre o personagem Guerreiro ou Mago.
    //]Exiba "Guerreiro escolhido" se o
    //jogador selecionar Guerreiro e "Mago escolhido" se selecionar Mago.

    [SerializeField] int personagem = 0;

    void Start()
    {
        switch (personagem)
        {
            case 1:
                print("Guerreiro Escolhido");
                break;

            case 2:
                print("Mago Escolhido");
                break ;

            default:
                print("Valor não identificado");
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
