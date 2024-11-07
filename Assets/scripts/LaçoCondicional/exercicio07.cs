using UnityEngine;
using static Unity.Burst.Intrinsics.X86;
using static UnityEditor.PlayerSettings;
using static UnityEngine.EventSystems.EventTrigger;

public class exercicio07 : MonoBehaviour
{
    //(Dado com N faces) Para fazer um jogo de RPG, vamos precisar
    //calcular probabilidades e simular a rolagem de dados.
    //Crie um script em que o usuário defina o número de faces de um dado
    //(int) e calcule a rolagem de um dado com esse número de faces.
    //Use a função abaixo para o cálculo: Random.Range (valor_min,
    //valor_max); (Coloque o código dentro da função-evento Start).

    [SerializeField] int facesDado = 6;
    [SerializeField] int valorMin = 1;
    [SerializeField] int resultado = 0;

    void Start()
    {
        resultado = Random.Range(valorMin, facesDado);
        print(resultado);


             
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
