using UnityEngine;

public class exercicio004 : MonoBehaviour
{
    //4. (Pontua��o em combos) Cada combo realizado aumenta em 10
    //pontos.Exiba a pontua��o total ap�s 7 combos.

    [SerializeField] int combos = 0;
    void Start()
    {
        for (int i = 0; i < 7; i++)
        {
            combos += 10;
            print("Um total de " + combos + " pontos!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
