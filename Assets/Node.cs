
public class Node
{
    public bool endNode { get; set; }
    public string question { get; set; }
    public string answer { get; set; }
    public Node Izquierdo { get; set; }
    public Node Derecho { get; set; }

    public Node(bool valor, string pregunta, string respuesta)
    {
        endNode = valor;
        question = pregunta;
        answer = respuesta;
        Izquierdo = null;
        Derecho = null;
    }
}
