using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class exercicio04 : MonoBehaviour
{
    //(Verificar item de inventário) Um jogador possui itens limitados
    //no inventário.Verifique se o jogador possui uma "Poção de Vida".
    //Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
    //indisponível".

    [SerializeField] bool pocaoVida; // true

    void Start()
    {
        if (pocaoVida == true)         
        {
            print("Usando Poção de Vida");
        } else
        {
            print("Poção indisponível");
        }
    }

    
    void Update()
    {
        
    }
}
