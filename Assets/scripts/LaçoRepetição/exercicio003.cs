using UnityEngine;

public class exercicio003 : MonoBehaviour
{
    //3. (Cálculo de moedas coletadas) O jogador coleta 3 moedas a
    //cada fase.Após 10 fases, exiba o total de moedas coletadas.

    [SerializeField] int moedas = 0;
    void Start()
    {


        for (int i = 0; i < 10; i++)
        {
            moedas += 3;
            print("Você coletou " + moedas + " moedas!!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
