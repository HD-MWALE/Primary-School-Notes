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
using Syncfusion.Windows.Forms.PdfViewer;

namespace Primary_School_Notes
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            Application.EnableVisualStyles();
            pdfViewer = new PdfViewerControl();
            pdfViewer.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(pdfViewer);
        }
        private void Home_Load(object sender, EventArgs e)
        {
            btnStandard8_Click(sender, e);
            lblDocumentName.Text = ">";
        }
        PdfViewerControl pdfViewer;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                pdfViewer.Load((string)e.Node.Tag);
                foreach (Control control in flpSide.Controls)
                {
                    if (control is Button)
                    {
                        if (control.BackColor == SystemColors.MenuHighlight)
                        {
                            lblDocumentName.Text = control.Text + " > " + GetSubjectName((string)e.Node.Tag) + " > " + e.Node.Text;
                            break;
                        }
                    }
                }
            }
        }
        string[] Standard = Directory.GetDirectories(Application.StartupPath + "\\Notes");
        private void btnStandard8_Click(object sender, EventArgs e)
        {
            btnStandard8.BackColor = SystemColors.MenuHighlight;
            btnStandard7.BackColor = SystemColors.Control;
            btnStandard6.BackColor = SystemColors.Control;
            btnStandard5.BackColor = SystemColors.Control;
            LoadNotes(btnStandard8.Text);
        }

        private void btnStandard7_Click(object sender, EventArgs e)
        {
            btnStandard8.BackColor = SystemColors.Control;
            btnStandard7.BackColor = SystemColors.MenuHighlight;
            btnStandard6.BackColor = SystemColors.Control;
            btnStandard5.BackColor = SystemColors.Control;
            LoadNotes(btnStandard7.Text);
        }

        private void btnStandard6_Click(object sender, EventArgs e)
        {
            btnStandard8.BackColor = SystemColors.Control;
            btnStandard7.BackColor = SystemColors.Control;
            btnStandard6.BackColor = SystemColors.MenuHighlight;
            btnStandard5.BackColor = SystemColors.Control;
            LoadNotes(btnStandard6.Text);
        }

        private void btnStandard5_Click(object sender, EventArgs e)
        {
            btnStandard8.BackColor = SystemColors.Control;
            btnStandard7.BackColor = SystemColors.Control;
            btnStandard6.BackColor = SystemColors.Control;
            btnStandard5.BackColor = SystemColors.MenuHighlight;
            LoadNotes(btnStandard5.Text);
        }

        private void LoadNotes(string buttonText)
        {
            foreach (string standard in Standard)
            {
                if (standard.Contains(buttonText))
                {
                    treeView1.Nodes.Clear();
                    string[] subjects = Directory.GetDirectories(standard);
                    int i = 0;
                    foreach (string subject in subjects)
                    {
                        treeView1.Nodes.Add(GetSubjectName(subject));
                        string[] notes = Directory.GetFiles(subject);
                        foreach (string note in notes)
                        {
                            treeView1.Nodes[i].Nodes.Add(GetNotesName(note)).Tag = note;
                        }
                        i++;
                    }
                    break;
                }
            }
        }

        private string GetNotesName(string notes)
        {
            string[] strings = notes.Split('\\');
            foreach (string s in strings)
            {
                if (s.Contains(".pdf"))
                {
                    return s.Split('.')[0];
                }
            }
            return notes;
        }

        private string GetSubjectName(string subject)
        {
            string[] strings = subject.Split('\\');
            foreach (string s in strings)
            {
                switch (s)
                {
                    case "Agriculture": return s;
                    case "Bible Knowledge": return s;
                    case "Chichewa": return s;
                    case "English": return s;
                    case "Expressive Arts": return s;
                    case "Life Skills": return s;
                    case "Science and Technology": return s;
                    case "Social Studies": return s;
                    default: break;
                }
            }
            return subject;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            // set file filter of dialog   
            dlg.Filter = "pdf files (*.pdf) |*.pdf;";
            dlg.ShowDialog();
            if (dlg.FileName != null)
            {
                pdfViewer.Load((string)dlg.FileName);
                lblDocumentName.Text = dlg.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Closing the application?", "Primary School Notes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
