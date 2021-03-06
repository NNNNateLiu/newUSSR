using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class UI : MonoBehaviour

{
    public Animator TurnPage;
    public GameObject theButton1;
    public GameObject theButton2;
    Vector3 position1=new Vector3(300,0,0);
    Vector3 position2=new Vector3(0,0,0);
    Vector3 position3=new Vector3(600,0,0);
    private Vector3 velocity = Vector3.zero;
    public RectTransform panelRectTransform;
    public AudioMixer audioMixer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void turnbooksound(){
        gameObject.GetComponent<AudioSource>().Play();
    }

    public void rotateleft(){
        
        TurnPage.SetBool("Left",true);
        TurnPage.SetBool("Right",false);
        theButton1.SetActive(false);
        theButton2.SetActive(true);
    }
    public void rotateright(){
        TurnPage.SetBool("Right",true);
        TurnPage.SetBool("Left",false);
        theButton1.SetActive(false);
        theButton2.SetActive(true);
    }
    public void startmenu(){
        
        RectTransform mytransform=GetComponent<RectTransform>();
        mytransform.anchoredPosition=Vector3.SmoothDamp(position2,position1,ref velocity,Time.deltaTime*0.001f);
        GetComponent<Animator>().enabled=false;}
    public void endmenu(){
         RectTransform mytransform=GetComponent<RectTransform>();
        mytransform.anchoredPosition=Vector3.SmoothDamp(position1,position2,ref velocity,Time.deltaTime*0.001f);}

    public void returnmenu(){
         RectTransform mytransform=GetComponent<RectTransform>();
        mytransform.anchoredPosition=Vector3.SmoothDamp(position2,position3,ref velocity,Time.deltaTime*0.001f);}

    public void setparents(){
         panelRectTransform.SetAsLastSibling();
    }

    public void musiccontrol(float value){
        audioMixer.SetFloat("MusicVolume",value);
    }

    public void soundcontrol(float value){
        audioMixer.SetFloat("SoundVolume",value);
    }

     public void EndGame(){

         Application.Quit();
    }
    
}

