using Mono.Data.Sqlite;
using System;
using System.Data;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CrearSol : MonoBehaviour, IPointerEnterHandler
{
    public Text TextScore;

    public static CrearSol Gamecontroller;

    public static String scoreSol = "";

    private void Update()
    {
        if (scoreSol.Equals("soldelospastos"))
        {
            TextScore.gameObject.SetActive(true);
        }

    }

    private void Awake()
    {
        Gamecontroller = this;
    }

    private void Start()
    {
        ReadDatabase();
    }

    void ReadDatabase()
    {
        string conn = "URI=file:" + Application.dataPath + "/SoupBD.db"; //Path to database.
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); //Open connection to the database.
        IDbCommand dbcmd = dbconn.CreateCommand();
        string sqlQuery = "SELECT * FROM pregunta";
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();
        object preguntas = " ";
        object respuestas = " ";
        Debug.Log(reader.Read());
        while (reader.Read())
        {
            preguntas = reader.GetValue(0);
            respuestas = reader.GetValue(1);

            Debug.Log("respuestas: " + reader.GetValue(1) + "ghd: " + reader.GetValue(2));
            TextScore.text += "\n" + reader.GetValue(2) + scoreSol.ToString();
        }
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        dbconn.Close();
        dbconn = null;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }
}
