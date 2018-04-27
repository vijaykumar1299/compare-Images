using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging;

namespace compare_Images
{
    public partial class compareImages : Form
    {

        const double THRESHOLD = 0.9;
        private string largeFileName = "";
        private string smallFileName = "";

        public compareImages()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;

            largePicBox.Visible = false;
            smallPicBox.Visible = false;
            btnCompare.Enabled = false;
            outputMessage.Text = "";

        }

        private void largeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fileDialog.FileName = "";
            fileDialog.Title = "Select main Image";
            fileDialog.Filter = "All images|*.jpg; *.bmp; *.png";
            fileDialog.ShowDialog();
            if (fileDialog.FileName.ToString() != "")
            {
                largeFileName = fileDialog.FileName.ToString();
                largeLabel.Text = largeFileName;
                largePicBox.Image = System.Drawing.Image.FromFile(largeFileName);
                largePicBox.Visible = true;

            }
            validateSelections();
        }

        private void smallLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fileDialog.FileName = "";
            fileDialog.Title = "Select sub Image";
            fileDialog.Filter = "All images|*.jpg; *.bmp; *.png";
            fileDialog.ShowDialog();
            if (fileDialog.FileName.ToString() != "")
            {
                smallFileName = fileDialog.FileName.ToString();
                smallLabel.Text = smallFileName;
                smallPicBox.Image = System.Drawing.Image.FromFile(smallFileName);
                smallPicBox.Visible = true;


            }

            validateSelections();
        }

        private void validateSelections()
        {
            if(largeFileName.Length >0 && smallFileName.Length > 0)
            {

                btnCompare.Enabled = true;
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            

            Bitmap largeImage = new Bitmap(largeFileName);
            Bitmap smallImage = new Bitmap(smallFileName);
           
            string msg = "";
            List<string> rowSub = getRows(smallImage);
            List<string> rowMain = getRows(largeImage);
           
            if (isSubset(rowSub,rowMain))
            {

                msg = "small Image is part of the large Image";
            }
            else {
                msg = "small Image is not part of Large Image";
            }
        
            
           

            outputMessage.Text = msg;

        }

        private bool isSubset(List<string> rowsSub, List<string> rowsMain)
        {
            bool match = false;
            int matches = 0;
            int misses = 0;

            foreach (var rSub in rowsSub)
            {

                foreach (var rMain in rowsMain)
                {
                    if (rMain.Contains(rSub))
                    {

                        match = true;
                        break;
                    }
                    
                }
                if (match) matches++;
                else misses++;
                
            }

            double percnt = (double)(matches / (matches + misses));

            return (percnt >= THRESHOLD);

        }



        private List<string> getRows(Bitmap bitmap)
        {
            StringBuilder sb = new StringBuilder();

            int imageHeight = bitmap.Height;
            int imageWidth = bitmap.Width;
            List<string> rows = new List<string>();
            for( int x = 0; x < bitmap.Height; x++)
            {
                sb.Clear();
                for(int y = 0; y < bitmap.Width; y++)
                {
                    int hash = bitmap.GetPixel(y, x).GetHashCode();
                    sb.Append(hash.ToString());

                }
                rows.Add(sb.ToString());
                progressBar1.Value++;
            }
            return rows;

        }

    }

}
