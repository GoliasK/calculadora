using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;

public class calculadoracontroler : MonoBehaviour
{
    [SerializeField] private Text TextDisplay1; 
    [SerializeField] private Text TextDisplay2;
    [SerializeField] private Color blackBackground = Color.black;
    [SerializeField] private Color numberBlue = Color.blue;
    [SerializeField] private Color buttomBlak = Color.black;
    
    
    //Color Write
    [SerializeField] private Color whiteBackground = Color.white;
    
    //UI Components.
    [SerializeField] private Text[] font ;
    [SerializeField] private Sprite spriteButtons;
    [SerializeField] private Camera MainCamera;
  private string _expression;


    // Start is called before the first frame update
    void Start()
    {
        TextDisplay1.text = "";
        TextDisplay2.text = "";
       
    }

    public void BtnCharacter(string character)
    {
        TextDisplay2.text = character;
        TextDisplay1.text = TextDisplay1.text + TextDisplay2.text;
        
    }
      public void ExprecionCalculator()
      {
        _expression = TextDisplay1.text;
        DataTable table = new DataTable("tabela");
        string _result = table.Compute(_expression, string.Empty).ToString();
       //Debug.Log(_result);
        TextDisplay2.text = _result;
      }

      public void Limpar()
      {
        TextDisplay1.text = "";
      }
      public void ChoiceBackColor()
    {
        MainCamera.backgroundColor = blackBackground;
        TextDisplay1.color = whiteBackground;
        TextDisplay2.color = whiteBackground;
    }

    public void ChoicecWhiteColor()
    {
        MainCamera.backgroundColor = whiteBackground;
        TextDisplay1.color = blackBackground;
        TextDisplay2.color = blackBackground;
    }  
    // Update is called once per frame
    void Update()
    {
        
    }

    }


