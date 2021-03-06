using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{

    

    float offset = 0;
    private bool hasCoin = true;


    // Start is called before the first frame update
    Renderer render;
    void Start()
    {
        render = this.GetComponent<Renderer>();
        StartCoroutine("Animate");

    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        
    }

    void OnCollisionEnter(){
        if (hasCoin){ 
            GameMaster.master.getCoin();
            GameMaster.master.addPoints();
        }

        hasCoin = false;
        

    }

    IEnumerator Animate(){
        while(true){
        render.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
        offset = (offset -= 0.2f) % 1; // Prevent incrementing endlessly...
        yield return new WaitForSeconds(0.5f);
        }
    }
    
}
