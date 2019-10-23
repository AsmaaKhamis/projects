using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using word = Microsoft.Office.Interop.Word; 


namespace task3_simulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void FindAndReplace(word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchwholeword = true;
            object matchwiledcards = false;
            object matchsoundlike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchkashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchcontrol = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;
            wordApp.Selection.Find.Execute(ref ToFindText, 
                ref matchCase, ref matchwholeword, 
                ref matchwiledcards, ref matchsoundlike,
                ref matchAlefHamza, ref forward,
                 ref wrap, ref format, ref replaceWithText, 
               ref replace, ref matchkashida,
                 ref matchDiactitics,ref nmatchAllforms, 
                 ref matchcontrol );
        }
        private void CreateDox(object fileName, object SaveAs)
        {
            word.Application wordApp = new word.Application();
            object missing = Missing.Value;
            word.Document myWordDoc = null;
            if (File.Exists((string)fileName))
            {
                object readOnly = false;
                object invisible = false;
                wordApp.Visible = false;
                myWordDoc=wordApp.Documents.Open(ref fileName,ref missing,ref readOnly,
                    ref missing,ref missing,ref missing,
                    ref missing,ref missing,ref missing,
                    ref missing,ref missing,ref missing,
                    ref missing,ref missing,ref missing,ref missing);
                myWordDoc.Activate();
                //find and replace
                this.FindAndReplace(wordApp, "<name>", textBox1.Text);
                this.FindAndReplace(wordApp, "<firstname>", textBox2.Text);
                this.FindAndReplace(wordApp, "<birthday>", dateTimePicker1.Value.ToShortDateString());
                this.FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
                

            }
            else
            {
                MessageBox.Show("File not found");
            }
            //save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                 ref missing, ref missing, ref missing,
                 ref missing, ref missing, ref missing);
             

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Created");


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            CreateDox("D:\\معتصم\\task3_simulation\\Task3_sim.docx", "D:\\معتصم\\task3_simulation\\Document.docx");
        }
    }
}
