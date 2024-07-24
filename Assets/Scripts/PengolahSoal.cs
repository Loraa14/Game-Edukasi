using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PengolahSoal : MonoBehaviour
{
    public TextAsset assetSoal;

    private string[] soal;

    private string[,] soalBag;

    int indexSoal;

    int maxSoal;

    bool ambilSoal;

    char kunciJ;

    bool[] soalSelesai;

    //Dekralasi Komponen UI
    public Text txtSoal, txtOpsiA, txtOpsiB, txtOpsiC, txtOpsiD;

    bool isHasil;

    private float durasi;

    public float duarasiPenilaian;

    int jwbBenar, jwbSalah;

    float nilai;

    public GameObject panel;
    public GameObject imgPenilaian, imgHasil; 
    public Text txtHasil;

    // Start is called before the first frame update
    void Start()
    {
        durasi = duarasiPenilaian;

        soal = assetSoal.ToString().Split('#');

        soalSelesai = new bool[soal.Length];

        soalBag = new string[soal.Length, 6];
        maxSoal =  soal.Length;

        OlahSoal();
        ambilSoal = true;
        TampilkanSoal();

        print(soalBag[1,2]);
    }

    private void OlahSoal()
    {
        for(int i=0; i < soal.Length; i++)
        {
            string[] tempSoal = soal[i].Split('+');
            for(int j=0; j < tempSoal.Length; j++)
            {
                soalBag[i, j] = tempSoal[j];
                continue;
            }
            continue;
        }
    }

    private void TampilkanSoal()
    {
        if(indexSoal < maxSoal)
        {
            if (ambilSoal)
            {
                for (int i=0; i < soal.Length; i++)
                {
                    int randomIndexSoal = Random.Range(0, soal.Length);
                    print("random:" + randomIndexSoal);
                    if (!soalSelesai[randomIndexSoal])
                    {
                    txtSoal.text = soalBag[indexSoal, 0];
                    txtOpsiA.text = soalBag[indexSoal, 1];
                    txtOpsiB.text = soalBag[indexSoal, 2];
                    txtOpsiC.text = soalBag[indexSoal, 3];
                    txtOpsiD.text = soalBag[indexSoal, 4];
                    kunciJ = soalBag[indexSoal, 5][0];

                    soalSelesai[randomIndexSoal] = true;

                    ambilSoal = false;
                    break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }

    
    private float HitungNilai()
    {
        return nilai = (float)jwbBenar / maxSoal *100;
    }


    public void Opsi(string opsiHuruf)
    {
        CheckJawaban(opsiHuruf[0]);

        if (indexSoal == maxSoal - 1 )
        {
           isHasil = true;
        }
        else
        {
            indexSoal++;
            ambilSoal = true;
        }
        
        panel.SetActive(true);
    }

    public Text txtPenilaian;
    private void CheckJawaban(char huruf)
    {
        string penilaian;
        if(huruf.Equals(kunciJ))
        {
            penilaian = "Benar!";
            jwbBenar++;
        }
        else{
            penilaian = "Salah!";
            jwbSalah++;
        }

        txtPenilaian.text = penilaian;
    }

    
    // Update is called once per frame
    void Update()
    {
        if (panel.activeSelf)
        {
            duarasiPenilaian -= Time.deltaTime;

            if (isHasil)
            {
                imgPenilaian.SetActive(true);
                imgHasil.SetActive(false);

                if (duarasiPenilaian <= 0)
                {
                    txtHasil.text = "Jumlah benar: " + jwbBenar + "\nJumlah Salah: " + jwbSalah + "\n\nNilai: " + HitungNilai();
                  
                    imgPenilaian.SetActive(false);
                    imgHasil.SetActive(true);

                    duarasiPenilaian = 0;
                }
            }
            else
            {
                imgPenilaian.SetActive(true);
                imgHasil.SetActive(false);

                if (duarasiPenilaian <= 0)
                {
                    panel.SetActive(false);
                    duarasiPenilaian = durasi;

                    TampilkanSoal();
                }
            }
        }
   }
}
