using System;
using UnityEngine;

public class ClockAnimation : MonoBehaviour
{
    public Transform hourHand;   // Saat çubuğu
    public Transform minuteHand; // Dakika çubuğu
    public Transform secondHand; // Saniye çubuğu

    private void Start()
    {
        Debug.Log(System.DateTime.Now);
    }

    void Update()
    {
        System.DateTime currentTime = System.DateTime.Now;

        // Hassas zaman hesaplaması
        float preciseSeconds = currentTime.Second + (currentTime.Millisecond / 1000f);

        // Saat, dakika ve saniye açılarını hesaplama
        float hourAngle = (currentTime.Hour % 12) * 30 + currentTime.Minute * 0.5f;
        float minuteAngle = currentTime.Minute * 6 + preciseSeconds * 0.1f;
        float secondAngle = preciseSeconds * 6;

        // Çubukları Y ekseni etrafında döndürme
        hourHand.localRotation = Quaternion.Euler(0, hourAngle, 0);
        minuteHand.localRotation = Quaternion.Euler(0, minuteAngle, 0);
        secondHand.localRotation = Quaternion.Euler(0, secondAngle, 0);
    }
}
