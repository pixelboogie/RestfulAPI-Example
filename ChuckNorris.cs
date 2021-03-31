using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChuckNorris : MonoBehaviour
{
    public TextMeshProUGUI jokeText;

    public void NewJoke()
    {
        Debug.Log("NewJoke");
        Joke j = APIHelper.GetNewJoke();
        jokeText.text = j.value;
    }

}
