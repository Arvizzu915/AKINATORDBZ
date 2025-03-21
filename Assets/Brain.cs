using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Brain : MonoBehaviour
{
    [SerializeField] private GameObject playingPanel, selectionPanel, winPanel, losePanel;

    public TextMeshProUGUI pregunta, respuesta;
    private Node[] nodos = new Node[47];
    private Node nodoActual = null;

    private bool playing = false;
    private string correctAnswer = null;


    private void Awake()
    {
        //-------------CREAR NODOS-----------------------------------------------------------------------------------------------------
        nodos[0] = new Node(false, "ES UN SAIYAJIN", null);
        nodos[1] = new Node(false, "MUERE", null);
        nodos[2] = new Node(false, "ES O FUE MALO MALO YA ADULTO", null);
        nodos[3] = new Node(false, "TIENE PELO", null);
        nodos[4] = new Node(false, "SE PUEDE TRANSFORMAR EN SSJ", null);
        nodos[5] = new Node(true, null, "VEGETA");
        nodos[6] = new Node(true, null, "RADITZ");
        nodos[7] = new Node(false, null, "NAPA");
        nodos[8] = new Node(false, "ES UN SAIYAJIN PURO", null);
        nodos[9] = new Node(true, null, "GOKU");
        nodos[10] = new Node(false, "PIERDE UN BRAZO", null);
        nodos[11] = new Node(true, null, "GOHAN DEL FUTURO");
        nodos[12] = new Node(true, null, "GOHAN ADULTO");
        nodos[13] = new Node(false, "ES UNA FUSIÓN", null);
        nodos[14] = new Node(false, "USA LOS ZARCILLOS POTARA", null);
        nodos[15] = new Node(true, null, "VEGETTO");
        nodos[16] = new Node(false, "ES LA FUSION DE GOTEN Y TRUNKS", null);
        nodos[17] = new Node(true, null, "GOTENKS");
        nodos[18] = new Node(true, null, "GOGETA");
        nodos[19] = new Node(false, "FUE EL PRIMERO EN ALCANZAR LA FASE DE SUPERSAIYAJIN 2", null);
        nodos[20] = new Node(true, null, "GOHAN ADOLESCENTE");
        nodos[21] = new Node(true, null, "TRUNKS");
        nodos[22] = new Node(false, "ES HUMANO", null);
        nodos[23] = new Node(false, "ES DE LA ESCUELA DE LA TORTUGA", null);
        nodos[24] = new Node(false, "ES FAMOSO POR AL MENOS UNA MUERTE", null);
        nodos[25] = new Node(false, "ES ENANO", null);
        nodos[26] = new Node(true, null, "KRILIN");
        nodos[27] = new Node(true, null, "YAMCHA");
        nodos[28] = new Node(true, null, "ROSHI"); 
        nodos[29] = new Node(false, "FUE MODIFICADO POR EL DR. GERO", null);
        nodos[30] = new Node(false, "PELEA EN EL TORNEO DE LAS ARTES MARCIALES CONTRA “MIGHTY MASK”", null);
        nodos[31] = new Node(true, null, "N 18");
        nodos[32] = new Node(true, null, "N 17");
        nodos[33] = new Node(true, null, "BULMA");
        nodos[34] = new Node(false, "SE FUSIONA O ABSORBE A ALGUIEN", null);
        nodos[35] = new Node(false, "ES NAMEKIANO", null);
        nodos[36] = new Node(false, "ES EL MENTOR DE GOHAN", null);
        nodos[37] = new Node(true, null, "PICCOLO");
        nodos[38] = new Node(true, null, "KAMI SAMA");
        nodos[39] = new Node(false, "ES “PERFECTO”", null);
        nodos[40] = new Node(true, null, "CELL");
        nodos[41] = new Node(true, null, "BUU");
        nodos[42] = new Node(false, "ES CONOCIDO COMO “EL EMPERADOR DEL UNIVERSO”", null);
        nodos[43] = new Node(true, null, "FREEZER");
        nodos[44] = new Node(false, "PIENSA QUE VEGETA LOS VA A TRAICIONAR", null);
        nodos[45] = new Node(true, null, "TEN SHIN HAN");
        nodos[46] = new Node(true, null, "MR POPO");


        //---------------------------------------------------ASIGNAR NODOS-------------------------------------------------------------------------------------

        nodos[0].Derecho = nodos[1];
        nodos[0].Izquierdo = nodos[22];

        nodos[1].Derecho = nodos[2];
        nodos[1].Izquierdo = nodos[13];

        nodos[2].Derecho = nodos[3];
        nodos[2].Izquierdo = nodos[8];

        nodos[3].Derecho = nodos[4];
        nodos[3].Izquierdo = nodos[7];

        nodos[4].Derecho = nodos[5];
        nodos[4].Izquierdo = nodos[6];

        nodos[8].Derecho = nodos[9];
        nodos[8].Izquierdo = nodos[10];

        nodos[10].Derecho = nodos[11];
        nodos[10].Izquierdo = nodos[12];

        nodos[13].Derecho = nodos[14];
        nodos[13].Izquierdo = nodos[19];

        nodos[14].Derecho = nodos[15];
        nodos[14].Izquierdo = nodos[16];

        nodos[16].Derecho = nodos[17];
        nodos[16].Izquierdo = nodos[18];

        nodos[19].Derecho = nodos[20];
        nodos[19].Izquierdo = nodos[21];

        nodos[22].Derecho = nodos[23];
        nodos[22].Izquierdo = nodos[34];

        nodos[23].Derecho = nodos[24];
        nodos[23].Izquierdo = nodos[29];

        nodos[24].Derecho = nodos[25];
        nodos[24].Izquierdo = nodos[28];

        nodos[25].Derecho = nodos[26];
        nodos[25].Izquierdo = nodos[27];

        nodos[29].Derecho = nodos[30];
        nodos[29].Izquierdo = nodos[33];

        nodos[30].Derecho = nodos[31];
        nodos[30].Izquierdo = nodos[32];

        nodos[34].Derecho = nodos[35];
        nodos[34].Izquierdo = nodos[42];

        nodos[35].Derecho = nodos[36];
        nodos[35].Izquierdo = nodos[39];

        nodos[36].Derecho = nodos[37];
        nodos[36].Izquierdo = nodos[38];

        nodos[39].Derecho = nodos[40];
        nodos[39].Izquierdo = nodos[41];

        nodos[42].Derecho = nodos[43];
        nodos[42].Izquierdo = nodos[44];

        nodos[44].Derecho = nodos[45];
        nodos[44].Izquierdo = nodos[46];

        //------------------------------------------------------------------------------------------------------------------------------------------------------

        nodoActual = nodos[0];
    }

    private void Update()
    {
        pregunta.text = nodoActual.question;
        if (respuesta != null)
        {
            respuesta.text = nodoActual.answer;
        }
        else
        {
            respuesta.text = "pensando...";
        }
    }

    public void RecorrerNodoDerecha()
    {
        
        nodoActual = nodoActual.Derecho;
        if (nodoActual.endNode)
        {
            if (nodoActual.answer == correctAnswer)
            {
                playingPanel.gameObject.SetActive(false);
                winPanel.gameObject.SetActive(true);
            }
            else
            {
                playingPanel.gameObject.SetActive(false);
                losePanel.gameObject.SetActive(true);
            }
        }
    }

    public void RecorrerNodoIzquierda()
    {
        nodoActual = nodoActual.Izquierdo;
        if (nodoActual.endNode)
        {
            if (nodoActual.answer == correctAnswer)
            {
                playingPanel.gameObject.SetActive(false);
                winPanel.gameObject.SetActive(true);
            }
            else
            {
                playingPanel.gameObject.SetActive(false);
                losePanel.gameObject.SetActive(true);
            }
        }
    }

    public void Choose(string character)
    {
        selectionPanel.gameObject.SetActive(false);
        playingPanel.gameObject.SetActive(true);
        correctAnswer = character;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
