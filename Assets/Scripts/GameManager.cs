using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    // Start is called before the first frame update
    //public Text propText;

    //int prop;


    public void GameOver()
    {
        isGameOver = true;

        //Llamar funcion de forma normal
        //LoadScene();

        //Invocamos la funcion despues de 1.5 segundos
        //Invoke("LoadScene", 1.5f);

        //Llamamos la corutina LoadScene
        StartCoroutine("LoadScene");
    }

    /*void LoadScene()
  {
      SceneManager.LoadScene(2);
  }*/


    /*public void AddProp()
    {
        prop++;
        propText.text = coins.ToString();
    }*/
}
