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
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ProjetInfo_IHM1
{
    
    public partial class Form1 : Form
    {
        LLD_connection _lldConnexion = new LLD_connection();        // Importation des fonctions du low-level driver c++

        public Form1()
        {
            InitializeComponent();
            _lldConnexion.LLD_Init();
            button_ModeAuto_Start.Enabled = false;
            button_ModeManu_Next.Enabled = false;
            button_ModeManu_Previous.Enabled = false;
            button_ModeAuto.Enabled = false;
            button_ModeManu.Enabled = false;
            _indice = 0;
            _indiceActu = -1;
            _listSize = 0;
            classeOK = false;
            seuilOK = false;
            corrigOK = false;
            correctionOK = false;
            copieFolderOK = false;
            correctionStartOK = false;
            //Init de la listID
            listId_IPSI2.Add("Copie reference");
            listId_IPSI2.Add("Cyrpien BARDIAUX");
            listId_IPSI2.Add("Arthur BOTTAZZINI");
            listId_IPSI2.Add("Anael BOUSQUET");
            listId_IPSI2.Add("Ludovic CHAMPEROL");
            listId_IPSI2.Add("Thibaut CHATAING");
            listId_IPSI2.Add("Pierre CLAUDEL");
            listId_IPSI2.Add("Hugo CONSTANT");
            listId_IPSI2.Add("Nicolas CROUZET");
            listId_IPSI2.Add("Marc CWIKLINSKI");
            listId_IPSI2.Add("Helene EHRHARDT");
            listId_IPSI2.Add("Antoine GEORGES");
            listId_IPSI2.Add("Mickael GIPON");
            listId_IPSI2.Add("Vianney LAROCHE-JOUBERT");
            listId_IPSI2.Add("Romain LECLERC");
            listId_IPSI2.Add("Emma LIOGIER");
            listId_IPSI2.Add("Allan MAITRE");
            listId_IPSI2.Add("Alexis MARCEAU");
            listId_IPSI2.Add("Dylan MUIRAS");
            listId_IPSI2.Add("Valentin PARRA");
            listId_IPSI2.Add("Thomas PEROTTO");
            listId_IPSI2.Add("Thomas PINOIT");
            listId_IPSI2.Add("Pierre REVOL");
            listId_IPSI2.Add("Pascal SANCHEZ");
            listId_IPSI2.Add("Emma SERANZI");
            listId_IPSI2.Add("Justin THOMAS");
            listId_IPSI2.Add("Mathilde VIALAR");
            listId_IPSI2.Add("Valentin GRAUX");
            for (int i = 27; i < 255; i++)
                listId_IPSI2.Add("Eleve inconnu");
        }

        ClassStats _newStat = new ClassStats();
        List<string> _list = new List<string>();
        int _indice;
        int _indiceActu;
        int _listSize;
        Bitmap savedCorrige;
        bool corrigOK, correctionOK, classeOK, seuilOK, copieFolderOK, correctionStartOK;
        List<string> listId_IPSI2 = new List<string>();


        private void button_ModeAuto_Start_Click(object sender, EventArgs e)
        {
            if(button_ModeAuto_Start.Text == "Start")
            {
                timer_ModeAuto.Start();
                button_ModeAuto_Start.Text = "Stop";
            }
            else
            {
                timer_ModeAuto.Stop();
                button_ModeAuto_Start.Text = "Start";
            }
        }

        private void button_ModeManu_Previous_Click(object sender, EventArgs e)
        {
            // Empeche de charger un indice négatif (génere une erreur)
            if (_indice <= 0)
            {
                _indice = 0;
                pictureBox_copie.ImageLocation = _list[_indice];
            }
            else
            {
                _indice--;
                pictureBox_copie.ImageLocation = _list[_indice];
            }
        }

        private void button_ModeManu_Next_Click(object sender, EventArgs e)
        {
            // Empeche de charger un indice en dehors de la liste
            if (_indice >= _listSize-1)
            {
                _indice = _listSize-1;
                pictureBox_copie.ImageLocation = _list[_indice];
            }
            else
            {
                _indice++;
                pictureBox_copie.ImageLocation = _list[_indice];
                //correctionCopie();
            }
        }

        private void button_ModeManu_CheckedChanged(object sender, EventArgs e)
        {
            button_ModeAuto_Start.Enabled = false;
            button_ModeManu_Next.Enabled = true;
            button_ModeManu_Previous.Enabled = true;
            timer_ModeAuto.Stop();
            button_ModeAuto_Start.Text = "Start";
        }

        private void button_ModeAuto_CheckedChanged(object sender, EventArgs e)
        {
            button_ModeAuto_Start.Enabled = true;
            button_ModeManu_Next.Enabled = false;
            button_ModeManu_Previous.Enabled = false;
        }

        private void menu_Fichier_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Project Info - Correcteur de QCM \n  ********** Version 2.1 ********** \n Télécom Saint-Etienne \n\n LIOGIER Emma \n PEROTTO Thomas \n CONSTANT Hugo");
        }

        private void menu_Fichier_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_Corrige_ChargerIMG_Click(object sender, EventArgs e)
        {
            if (openFile_Corrige.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap bmp = new Bitmap(openFile_Corrige.FileName);
                    pictureBox_copie.Image = bmp;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERREUR : problème d'ouverture du fichier : " + ex.Message);
                }
            }
        }

        private void menu_Corrige_Sauver_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox_copie.Image);
            try
            {
                _lldConnexion.SetCalibrationSheet(bmp);
                MessageBox.Show("Corrigé enregistré");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            savedCorrige=bmp;
            corrigOK = true;
        }

        private void menu_Corrige_Afficher_Click(object sender, EventArgs e)
        {
            pictureBox_copie.Image = savedCorrige;
        }

        private void menu_Correcteur_NewCorrection_Click(object sender, EventArgs e)
        {
            _indiceActu = 0;
            _indice = -1;
            _newStat.reset();
            maj_labelStats(_newStat);
            classeOK = false;
            seuilOK = false;
            corrigOK = false;
            correctionOK = false;
            copieFolderOK = false;
            if (corrigOK)
            {
                savedCorrige = new Bitmap(savedCorrige.Height, savedCorrige.Width);
                corrigOK = false;
            }
            else
                corrigOK = false;

            classeOK = false;
            seuilOK = false;
            correctionOK = false;
            textBox_classe.Enabled = true;
            button_classe.Enabled = true;
            textBox_Seuil.Enabled = true;
            button_seuil.Enabled = true;
        }

        private void menu_Correcteur_ChargerLib_Click(object sender, EventArgs e)
        {
           if (corrigOK)
           {
                if (folderBrowser_LibImg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Création d'un tableau de string contenant tous les fichiers
                        string[] list1 = Directory.GetFiles(folderBrowser_LibImg.SelectedPath);
                        for (int i = 0; i < list1.Length; i++)
                        {
                            // Génération à partir de ce tableau d'une liste de string contenant le nom des fichiers
                            _list.Add(list1[i]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERREUR : problème d'ouverture du dossier : " + ex.Message);
                    }
                }
                _indice = -1;
                _listSize = _list.Count();
                copieFolderOK = true;
           }
           else
                MessageBox.Show("Veuillez enregistrer une correction avant de charger les copies.");
        }

        private void menu_Correcteur_startCorrec_Click(object sender, EventArgs e)
        {
            if(classeOK)
            {
                if(seuilOK)
                {
                    if(copieFolderOK)
                    {
                        button_ModeAuto.Enabled = true;
                        button_ModeManu.Enabled = true;

                        textBox_Seuil.Enabled = false;
                        button_seuil.Enabled = false;

                        textBox_classe.Enabled = false;
                        button_classe.Enabled = false;

                        correctionStartOK = true;

                        textBox_classe.Text = _newStat.getClasseName();
                        textBox_Seuil.Text = (_newStat.getSeuil()).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Veuillez séléctionner un répertoire contenant les copies à corrgier.");
                    }
                }
                else
                {
                    if (copieFolderOK)
                    {
                        MessageBox.Show("Veuillez sélectionner un seuil pour la correction. (le seuil sert à déterminer les échecs et succès des copies)");
                    }
                    else
                    {
                        MessageBox.Show("Veuillez séléctionner un répertoire contenant les copies à corrgier.\n" +
                            "Veuillez sélectionner un seuil pour la correction. (le seuil sert à déterminer les échecs et succès des copies)");
                    }
                }
            }
            else
            {
                if (seuilOK)
                {
                    if (copieFolderOK)
                    {
                        MessageBox.Show("Veuillez indiquer le nom de classe liée à la correction");
                    }
                    else
                    {
                        MessageBox.Show("Veuillez séléctionner un répertoire contenant les copies à corrgier.\n" + 
                            "Veuillez indiquer le nom de classe liée à la correction\n");
                    }
                }
                else
                {
                    if (copieFolderOK)
                    {
                        MessageBox.Show("Veuillez indiquer le nom de classe liée à la correction\n" +
                            "Veuillez sélectionner un seuil pour la correction. (le seuil sert à déterminer les échecs et succès des copies)");
                    }
                    else
                    {
                        MessageBox.Show("Veuillez séléctionner un répertoire contenant les copies à corrgier.\n" +
                            "Veuillez indiquer le nom de classe liée à la correction\n" +
                            "Veuillez sélectionner un seuil pour la correction. (le seuil sert à déterminer les échecs et succès des copies)");
                    }
                }
            }
        }

        private void menu_Correcteur_SaveResult_Click(object sender, EventArgs e)
        {
            if (correctionOK)
            {
                List<float> listNotes = _newStat.getListNotes();
                List<string> listNames = _newStat.getListName();

                StringBuilder csv = new StringBuilder();

                var newLine = string.Format("{0};{1}", "Classe :", _newStat.getClasseName());
                csv.AppendLine(newLine);

                newLine = string.Format("{0}", "", _newStat.getClasseName());
                csv.AppendLine(newLine);

                newLine = string.Format("{0}", "STATISTIQUES");
                csv.AppendLine(newLine);
                newLine = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8}", "Nbr de copies", "Seuil de reussite","Succes", "Echecs", "Moyenne", "Ecart-Type", "Mediane", "Min", "Max");
                csv.AppendLine(newLine);
                newLine = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8}", _newStat.getNbrCopies(), _newStat.getSeuil(), _newStat.getSucces(), _newStat.getEchecs(),  _newStat.getMoy(), _newStat.getEcartType(), _newStat.getMediane(), _newStat.getMin(), _newStat.getMax());
                csv.AppendLine(newLine);

                newLine = string.Format("{0}", "", _newStat.getClasseName());
                csv.AppendLine(newLine);

                newLine = string.Format("{0}", "RESULTATS");
                csv.AppendLine(newLine);
                newLine = string.Format("{0};{1}", "Etudiant" ,"Note");
                csv.AppendLine(newLine);
                for (int i = 0; i < listNotes.Count(); i++)
                {
                    newLine = string.Format("{0};{1}", listNames[i], listNotes[i]);
                    csv.AppendLine(newLine);
                }

                File.WriteAllText("Result.csv", csv.ToString()); //Enregistre au même endroit que le fichier exe

            }
            else
                MessageBox.Show("Veuillez attendre la fin de la correction avant de pouvoir enregistrer les résustats.");

        }

        private void trackBar_vitesse_Scroll(object sender, EventArgs e)
        {
            label_vitesse.Text =  " 1 image / " + ((trackBar_vitesse.Value) ).ToString() + "ms";
            timer_ModeAuto.Interval = trackBar_vitesse.Value;
        }

        private void button_majStats_Click(object sender, EventArgs e)
        {
            _newStat.majStats();
            maj_labelStats(_newStat);
        }

        private void button_seuil_Click(object sender, EventArgs e)
        {
            int result;
            if (textBox_Seuil.Text != "" && int.TryParse(textBox_Seuil.Text, out result))
            {
                _newStat.setSeuil(float.Parse(textBox_Seuil.Text));
                seuilOK = true;
            }
            else
            {
                MessageBox.Show("La valeur de seuil indiquée n'est pas un nombre.");
            }
        }

        private void button_classe_Click(object sender, EventArgs e)
        {
            if (textBox_classe.Text != "")
            {
                _newStat.setClasse(textBox_classe.Text);
                classeOK = true;
            }
            else
            {
                MessageBox.Show("Le nom de la classe ne peut pas être vide.");
            }

        }

        private void timer_ModeAuto_Tick(object sender, EventArgs e)
        {
            if (_indice >= _listSize)
            {
                _indice = _listSize - 1;
                pictureBox_copie.ImageLocation = _list[_indice];
            }
            else
            {
                _indice++;
                pictureBox_copie.ImageLocation = _list[_indice];
               // correctionCopie();
            }
        }

        private void button_TEST_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox_copie.Image);
            RectangleF cloneRect = new RectangleF(0, 0, 100, 100);
            System.Drawing.Imaging.PixelFormat format =
                bmp.PixelFormat;
            Bitmap cloneBitmap = bmp.Clone(cloneRect, format);
            pictureBox_copie.Image = cloneBitmap;
        }

        private void pictureBox_copie_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if(correctionStartOK)
            {
                correctionCopie();
            }
        }

        // Misc
        private void maj_labelStats(ClassStats stats)
        {
            label_moy.Text = (Math.Round(stats.getMoy(), 2)).ToString();
            label_med.Text = (stats.getMediane()).ToString();
            label_ecartType.Text = (Math.Round(stats.getEcartType(),2)).ToString();
            label_min.Text = (stats.getMin()).ToString();
            label_max.Text = (stats.getMax()).ToString();
            label_succes.Text = (stats.getSucces()).ToString();
            label_echec.Text = (stats.getEchecs()).ToString();
            label_nbrQCM.Text = (stats.getNbrCopies()).ToString();
        }

        private float stringTofloat_Note(string str_note)
        {
            float note = 0;
            for(int i=0; i<str_note.Length;i++)
            {
                if (str_note[i] == 1)
                {
                    note++;
                }
            }
            return note;
        }

        private void autoUpdateStats(float newNote, string newName)
        {
            if (checkBox_majStats.Checked)
            {
                label_note.Text = newNote.ToString();
                label_nom.Text = newName;
                _newStat.majList(newNote, newName);
                _newStat.majStats();

                maj_labelStats(_newStat);
            }
            else
            {
                _newStat.majList(newNote, newName);
                label_note.Text = newNote.ToString();
                label_nom.Text = newName;
                label_nbrQCM.Text = (int.Parse(label_nbrQCM.Text) + 1).ToString();

                if (newNote>=float.Parse(textBox_Seuil.Text))
                    label_succes.Text = (int.Parse(label_succes.Text) + 1).ToString();
                else
                    label_echec.Text = (int.Parse(label_echec.Text) + 1).ToString();
            }
        }

        private void correctionCopie()
        {
            if(_indice > _indiceActu)
            {
                string newNote_string = "en attente";
                string newName_string = "en attente";
                int newName_int = 0;
                float newNote = 0;
                Bitmap bmp = new Bitmap(pictureBox_copie.Image);

                try
                {
                    newName_int = _lldConnexion.GetCandidatNumber(bmp);
                    newName_string = listId_IPSI2.ElementAt(newName_int);

                    newNote_string = _lldConnexion.AnalyseSheet(bmp);
                    foreach (char i in newNote_string)
                    {
                        if(i=='1')
                            newNote ++; 
                    }
                    _indiceActu++;
                    autoUpdateStats(newNote, newName_string);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if(_indiceActu == _listSize -1)
            {
                if(button_ModeAuto.Enabled)
                {
                    button_ModeAuto_Start.PerformClick();
                }
                correctionOK = true;

                if(_indiceActu == _listSize - 1)
                {
                MessageBox.Show("Correction terminée");
                }

                _indiceActu = _listSize + 1;
            }

        }

    }
}
