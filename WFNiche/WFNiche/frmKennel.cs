/* 
* Project : WFNiche
* Author : Fabian Huber
* Description : Kennel with multiple dogs
* Version : 1.0
* Date : 08.11.2018
 */
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

namespace WFNiche
{
    public partial class FrmKennel : Form
    {
        //Constants
        private const string SEARCH_PATTERN = "dog?.xml";
        private const string ERROR_MESSAGE_SERIALIZATION = "Error with the serialization ";
        private const string KENNEL_FULL_TEXT = "Ceplein";
        private const string KENNEL_FILE = "kennel.xml";
        private const string DOG_FILE_NAME = "dog";
        private const string DOG_FILE_EXTENTION = ".xml";
        private const string OCCUPIED_TEXT = "Occupee: ";

        //Properties
        Kennel k;
        List<Dog> lstDogs;
        Save<Dog> dogSave;
        Save<Kennel> kennelSave;

        //Fields
        public Kennel K { get => k; set => k = value; }
        public List<Dog> LstDogs { get => lstDogs; set => lstDogs = value; }
        internal Save<Dog> DogSave { get => dogSave; set => dogSave = value; }
        internal Save<Kennel> KennelSave { get => kennelSave; set => kennelSave = value; }

        //Constructor
        public FrmKennel()
        {
            InitializeComponent();

            LstDogs = new List<Dog>();
            DogSave = new Save<Dog>();
            KennelSave = new Save<Kennel>();

            DogLoader();

            KennelLoader();
        }

        private void FrmKennel_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void UpdateView()
        {
            lblKennelOcccupied.Text = OCCUPIED_TEXT + K.IsOccupied().ToString();
            lblDogName.Text = K.NameOfDogInKennel();
            if (K.IsOccupied())
            {
                btnEmptyKennel.Enabled = true;
                btnEnterDog1.Enabled = false;
                btnEnterDog2.Enabled = false;
                btnEnterDog3.Enabled = false;
            }
            else
            {
                btnEmptyKennel.Enabled = false;
                btnEnterDog1.Enabled = true;
                btnEnterDog2.Enabled = true;
                btnEnterDog3.Enabled = true;
            }
        }

        private void BtnEmptyKennel_Click(object sender, EventArgs e)
        {
            K.Out();
            UpdateView();
        }

        private void BtnEnterDog_Click(object sender, EventArgs e)
        {
            if (K.IsOccupied())
            {
                MessageBox.Show(KENNEL_FULL_TEXT);
            }
            else
            {
                K.In(LstDogs[Convert.ToInt32((sender as Button).Tag)]);
                UpdateView();
            }
        }

        private void FrmKennel_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < LstDogs.Count; i++)
            {
                DogSave.Serialize(LstDogs[i], DOG_FILE_NAME + i + DOG_FILE_EXTENTION);
            }

            KennelSave.Serialize(K, KENNEL_FILE);
        }

        private void DogLoader()
        {
            string startPath = AppDomain.CurrentDomain.BaseDirectory;
            string[] oDirectories = Directory.GetFiles(startPath, SEARCH_PATTERN, SearchOption.TopDirectoryOnly);
            foreach (string oCurrent in oDirectories)
            {
                if (File.Exists(oCurrent))
                {
                    try
                    {
                        LstDogs.Add(DogSave.Deserialize(oCurrent));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(ERROR_MESSAGE_SERIALIZATION + e.ToString());
                        throw;
                    }
                }
            }
        }

        private void KennelLoader()
        {
            if (File.Exists(KENNEL_FILE))
            {
                try
                {
                    K = KennelSave.Deserialize(KENNEL_FILE);
                }
                catch (Exception e)
                {
                    Console.WriteLine(ERROR_MESSAGE_SERIALIZATION + e.ToString());
                    throw;
                }
            }
            else
            {
                K = new Kennel();
            }
        }
    }
}
