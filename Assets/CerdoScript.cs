using UnityEngine;

public class CerdoScript : MonoBehaviour
{
    public SpriteRenderer imagenCerdo;
    public Sprite cerdoRoto;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        {
            CambiarImagen();
            Invoke("DestruccionCerdo", 1);
        }
    }

    private void CambiarImagen()
    {
        imagenCerdo.sprite = cerdoRoto;
    }

    private void DestruccionCerdo()
    {
        Destroy(gameObject);
    }
}



