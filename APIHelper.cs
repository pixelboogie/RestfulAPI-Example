using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net; // needed
using System.IO; // needed

public static class APIHelper
{

    public static Joke GetNewJoke()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.chucknorris.io/jokes/random");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<Joke>(json);
    }

}
