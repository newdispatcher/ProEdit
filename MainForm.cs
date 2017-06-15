using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using UltraCoder;
using FastColoredTextBoxNS;

namespace ProEdit
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 1;

        public EditForm focusChild = null;

        public MainForm()
        {
            InitializeComponent();


            bool higlightline = Properties.Settings.Default.highlightline;

            if(higlightline == true)
            {
                highlightcurrentline.Checked = true;
            }
            else
            {
                highlightcurrentline.Checked = false;
            }

            bool menubar = Properties.Settings.Default.menubar;
            if(menubar == true)
            {
                toolStrip.Visible = true;
                toolBarToolStripMenuItem.Checked = true;
            }
            else
            {
                toolStrip.Visible = false;
                toolBarToolStripMenuItem.Checked = false;
            }

            bool statusstrip = Properties.Settings.Default.statusbar;

            if(statusstrip == true)
            {
                statusStrip.Visible = true;
                statusBarToolStripMenuItem.Checked = true;
            }
            else
            {
                statusStrip.Visible = false;
                statusBarToolStripMenuItem.Checked = false;
            }
        }

       

        private void ShowNewForm(object sender, EventArgs e)
        {
            EditForm childForm = new EditForm();
            childForm.MdiParent = this;
            childForm.Text = "ProTab " + childFormNumber++;
            childForm.Show();

            if (highlightcurrentline.Checked == true)
            {
                focusChild.EditBox.CurrentLineColor = Color.Blue;
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Open file...";

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "All Files (*.*)|*.*|Text File(*.txt)|*.txt|ASP Script|*.asp|Unix Script|*.sh;*.bsh|Batch File|*.bat;*.cmd;*.nt|C Source File|*.c|CoffeScript File|*.litcoffe|C++ Source File|*.cpp;*.hpp;*.hxx;*.cxx;*.cc;*.c++;*.h++;*.hh|C++ Header File|*.h|C# Source File|*.cs|CSS(Cascade Style Sheets) File|*.css|HTML File|*.html;*.htm;*.shtml;*.shtm;*.xhtml;*.hta|Inno Setup Script|*.iss|Java Source File|*.java;*.class;*.jar;*.war;*.ear|Java Script File|*.js|JSP Script File|*.jsp|NSIS Script|*.nsi;*.nsh|Pascal Source File|*.pas;*.inc|Perl Source File|*.pl;*.pm;*.plx|PHP File|*.php;*.php3;*.phtml|Properties File|*.properties|Python File|*.py;*.pyw|Ruby File|*.rb;*.rbw|Scheme File|*.scm;*.smd;*.ss|Windows Resource File|*.rc|Visual Basic Source File|*.vb;*.vbs|XAML File|*.xaml|XML File|*.xml;*.xsml;*.xsl;*.xsd;*.kml;*.wsdl;*.xlf;*.xliff";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;

                EditForm childForm = new EditForm();
                childForm.MdiParent = this;
                childForm.Text = FileName;
                childForm.Show();
                string format = Path.GetExtension(FileName);
                if(format == ".cs")
                {
                    childForm.EditBox.Language = Language.CSharp;
                    simplePlainTexttxtToolStripMenuItem.Checked = false;
                    cToolStripMenuItem.Checked = true;
                    visualBasicToolStripMenuItem.Checked = false;
                    hTMLToolStripMenuItem.Checked = false;
                    javacsriptToolStripMenuItem.Checked = false;
                    pHPToolStripMenuItem.Checked = false;
                    sQLToolStripMenuItem.Checked = false;

                    typelabel.Text = "C# Source file";
                }
                else if (format == ".vb")
                {
                    childForm.EditBox.Language = Language.VB;
                    simplePlainTexttxtToolStripMenuItem.Checked = false;
                    cToolStripMenuItem.Checked = false;
                    visualBasicToolStripMenuItem.Checked = true;
                    hTMLToolStripMenuItem.Checked = false;
                    javacsriptToolStripMenuItem.Checked = false;
                    pHPToolStripMenuItem.Checked = false;
                    sQLToolStripMenuItem.Checked = false;

                    typelabel.Text = "Visual Basic Source file";
                }
                else if (format == ".html")
                {
                    childForm.EditBox.Language = Language.HTML;
                    simplePlainTexttxtToolStripMenuItem.Checked = false;
                    cToolStripMenuItem.Checked = false;
                    visualBasicToolStripMenuItem.Checked = false;
                    hTMLToolStripMenuItem.Checked = true;
                    javacsriptToolStripMenuItem.Checked = false;
                    pHPToolStripMenuItem.Checked = false;
                    sQLToolStripMenuItem.Checked = false;

                    typelabel.Text = "HTML-Hyper Text Markup Language file";
                }
                else if (format == ".js")
                {
                    childForm.EditBox.Language = Language.JS;
                    simplePlainTexttxtToolStripMenuItem.Checked = false;
                    cToolStripMenuItem.Checked = false;
                    visualBasicToolStripMenuItem.Checked = false;
                    hTMLToolStripMenuItem.Checked = false;
                    javacsriptToolStripMenuItem.Checked = true;
                    pHPToolStripMenuItem.Checked = false;
                    sQLToolStripMenuItem.Checked = false;

                    typelabel.Text = "JavaScript Source file";
                }
                else if (format == ".php")
                {
                    childForm.EditBox.Language = Language.PHP;
                    simplePlainTexttxtToolStripMenuItem.Checked = false;
                    cToolStripMenuItem.Checked = false;
                    visualBasicToolStripMenuItem.Checked = false;
                    hTMLToolStripMenuItem.Checked = false;
                    javacsriptToolStripMenuItem.Checked = false;
                    pHPToolStripMenuItem.Checked = true;
                    sQLToolStripMenuItem.Checked = false;

                    typelabel.Text = "PHP Hypertext Preprocessor file";
                }
                else if (format == ".sql")
                {
                    childForm.EditBox.Language = Language.SQL;
                    simplePlainTexttxtToolStripMenuItem.Checked = false;
                    cToolStripMenuItem.Checked = false;
                    visualBasicToolStripMenuItem.Checked = false;
                    hTMLToolStripMenuItem.Checked = false;
                    javacsriptToolStripMenuItem.Checked = false;
                    pHPToolStripMenuItem.Checked = false;
                    sQLToolStripMenuItem.Checked = true;

                    typelabel.Text = "SQL-Structured Query Language file";
                }
                else
                {
                    typelabel.Text = "Other Source File";
                }

                string file = System.IO.File.ReadAllText(FileName);
                childForm.EditBox.Text = file;

                focusChild.actualfilename = FileName;
                
                toolStripStatusLabel.Text = "Ready";

                using (var r = new StreamReader(FileName, detectEncodingFromByteOrderMarks: true))
                {
                    var ec = r.CurrentEncoding;
                    eclabel.Text = "Encoding: " + ec.ToString();
                }
                if(highlightcurrentline.Checked == true)
                {
                    focusChild.EditBox.CurrentLineColor = Color.Blue;
                }
                focusChild.writeinfo = false;
            }
            else
            {
                toolStripStatusLabel.Text = "Ready";
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "All Files (*.*)|*.*|Text File(*.txt)|*.txt|ASP Script|*.asp|Unix Script|*.sh;*.bsh|Batch File|*.bat;*.cmd;*.nt|C Source File|*.c|CoffeScript File|*.litcoffe|C++ Source File|*.cpp;*.hpp;*.hxx;*.cxx;*.cc;*.c++;*.h++;*.hh|C++ Header File|*.h|C# Source File|*.cs|CSS(Cascade Style Sheet) File|*.css|HTML File|*.html;*.htm;*.shtml;*.shtm;*.xhtml;*.hta|Inno Setup Script|*.iss|Java Source File|*.java;*.class;*.jar;*.war;*.ear|Java Script File|*.js|JSP Script File|*.jsp|NSIS Script|*.nsi;*.nsh|Pascal Source File|*.pas;*.inc|Perl Source File|*.pl;*.pm;*.plx|PHP File|*.php;*.php3;*.phtml|Properties File|*.properties|Python File|*.py;*.pyw|Ruby File|*.rb;*.rbw|Scheme File|*.scm;*.smd;*.ss|Windows Resource File|*.rc|Visual Basic Source File|*.vb;*.vbs|XAML File|*.xaml|XML File|*.xml;*.xsml;*.xsl;*.xsd;*.kml;*.wsdl;*.xlf;*.xliff";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;

                focusChild.actualfilename = saveFileDialog1.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(focusChild.EditBox != null)
            {
                focusChild.EditBox.Cut();
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(focusChild != null)
            {
                focusChild.EditBox.Copy();
            }
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(focusChild != null)
            {
                focusChild.EditBox.Paste();
            }
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(focusChild != null)
                {
                    focusChild.EditBox.Language = FastColoredTextBoxNS.Language.CSharp;

                    typelabel.Text = "C# Source file";

                    simplePlainTexttxtToolStripMenuItem.Checked = false;
                    cToolStripMenuItem.Checked = true;
                    visualBasicToolStripMenuItem.Checked = false;
                    hTMLToolStripMenuItem.Checked = false;
                    javacsriptToolStripMenuItem.Checked = false;
                    pHPToolStripMenuItem.Checked = false;
                    sQLToolStripMenuItem.Checked = false;
                }
            }
            catch
            {
                MessageBox.Show("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            focusChild = null;

            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.ContainsFocus)
                {
                    focusChild = (EditForm)childForm;
                    if (!childForm.Text.Contains("(Selected)"))
                        childForm.Text += " (Selected)";
                }
                else
                    if (childForm.Text.Contains("(Selected)"))
                        childForm.Text = childForm.Text.Remove(childForm.Text.IndexOf("(Selected)") - 1);
            }
        }
        //Undo
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(focusChild != null)
            {
                focusChild.EditBox.Undo();
            }
        }
        //Save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Save file...";
            saveFileDialog1.Filter = "All Files (*.*)|*.*|Text File(*.txt)|*.txt|ASP Script|*.asp|Unix Script|*.sh;*.bsh|Batch File|*.bat;*.cmd;*.nt|C Source File|*.c|CoffeScript File|*.litcoffe|C++ Source File|*.cpp;*.hpp;*.hxx;*.cxx;*.cc;*.c++;*.h++;*.hh|C++ Header File|*.h|C# Source File|*.cs|CSS(Cascade Style Sheet) File|*.css|HTML File|*.html;*.htm;*.shtml;*.shtm;*.xhtml;*.hta|Inno Setup Script|*.iss|Java Source File|*.java;*.class;*.jar;*.war;*.ear|Java Script File|*.js|JSP Script File|*.jsp|NSIS Script|*.nsi;*.nsh|Pascal Source File|*.pas;*.inc|Perl Source File|*.pl;*.pm;*.plx|PHP File|*.php;*.php3;*.phtml|Properties File|*.properties|Python File|*.py;*.pyw|Ruby File|*.rb;*.rbw|Scheme File|*.scm;*.smd;*.ss|Windows Resource File|*.rc|Visual Basic Source File|*.vb;*.vbs|XAML File|*.xaml|XML File|*.xml;*.xsml;*.xsl;*.xsd;*.kml;*.wsdl;*.xlf;*.xliff";

            if (focusChild != null)
            {
                if (focusChild.writeinfo == true)
                {


                    if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {


                        StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

                        sw.Write(focusChild.EditBox.Text);
                        sw.Close();

                        focusChild.actualfilename = saveFileDialog1.FileName;
                        toolStripStatusLabel.Text = "Ready";
                        focusChild.writeinfo = false;

                    }
                    else
                    {
                        toolStripStatusLabel.Text = "Ready";

                    }


                }

                else
                {
                    StreamWriter sw = new StreamWriter(focusChild.actualfilename);

                    sw.Write(focusChild.EditBox.Text);
                    sw.Close();
                    toolStripStatusLabel.Text = "Ready";
                }
            }
            
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(focusChild != null)
            {
                focusChild.EditBox.Redo();
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (focusChild != null)
            {
                focusChild.EditBox.SelectAll();
            }
        }

        private void runToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RunForm run = new RunForm();
            run.ShowDialog();
        }

        private void internetSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebSearch ws = new WebSearch();
            ws.ShowDialog();
        }

        private void textEditHTML10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"teh.exe");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           if(MessageBox.Show("Are you sure you want to exit the program?", "Are you sure you want to exit the program?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
           {
               e.Cancel = true;
           }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void searchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if(focusChild != null)
            {
                focusChild.EditBox.ShowFindDialog();
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (focusChild != null)
            {
                focusChild.EditBox.ShowReplaceDialog();
            }
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (focusChild != null)
            {
                focusChild.EditBox.ShowGoToDialog();
            }
        }

        private void highlightcurrentline_Click(object sender, EventArgs e)
        {
            if (focusChild != null)
            {
                if (highlightcurrentline.Checked == true)
                {
                    focusChild.EditBox.CurrentLineColor = Color.Blue;
                }
                else
                {
                    focusChild.EditBox.CurrentLineColor = Color.Transparent;
                }
            }
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new HotkeysEditorForm(focusChild.EditBox.HotkeysMapping);
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    focusChild.EditBox.HotkeysMapping = form.GetHotkeys();
            }
            catch
            {
                MessageBox.Show("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (focusChild != null)
            {
                focusChild.EditBox.ShowFindDialog();
            }
        }

        private void run_Click(object sender, EventArgs e)
        {
            RunForm rf = new RunForm();
            rf.ShowDialog();
        }

        private void addbookmark_Click(object sender, EventArgs e)
        {
            if (focusChild != null)
            {
                focusChild.EditBox.BookmarkLine(focusChild.EditBox.Selection.Start.iLine);
            }
        }

        private void removebookmark_Click(object sender, EventArgs e)
        {
            if (focusChild != null)
            {
                focusChild.EditBox.UnbookmarkLine(focusChild.EditBox.Selection.Start.iLine);
            }
        }

        private void toolStripSplitButton1_DropDownOpening(object sender, EventArgs e)
        {
            if (focusChild != null)
            {
                toolStripSplitButton1.DropDownItems.Clear();
                foreach (var bookmark in focusChild.EditBox.Bookmarks)
                {
                    var item = toolStripSplitButton1.DropDownItems.Add(bookmark.Name + " [" + Path.GetFileNameWithoutExtension(focusChild.EditBox.Tag as String) + "]");
                    item.Tag = bookmark;
                    item.Click += (o, a) =>
                    {
                        var b = (Bookmark)(o as ToolStripItem).Tag;
                        try
                        {
                            focusChild.EditBox = b.TB;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                        b.DoVisible();
                    };
                }
            }
        }

        private void startStopMacroRecordingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (focusChild != null)
            {
                focusChild.EditBox.MacrosManager.IsRecording = !focusChild.EditBox.MacrosManager.IsRecording;
            }
        }

        private void executeMacroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(focusChild != null)
            {
                focusChild.EditBox.MacrosManager.ExecuteMacros();
            }
        }

        private void zoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (focusChild != null)
                {
                    System.Drawing.Font currentFont = focusChild.EditBox.Font;

                    focusChild.EditBox.Font = new Font(currentFont.FontFamily, currentFont.Size + 1);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void visualBasicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (focusChild != null)
                {
                    focusChild.EditBox.Language = FastColoredTextBoxNS.Language.VB;


                    typelabel.Text = "Visual Basic Source file";


                    simplePlainTexttxtToolStripMenuItem.Checked = false;
                    cToolStripMenuItem.Checked = false;
                    visualBasicToolStripMenuItem.Checked = true;
                    hTMLToolStripMenuItem.Checked = false;
                    javacsriptToolStripMenuItem.Checked = false;
                    pHPToolStripMenuItem.Checked = false;
                    sQLToolStripMenuItem.Checked = false;
                }
            }
            catch
            {
                MessageBox.Show("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (focusChild != null)
                {
                    focusChild.EditBox.Language = FastColoredTextBoxNS.Language.HTML;

                    typelabel.Text = "HTML-Hyper Text Markup Language file";

                    simplePlainTexttxtToolStripMenuItem.Checked = false;
                    cToolStripMenuItem.Checked = false;
                    visualBasicToolStripMenuItem.Checked = false;
                    hTMLToolStripMenuItem.Checked = true;
                    javacsriptToolStripMenuItem.Checked = false;
                    pHPToolStripMenuItem.Checked = false;
                    sQLToolStripMenuItem.Checked = false;
                }
            }
            catch
            {
                MessageBox.Show("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void javacsriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (focusChild != null)
                {
                    focusChild.EditBox.Language = FastColoredTextBoxNS.Language.JS;

                    typelabel.Text = "JavaScript Source file";
                    simplePlainTexttxtToolStripMenuItem.Checked = false;
                    cToolStripMenuItem.Checked = false;
                    visualBasicToolStripMenuItem.Checked = false;
                    hTMLToolStripMenuItem.Checked = false;
                    javacsriptToolStripMenuItem.Checked = true;
                    pHPToolStripMenuItem.Checked = false;
                    sQLToolStripMenuItem.Checked = false;
                }
            }
            catch
            {
                MessageBox.Show("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (focusChild != null)
                {
                    focusChild.EditBox.Language = FastColoredTextBoxNS.Language.PHP;
                    typelabel.Text = "PHP Hypertext Preprocessor file";

                    simplePlainTexttxtToolStripMenuItem.Checked = false;
                    cToolStripMenuItem.Checked = false;
                    visualBasicToolStripMenuItem.Checked = false;
                    hTMLToolStripMenuItem.Checked = false;
                    javacsriptToolStripMenuItem.Checked = false;
                    pHPToolStripMenuItem.Checked = true;
                    sQLToolStripMenuItem.Checked = false;
                }
            }
            catch
            {
                MessageBox.Show("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (focusChild != null)
                {
                    focusChild.EditBox.Language = FastColoredTextBoxNS.Language.SQL;

                    typelabel.Text = "SQL-Structured Query Language file";
                    simplePlainTexttxtToolStripMenuItem.Checked = false;
                    cToolStripMenuItem.Checked = false;
                    visualBasicToolStripMenuItem.Checked = false;
                    hTMLToolStripMenuItem.Checked = false;
                    javacsriptToolStripMenuItem.Checked = false;
                    pHPToolStripMenuItem.Checked = false;
                    sQLToolStripMenuItem.Checked = true;
                }
            }
            catch
            {
                MessageBox.Show("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simplePlainTexttxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (focusChild != null)
                {
                    focusChild.EditBox.Language = FastColoredTextBoxNS.Language.Custom;


                    simplePlainTexttxtToolStripMenuItem.Checked = true;
                    cToolStripMenuItem.Checked = false;
                    visualBasicToolStripMenuItem.Checked = false;
                    hTMLToolStripMenuItem.Checked = false;
                    javacsriptToolStripMenuItem.Checked = false;
                    pHPToolStripMenuItem.Checked = false;
                    sQLToolStripMenuItem.Checked = false;
                }
            }
            catch
            {
                MessageBox.Show("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void helpToolStripButton1_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void openWithDefaultBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (focusChild != null)
                {
                    System.Diagnostics.Process.Start(focusChild.actualfilename);
                }
            }
            catch
            {
                MessageBox.Show("Error! Save the file!", "Error launch file in browser!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                if (focusChild != null)
                {
                    System.Diagnostics.Process.Start(focusChild.actualfilename);
                }
            }
            catch
            {
                MessageBox.Show("Error! Save the file!", "Error launch file in browser!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            focusChild.EditBox.BookmarkLine(focusChild.EditBox.Selection.Start.iLine);
        }

        private void removeBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            focusChild.EditBox.UnbookmarkLine(focusChild.EditBox.Selection.Start.iLine);
        }

        private void collapseSelectedBlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(focusChild != null)
            {
                focusChild.EditBox.CollapseBlock(focusChild.EditBox.Selection.Start.iLine, focusChild.EditBox.Selection.End.iLine);
            }
        }

        private void increaseIndentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(focusChild != null)
            {
                focusChild.EditBox.IncreaseIndent();
            }
        }

        private void decreaseIndentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (focusChild != null)
            {
                focusChild.EditBox.DecreaseIndent();
            }
        }

        private void commentSelectedLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (focusChild != null)
            {
                focusChild.EditBox.InsertLinePrefix(focusChild.EditBox.CommentPrefix);
            }
        }

        private void uncommentSelectedLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (focusChild != null)
            {
                focusChild.EditBox.RemoveLinePrefix(focusChild.EditBox.CommentPrefix);
            }
        }

        private void autoIntentSelectedTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (focusChild != null)
            {
                focusChild.EditBox.DoAutoIndent();
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (focusChild != null)
            {
                focusChild.EditBox.Print(new PrintDialogSettings() { ShowPrintPreviewDialog = true });
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (focusChild != null)
            {
                focusChild.EditBox.Print();
            }
        }

        private void zoomout_Click(object sender, EventArgs e)
        {
            try
            {
                if (focusChild != null)
                {
                    System.Drawing.Font currentFont = focusChild.EditBox.Font;

                    focusChild.EditBox.Font = new Font(currentFont.FontFamily, currentFont.Size - 1);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm opf = new OptionsForm();
            opf.ShowDialog();
        }

        private void wrapLengthLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (focusChild != null)
            {
                if (wrapLengthLinesToolStripMenuItem.Checked == true)
                {
                    focusChild.EditBox.WordWrap = true;
                }
                else
                {
                    focusChild.EditBox.WordWrap = false;
                }
            }
        }



        
        

        

        







    }
}
