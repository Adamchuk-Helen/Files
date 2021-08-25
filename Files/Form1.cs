using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Files
{
    public partial class Form1 : Form
    {
        List<File1> lbList = new List<File1>();
        public Form1()
        {
            InitializeComponent();
            string desctopPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(desctopPath);
            System.IO.FileInfo[] files = dir.GetFiles();
            
            
            File1 file = new File1();
            
            foreach (var f in files)
            {
                lbList.Add(new File1() { Name = f.Name, Size = Convert.ToInt32(f.Length), Type= f.Extension}) ;
            }
            

            foreach (var x in lbList)
            {
                Console.WriteLine(x.Name);
            }
            

            foreach (var x in lbList)
            {
                lbFiles.Items.Add( x.Name);
            }
        }

        private void lbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public class File1
        {
            public string Name;
            public int Size;
            public string Type;
        }

        private void lbFiles_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
            foreach (var i in lbList)
            {
                if (i.Name==lbFiles.SelectedItem.ToString())
                {
                    tbName.Text = i.Name;
                    tbFormat.Text = i.Type;
                    tbSize.Text = Convert.ToString(i.Size);
                }
            }
        }

    

        private void btCreate_Click(object sender, EventArgs e)
        {
            string newfile = tbCreateFile.Text;
            string desctopPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
           
            using (FileStream fs = File.Create(desctopPath+"\\" +newfile))
            {
                
            }

            
        }
    }
}
