using UnityEngine;

public class PajaroScript : MonoBehaviour
{
    public Rigidbody2D pajaro;
    private bool disparado = false;
    private Vector2 posicionInicioArrastre;
    private Vector2 posicionFinArrastre;


    void Update()
    {
        if (disparado == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                posicionInicioArrastre = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Punto de inicio
            }
            else if (Input.GetMouseButtonUp(0))
            {
                posicionFinArrastre = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Punto de fin
                TirarPajaro();
            }
        }
    }


    private void TirarPajaro()
    {
        Vector2 direccionDeTiro = posicionInicioArrastre - posicionFinArrastre;

        float distanciaDeArrastre = Vector2.Distance(posicionInicioArrastre, posicionFinArrastre);

        pajaro.AddForce(direccionDeTiro * distanciaDeArrastre, ForceMode2D.Impulse);

        disparado = true;
    }
}


