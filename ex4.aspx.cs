using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string path = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        path = AppDomain.CurrentDomain.BaseDirectory;
    }

    protected void Button_number_Click(object sender, EventArgs e)
    {
        Random rand = new Random();
        int n = rand.Next(50) + 1;     // creates a number between 1 and 50
        this.Label_number.Text = n.ToString();
        double width = 100.0 / n;

        StreamWriter file = new StreamWriter(path + "ex4.html");
        file.WriteLine("<html>");
        file.WriteLine("<head>");
        file.WriteLine("<title>EX-4</title>");
        file.WriteLine("<meta charset = \"utf-8\" />");
        file.WriteLine("<style>");
        file.WriteLine("body {");
        file.WriteLine("margin: 0;");
        file.WriteLine("}");
        file.WriteLine(".size {");
        file.WriteLine("width: " + width + "%;");
        file.WriteLine("height: 100%;");
        file.WriteLine("float: left;");
        file.WriteLine("}");
        file.WriteLine(".column1 {");
        file.WriteLine("background-color: blue;");
        file.WriteLine("}");
        file.WriteLine(".column2 {");
        file.WriteLine("background-color: red;");
        file.WriteLine("}");
        file.WriteLine(".column3 {");
        file.WriteLine("background-color: green;");
        file.WriteLine("}");
        file.WriteLine("</style>");
        file.WriteLine("</head>");
        file.WriteLine("<body>");
        file.WriteLine("<div>");

        for (int i = 0; i < n; i++)
        {
            if (i % 3 == 0)
                file.WriteLine("<div class=\"size column1\" ;></div>");
            else if (i % 3 == 1)
                file.WriteLine("<div class=\"size column2\" ;></div>");
            else
                file.WriteLine("<div class=\"size column3\" ;></div>");
        }

        file.WriteLine("</div>");
        file.WriteLine("</body>");
        file.WriteLine("</html>");

        file.Close();
        System.Diagnostics.Process.Start(path + "ex4.html");
    }
}