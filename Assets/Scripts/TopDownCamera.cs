using UnityEngine;

public class TopDownCamera : MonoBehaviour
{
    public Transform target; // Takip edilecek hedefin referans�
    public float distance = 5f; // Kamera ile hedef aras�ndaki mesafe
    public float height = 5f; // Kamera y�ksekli�i

    void LateUpdate()
    {
        if (target == null)
            return;

        // Hedefin pozisyonunu al
        Vector3 targetPosition = target.position;

        // Kameray� hedefin �st�ne yerle�tir
        Vector3 cameraPosition = targetPosition - distance * Vector3.back + height * Vector3.up;

        // Kameran�n rotasyonunu ayarla
        transform.rotation = Quaternion.Euler(90f, 0f, 0f); // Tepeden bakma a��s� i�in rotasyonu ayarla

        // Kameran�n pozisyonunu g�ncelle
        transform.position = cameraPosition;
    }
}
