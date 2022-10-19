using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;

public class calculadoracontroler : MonoBehaviour
{
    [SerializeField] private Text TextDisplay1; 
    [SerializeField] private Text TextDisplay2;
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
    // Update is called once per frame
    void Update()
    {
        
    }

    }


