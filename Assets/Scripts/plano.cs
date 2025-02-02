using UnityEngine;

public class GroundMover : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        // Mover el suelo hacia atr�s
        transform.Translate(Vector3.back * velocidad * Time.deltaTime);

        // Revisar si el suelo ha salido del campo de visi�n y resetearlo
        if (transform.position.z < -50f)
        {
            // Ajusta el valor de -50f seg�n la longitud de tu pista
            transform.Translate(Vector3.forward * 100f);
        }
    }
}


