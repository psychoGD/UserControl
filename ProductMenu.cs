using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC
{
    public partial class ProductMenu : UserControl
    {
        public string Name
        {
            get => productName.Text;
            set
            {
                productName.Text = value;
            }
        }

        public double Price
        {
            get => double.Parse(productPrice.Text);
            set
            {
                productPrice.Text = value.ToString();
            }
        }

        public Image ProductImage
        {
            get
            {
                return guna2PictureBox1.Image;
            }
            set
            {
                guna2PictureBox1.Image = value;
            }
        }
        public ProductMenu()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            //productContainer.Controls.Clear();
            
            this.Dispose();
        }

        private void productName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var txtbox = sender as TextBox;
            txtbox.Enabled = true;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            productName.Enabled = true;
            productPrice.Enabled = true;
        }
    }
}
