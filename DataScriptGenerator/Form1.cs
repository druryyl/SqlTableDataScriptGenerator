using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;
using Dapper;

namespace DataScriptGenerator;
public partial class Form1 : Form
{
    private string _connString;
    private string _pathDb = "_db.txt";
    private string _pathServer = "_server.txt";
    private string _pathTable = "_table.txt";


    public Form1()
    {
        InitializeComponent();
        try
        {
            using (StreamReader sr = File.OpenText(_pathServer))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    ServerTextBox.Text = s;
                }
            }
            using (StreamReader sr = File.OpenText(_pathDb))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    DbTextBox.Text = s;
                }
            }
            using (StreamReader sr = File.OpenText(_pathTable))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    TableNameTextBox.Text = s;
                }
            }
        }
        catch (System.IO.FileNotFoundException e)
        {

        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        _connString = $"Server={ServerTextBox.Text};Database={DbTextBox.Text};User Id=sa;Password=b35mart1c5?;";
        var scriptText = GenerateScript(TableNameTextBox.Text);
        ScriptTextBox.Text = scriptText;
    }

    private string GenerateScript(string tableName)
    {
        var sql = $"SELECT * FROM {tableName}";
        var sb = new StringBuilder();
        using (var conn = new SqlConnection(_connString))
        {
            var dr = conn.ExecuteReader(sql);
            while (dr.Read())
            {
                sb.Append($"INSERT INTO {tableName} VALUES (");
                var dataType = string.Empty;
                for (int i = 0; i <= dr.FieldCount - 1; i++)
                {
                    dataType = dr.GetDataTypeName(i);
                    if (dataType == "varchar")
                    {
                        var x = Convert.ToString(dr[i]).Replace("'", "`");
                        sb.Append($"'{x}',");
                    }
                    else if (dataType == "bit")
                    {
                        int x = Convert.ToBoolean(dr[i]) ? 1 : 0;
                        sb.Append($"{x.ToString()},");
                    }
                    else
                    {
                        sb.Append($"{dr[i].ToString()},");
                    }

                }

                sb.Remove(sb.Length-1, 1);
                sb.Append(')');
                sb.Append(System.Environment.NewLine);
            }
            sb.Append(System.Environment.NewLine);
            sb.Append("---------------------");
            sb.Append(System.Environment.NewLine);
            sb.Append(System.Environment.NewLine);
        }

        return sb.ToString();
    }

    private void DbServerTextBox_Validated(object sender, EventArgs e)
    {
        if (sender == DbTextBox)
        {
            using (FileStream fs = File.Create(_pathDb))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(DbTextBox.Text);
                fs.Write(info, 0, info.Length);
            }
        }

        if (sender == ServerTextBox)
        {
            using (FileStream fs = File.Create(_pathServer))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(ServerTextBox.Text);
                fs.Write(info, 0, info.Length);
            }
        }
        if (sender == TableNameTextBox)
        {
            using (FileStream fs = File.Create(_pathTable))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(TableNameTextBox.Text);
                fs.Write(info, 0, info.Length);
            }
        }
    }

    private void ScriptMultiTableButton_Click(object sender, EventArgs e)
    {
        _connString = $"Server={ServerTextBox.Text};Database={DbTextBox.Text};User Id=sa;Password=b35mart1c5?;";
        var listTables = ListTableTextBox.Text.Split(
            new string[] {Environment.NewLine},
            StringSplitOptions.None).ToList();

        var currentFolder = Path.GetDirectoryName(Application.ExecutablePath);
        var folder = new DirectoryInfo(currentFolder).CreateSubdirectory("script-result");

        foreach (var tableName in listTables)
        {
            var script  = GenerateScript(tableName);
            using (FileStream fs = File.Create($@"script-result\{tableName}.sql"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(script);
                fs.Write(info, 0, info.Length);
            }
        }

        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            Arguments = folder.Name,
            FileName = "explorer.exe"
        };

        Process.Start(startInfo);
    }
}
