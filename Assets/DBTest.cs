using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;

public class DBTest : MonoBehaviour
{
    TextMesh preguntasC, respuestasC;

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
        object preguntas= " ";
        object respuestas=" ";
        while (reader.Read())
        {
             preguntas = reader.GetValue(0);
             respuestas = reader.GetValue(1);

            Debug.Log( "respuestas: " + reader.GetValue(1) + "ghd: " + reader.GetValue(2));
        }
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        dbconn.Close();
        dbconn = null;
    }
}
