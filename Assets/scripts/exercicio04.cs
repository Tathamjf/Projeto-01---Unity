using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class exercicio04 : MonoBehaviour
{
    //(Verificar item de invent�rio) Um jogador possui itens limitados
    //no invent�rio.Verifique se o jogador possui uma "Po��o de Vida".
    //Se possuir, exiba "Usando Po��o de Vida"; caso contr�rio, "Po��o
    //indispon�vel".

    [SerializeField] bool pocaoVida; // true

    void Start()
    {
        if (pocaoVida == true)         
        {
            print("Usando Po��o de Vida");
        } else
        {
            print("Po��o indispon�vel");
        }
    }

    
    void Update()
    {
        
    }
}
