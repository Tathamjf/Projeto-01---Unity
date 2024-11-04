using UnityEngine;


public class exercicio02 : MonoBehaviour
{
    [SerializeField] bool powerUp;

    void Start()
    {
        //if (powerUp == true)
        //{
        //    print("PowerUp encontrado");
        //} else
        //{
        //    print("Nenhum PowerUp encontrado");
        //}

        print(powerUp ? "PowerUp encontrado" : "Nenhum PowerUp encontrado");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
