using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDB_Project
{
    public partial class childOyuncuEkle : Form
    {
        public childOyuncuEkle()
        {
            InitializeComponent();
        }
        
        private void ekleButton_Click(object sender, EventArgs e)
        {
            char gender;
            if (femaleRadioButton.Checked)
                gender = 'F';
            else
                gender = 'M';

            
            Human newHuman = new Human();
            newHuman.setValues(humanNoTextBox.Text,
                            humanNameTextBox.Text,
                                humanLNameTextBox.Text,
                                   DateTime.Parse(humanBODTextBox.Text),
                                        humanCityTextBox.Text,
                                            humanCountryTextBox.Text,
                                                humanBiographyTextBox.Text,
                                                    humanHeightTextBox.Text,
                                                        humanPhotoTextBox.Text,
                                                            gender,
                                                                actorCheckBox.Checked,
                                                                    authorCheckBox.Checked,
                                                                        directorCheckBox.Checked

                                                            );

            MessageBox.Show(newHuman.insertHumanDb());

              
        }

        private void childOyuncuEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
