using UnityEngine;

public class Contoh : MonoBehaviour
{
    int nyawa = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Tambah(5, 10));
    }

    public void MinumObat()
    {
        Debug.Log("Pemain meminum obat");
        Sembuhkan(30);
    }

    public void Sembuhkan(int tambahanNyawa)
    {
        nyawa = nyawa + tambahanNyawa;
    }

    public int Tambah(int angka1, int angka2)
    {
        int result = angka1 + angka2;
        return result;
    }
}
