using UnityEngine;

public class RecolectableChupeta1_Controlador : MonoBehaviour
{
    public AudioSource SonidoOcio;
    public AudioSource SonidoRecolectado;
    private void Awake()
    {
        SonidoOcio.Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Personaje"))
        {
            Destruir(); 
        }
    }

    [ContextMenu("Destruir Chupeta")]
    public void Destruir()
    {
        Destroy(gameObject);
    }

    /*
    [ContextMenu("Sonido Recolectado")]
    public void ReproducirSonidoRecolectado()
    {
        SonidoRecolectado.Play();
    }
    */

    private void OnDestroy()
    {
        print("Subir +1 en la Interfaz");
        //Eventos.Chupeta1_Recolectada();
        Eventos.AumentarContadorChupetas1?.Invoke();
    }
}
