using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioClip collectSound; // à remplir dans l'inspecteur

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Joue le son directement à la position de la pièce
            if (collectSound != null)
            {
                AudioSource.PlayClipAtPoint(collectSound, transform.position);
            }

            // Ajoute 1 point au score
            if (GameManager.instance != null)
            {
                GameManager.instance.AddScore(1);
            }

            // Détruit la pièce
            Destroy(gameObject);
        }
    }
}
