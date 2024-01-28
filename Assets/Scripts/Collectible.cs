using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Varsayılan olarak "Player" tag'ini kullanıyoruz
        {
            // Collectible alındığında BarController'ın CollectibleCollected fonksiyonunu çağır
            FindObjectOfType<BarController>().CollectibleCollected();

            // Collectible nesnesini yok et veya diğer işlemleri gerçekleştir
            Destroy(gameObject);
        }
    }
}