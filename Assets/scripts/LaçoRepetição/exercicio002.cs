using UnityEngine;

public class exercicio002 : MonoBehaviour

    //2. (Multiplicação de dano) Um personagem ataca cinco vezes, e o
    //dano do ataque aumenta em 2 a cada vez.Exiba o dano a cada
    //ataque.
{
    
    void Start()
    {
        int dano = 2;
        for (int hit = 0; hit < 5; hit++)
        {
            dano += 2;
            print(dano);
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
