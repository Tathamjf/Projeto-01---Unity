using UnityEngine;

public class exercicio03 : MonoBehaviour
{
    [SerializeField] bool PlayerVivo; // true
    [SerializeField] bool powerUp; // true
    double vidaPlayer = 100;
    void Start()
    {
        if (PlayerVivo == false && powerUp == true)
        {
            vidaPlayer = vidaPlayer * 0.5;
            print("Ainda não, vida atual " + vidaPlayer);
        }
        else
        {
            print("Game Over");
        }


    }

   
    void Update()
    {

    }

}

