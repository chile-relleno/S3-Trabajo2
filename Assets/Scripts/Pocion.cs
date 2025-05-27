using UnityEngine;

public class Pocion : MonoBehaviour
{
    private void OnTriggerEnter(Collider otro)
    {
        if (otro.name == "Player")
        {
            // Aumenta el contador global
           // ControlJuego.pociones++;

            // Destruye la poción
            Destroy(gameObject);

           // Debug.Log("Pociones: " + ControlJuego.pociones);

        }
    }
}
