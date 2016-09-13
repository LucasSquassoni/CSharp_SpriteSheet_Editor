using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace IntroductionToCSharp
{
    public partial class SpriteEditor : Form
    {
        //SpriteEditor
        //
        //Summary: Class Constructor
        public SpriteEditor()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        //Member variables used for Drawing
        Point startPos;
        Point currentPos;
        bool drawing;
        bool drawingActive = false;
        List<RectangleF> myRectangles = new List<RectangleF>();
        Brush paintBrush = new SolidBrush(Color.FromArgb(30, Color.Blue));

        //Member variables used in the delete process
        Point deletePoint;
        string nametoDelete;
        int indexToDelete;

        //Member variables used in sprite management
        List<Sprite> savedSprites = new List<Sprite>();
        Sprite selectedSprite;

        //SpriteViewer MouseDown
        //
        //Summary: Checks Mousedown event in the spriteviewer
        private void SpriteViewer_MouseDown(object sender, MouseEventArgs e)
        {
            if (drawingActive)
            {
                if (e.Button == MouseButtons.Left)
                {
                    currentPos = startPos = e.Location;
                    drawing = true;
                }
            }
        }

        //SpriteViewer MouseMove
        //
        //Summary: Checks MouseMove event in the SpriteViewer
        private void SpriteViewer_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawingActive)
            {
                currentPos = e.Location;
                if (drawing) SpriteViewer.Invalidate();
            }
        }

        //SpriteViewer Paint
        //
        //Summary: Paints the rectangle created in getRectangle
        private void SpriteViewer_Paint(object sender, PaintEventArgs e)
        {
            
            if (myRectangles.Count > 0)
            {
                e.Graphics.FillRectangles(paintBrush, myRectangles.ToArray());
                e.Graphics.DrawRectangles(Pens.Blue, myRectangles.ToArray());
            }
            if (savedSprites.Count > 0)
            {
                foreach (Sprite spr in savedSprites)
                {
                    e.Graphics.FillRectangle(paintBrush, spr.rect);
                    Rectangle rect1 = Rectangle.Round(spr.rect);
                    e.Graphics.DrawRectangle(Pens.Blue, rect1);
                    if (selectedSprite != null)
                    {
                        if (spr.name == selectedSprite.name)
                        {
                            e.Graphics.DrawRectangle(Pens.Red, rect1);
                        }
                    }
                    
                }
            }
            
            if (drawing) e.Graphics.DrawRectangle(Pens.Blue, getRectangle());
        }

        //Get Rectangle
        //
        //Summary: Creates rectangle using Mouse Vector
        private Rectangle getRectangle()
        {
            return new Rectangle(
                Math.Min(startPos.X, currentPos.X),
                Math.Min(startPos.Y, currentPos.Y),
                Math.Abs(startPos.X - currentPos.X),
                Math.Abs(startPos.Y - currentPos.Y));
        }

        //SpriteViewer Mouseup
        //
        //Summary: Checks mouseup event in the SpriteViewer
        private void SpriteViewer_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                drawing = false;
                var rect = getRectangle();
                if (rect.Width > 0 && rect.Height > 0) myRectangles.Add(rect);
                SpriteViewer.Invalidate();
                FillTextBoxInfo();
                SpriteName.Text = String.Empty;
            }
        }

        //Fill Textbox Information
        //
        //Summary: Populates Textboxes with Rectangle information
        private void FillTextBoxInfo()
        {
            XPosText.Text = myRectangles.Last().X.ToString();
            YPosText.Text = myRectangles.Last().Y.ToString();
            WidthText.Text = myRectangles.Last().Width.ToString();
            HeightText.Text = myRectangles.Last().Height.ToString();
        }

        //Empty Textbox Information
        //
        //Empties all textboxes
        private void EmptyTextBoxInfo()
        {
            SpriteName.Text = String.Empty;
            XPosText.Text = String.Empty;
            YPosText.Text = String.Empty;
            WidthText.Text = String.Empty;
            HeightText.Text = String.Empty;
        }

        //Save Selection Button
        //
        //Summary: Takes the information in each textbox and creates a sprite object
        private void SaveSpriteButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(XPosText.Text) || string.IsNullOrWhiteSpace(YPosText.Text) 
            || string.IsNullOrWhiteSpace(WidthText.Text) || string.IsNullOrWhiteSpace(HeightText.Text)
            || string.IsNullOrWhiteSpace(SpriteName.Text))
            {
                MessageBox.Show("One or more of the Sprite text boxes are empty.", "Missing Information...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int x = int.Parse(XPosText.Text, CultureInfo.InvariantCulture);
            int y = int.Parse(YPosText.Text, CultureInfo.InvariantCulture);
            int w = int.Parse(WidthText.Text, CultureInfo.InvariantCulture);
            int h = int.Parse(HeightText.Text, CultureInfo.InvariantCulture);

            savedSprites.Add(new Sprite(x, y, w, h, SpriteName.Text.ToString()));
            
            SpriteListViewer.Items.Add(savedSprites.Last().name);

            int index = new int();

            foreach(var rect in myRectangles)
            {
                
                if(rect.Location == new PointF(x,y) && rect.Size == new SizeF(w,h))
                {
                    index = myRectangles.IndexOf(rect);
                }
            }

            EmptyTextBoxInfo();
            if (myRectangles.Count > 0)
            {
                myRectangles.RemoveAt(index);
            }
            SpriteViewer.Invalidate();

        }

        //Menu Strip Import Image Button
        //
        //Summary: Takes an image directory from file dialog and imports it to the SpriteViewer
        private void importImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Import Image...";
                dlg.Filter = "PNG Images (*.png)|*.png|JPG Images (*.jpg)|*.jpg";
                dlg.InitialDirectory = Application.StartupPath;

                if (dlg.ShowDialog()==DialogResult.OK)
                {
                    SpriteViewer.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        //Menu Strip Export As Button
        //
        //Summary: Opens a File Dialog and serializes all sprite objects into an xml
        private void exportAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML File (*.xml)|*.xml";
            sfd.InitialDirectory = @"Desktop";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Path.GetFileName(sfd.FileName);
            }
            if (sfd.FileName != String.Empty)
            {
                XmlSerializer mySerializer = new XmlSerializer(typeof(List<Sprite>));
                using (StreamWriter myWriter = new StreamWriter(sfd.FileName))
                {
                    mySerializer.Serialize(myWriter, savedSprites);
                }   
            }
        }

        //Menu Strip Import File Button
        //
        //Summary: Opens a File Dialog and deserializes an xml file into a list of sprite objects 
        private void importFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myRectangles.Clear();
            SpriteListViewer.Items.Clear();
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Import XML File...";
            dlg.Filter = "XML File (*.xml)|*.xml";
            dlg.InitialDirectory = @"Desktop";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Path.GetFileName(dlg.FileName);
            }
            if (dlg.FileName != String.Empty)
            {
                XmlSerializer myDeserializer = new XmlSerializer(typeof(List<Sprite>));
                using(FileStream myFileStream = new FileStream((dlg.FileName),FileMode.Open))
                {
                    savedSprites = (List<Sprite>)myDeserializer.Deserialize(myFileStream);
                }

                foreach (Sprite temp in savedSprites)
                {
                    var rect = new RectangleF(temp.rect.X, temp.rect.Y, temp.rect.Width, temp.rect.Height);
                    //if (rect.Width > 0 && rect.Height > 0) myRectangles.Add(rect);
                    SpriteViewer.Invalidate();
                }
                SpriteViewer.Image = new Bitmap(IntroductionToCSharp.Properties.Resources.megaman7);
            }
            foreach(Sprite spr in savedSprites)
            {
                SpriteListViewer.Items.Add(spr.name);
            }
           
        }

        //Drawing check
        //
        //Summary: Checks if Selection button is active
        private void DrawCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(DrawCheck.Checked == true)
            {
                drawingActive = true;
            }
            else
            {
                drawingActive = false;
            }
        }

        //SpriteViewer Mouseclick
        //
        //Summary: Handles all mouse click events on the spriteviewer
        private void SpriteViewer_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawingActive == false)
            {
                foreach (Sprite sprite in savedSprites)
                {
                    if (sprite.rect.Contains(e.Location) && e.Button == MouseButtons.Left)
                    {
                        //MessageBox.Show(rectangle.ToString());

                        XPosText.Text = sprite.rect.X.ToString();
                        YPosText.Text = sprite.rect.Y.ToString();
                        WidthText.Text = sprite.rect.Width.ToString();
                        HeightText.Text = sprite.rect.Height.ToString();
                        SpriteName.Text = sprite.name.ToString();
                        selectedSprite = sprite;
                    }
                    if (sprite.rect.Contains(e.Location) && e.Button == MouseButtons.Right)
                    {
                        deletePoint = e.Location;
                        nametoDelete = sprite.name;
                        ContextMenu.Show(MousePosition);
                    }
                }
                foreach(RectangleF rect in myRectangles)
                {
                    if (rect.Contains(e.Location) && e.Button == MouseButtons.Left)
                    {
                        //MessageBox.Show(rectangle.ToString());

                        XPosText.Text = rect.X.ToString();
                        YPosText.Text = rect.Y.ToString();
                        WidthText.Text = rect.Width.ToString();
                        HeightText.Text = rect.Height.ToString();
                        SpriteName.Text = String.Empty;
                    }
                    if (rect.Contains(e.Location) && e.Button == MouseButtons.Right)
                    {
                        deletePoint = e.Location;
                        indexToDelete = myRectangles.IndexOf(rect);
                        ContextMenu.Show(MousePosition);
                    }
                }

            }
            SpriteViewer.Invalidate();
        }

        //SpriteViewer Mouse Enter
        //
        //Summary: Changes mouse cursor on a condition
        private void SpriteViewer_MouseEnter(object sender, EventArgs e)
        {
            if(drawingActive == true)
            {
                SpriteViewer.Cursor = Cursors.Cross;
            }
            else
            {
                SpriteViewer.Cursor = Cursors.Default;
            }
        }

        //Right Click Menu Delete Button
        //
        //Summary: Removes the selected Rectangle in the SpriteViewer
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var sprite in savedSprites)
            {
                if (sprite.rect.Contains(deletePoint))
                {
                    SpriteListViewerMissingItem(sprite.name);
                    savedSprites.Remove(sprite);                  
                    EmptyTextBoxInfo();
                    SpriteViewer.Invalidate();
                    return;
                }
            }
            foreach (var rect in myRectangles)
            {
                if (rect.Contains(deletePoint))
                {
                    myRectangles.Remove(rect);
                    EmptyTextBoxInfo();
                    SpriteViewer.Invalidate();
                    return;
                }
            }
        }

        //SpriteListViewer MouseClick
        //
        //Summary: Gets the Selected Sprite in the Sprite queue and highlights it in the SpriteViewer
        private void SpriteListViewer_MouseClick(object sender, MouseEventArgs e)
        {
            if (SpriteListViewer.Items.Count > 0)
            {
                var item = SpriteListViewer.SelectedIndex;
                XPosText.Text = savedSprites.ElementAt(item).rect.X.ToString();
                YPosText.Text = savedSprites.ElementAt(item).rect.Y.ToString();
                WidthText.Text = savedSprites.ElementAt(item).rect.Width.ToString();
                HeightText.Text = savedSprites.ElementAt(item).rect.Height.ToString();
                SpriteName.Text = savedSprites.ElementAt(item).name.ToString();
                selectedSprite = savedSprites.ElementAt(item);
            }
            SpriteViewer.Invalidate();
        }

        //SpriteListViewer Missing Data Check
        //
        //Summary: If a sprite is made from the original data source remove it in the list
        private void SpriteListViewerMissingItem(string a_name)
        {
            for (int n = SpriteListViewer.Items.Count - 1; n >= 0; --n)
            {
                if (SpriteListViewer.Items[n].ToString().Contains(a_name))
                {
                    SpriteListViewer.Items.RemoveAt(n);
                }
            }
        }

        //Menu Strip ClearViewer Button
        //
        //summary: Clears the entire Window
        private void clearViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpriteViewer.Image = null;
            savedSprites.Clear();
            SpriteListViewer.Items.Clear();
        }

        //Export to XML Button
        //
        //Summary: Opens a File Dialog and serializes every sprite object to an XML File
        private void ExportToXMLButton_MouseClick(object sender, MouseEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML File (*.xml)|*.xml";
            sfd.InitialDirectory = @"Desktop";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Path.GetFileName(sfd.FileName);
            }
            if (sfd.FileName != String.Empty)
            {
                XmlSerializer mySerializer = new XmlSerializer(typeof(List<Sprite>));
                using (StreamWriter myWriter = new StreamWriter(sfd.FileName))
                {
                    mySerializer.Serialize(myWriter, savedSprites);
                }
            }
        }
    }

    //Sprite Class
    //
    //Summary: Stores the information for each sprite object
    [Serializable, XmlRoot("SpriteList")]
    public class Sprite
    {

        public string name;

        public RectangleF rect;

        public Sprite()
        {

        }

        public Sprite(RectangleF a_rect, string a_name)
        {
            rect = a_rect;
            name = a_name;
        }
        public Sprite(int a_x, int a_y, int a_w, int a_h, string a_name)
        {
            rect.X = a_x;
            rect.Y = a_y;
            rect.Width = a_w;
            rect.Height = a_h;
            name = a_name;
        }
    }
}
