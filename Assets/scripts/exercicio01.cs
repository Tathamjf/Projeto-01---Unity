using UnityEngine;

public class exercicio01 : MonoBehaviour
{
    [SerializeField] int vidaPlayer = 10;

   
    void Start()
    {
        if (vidaPlayer > 0)
        {
            print("Personagem vivo");
        } else
        {
            print("Game Over");
        }
  



    }

    
    void Update()
    {
        
    }
}
