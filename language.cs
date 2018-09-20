using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace TMPro.Examples{
public class language : MonoBehaviour {
	
		void FixedUpdate(){
			//Burda kelimeleri tanımla ("türkçesi","ing","eğer eklersen alm fr vb..")
			Language ("Oyna", "Play");
			Language ("Ayarlar", "Options");
			Language ("Oyun Sonu", "Credits");
			Language ("Cikis", "Exit");
			Language ("Müzik", "Music");
			Language ("Efekt","FX");
			Language ("Ses Düzeyi", "Volume");
			Language ("Oyunu Sıfırla", "Stages reset");
			Language ("Yapimci: Erdem kalay", "Creator: Erdem kalay");
			Language ("Bolumler", "Stages");
			Language ("Karakter", "Skin");
			Language ("Bolum "+Application.loadedLevel.ToString(), "Level "+Application.loadedLevel.ToString());
			Language ("Duraklat", "Paused");
			Language ("Geri Don", "Resume");
			Language ("Tekrar", "Restart");
			Language ("Ana Menu", "Main Menu");
			Language ("Bolumler Sifilandi.", "Stages Reseted.");
			Language ("Dogru.", "Correct.");
			Language ("Yanlis.", "Incorrect.");
		}
		public void Language (string tr,string en) {
			//Hangi textmesh eklentisini kullanıyorsan onu ekle.
			var tx = GameObject.FindObjectsOfType<TextMeshProUGUI> ();
			var tx2 = GameObject.FindObjectsOfType<Text> ();
			for (int i = 0; i < tx.Length; i++) {
				if (tx [i].text == tr) {
					//buradan farklı diller ekleyebilirsin else if ekleyerek.
					if (PlayerPrefs.GetString ("language") == "tr") {
						tx [i].SetText (tr);
					} else if (PlayerPrefs.GetString ("language") == "en") {
						tx [i].SetText (en);
					}//else if(PlayerPrefs.GetString("language") == "de"){ tx[i].SetText(de);}
				}
			}
			for (int i = 0; i < tx2.Length; i++) {
				if (tx2 [i].text == tr) {
					//aynı işlemi burayada yapmalısın eğer textmesh birden fazla kullanmıyorsan gereksiz olan forları silebilirsin..
					if (PlayerPrefs.GetString ("language") == "tr") {
						tx2 [i].text = tr;
					} else if (PlayerPrefs.GetString ("language") == "en") {
						tx2 [i].text = en;
					}//else if(PlayerPrefs.GetString("language") == "de"){ tx2[i].text = de;}
				}
			}
	}
}
}