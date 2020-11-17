using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject target;
    private Material mat;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        mat = target.GetComponent<Renderer>().material;
    }

    public void Clicked()
    {
        print("Botão pressionado!");
        mat.color = new Color(Random.value, Random.value, Random.value);
    }
}
