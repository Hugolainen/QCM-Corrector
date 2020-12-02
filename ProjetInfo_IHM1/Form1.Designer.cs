namespace ProjetInfo_IHM1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox_copie = new System.Windows.Forms.PictureBox();
            this.menuStrip_IHM = new System.Windows.Forms.MenuStrip();
            this.menu_Fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Fichier_About = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Fichier_Fermer = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Corrige = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Corrige_ChargerIMG = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Corrige_Sauver = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Corrige_Afficher = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Correcteur = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Correcteur_NewCorrection = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Correcteur_ChargerLib = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Correcteur_startCorrec = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Correcteur_SaveResult = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Bareme = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowser_Result = new System.Windows.Forms.FolderBrowserDialog();
            this.openFile_Corrige = new System.Windows.Forms.OpenFileDialog();
            this.timer_ModeAuto = new System.Windows.Forms.Timer(this.components);
            this.folderBrowser_LibImg = new System.Windows.Forms.FolderBrowserDialog();
            this.label_IHM1 = new System.Windows.Forms.Label();
            this.label_IHM2 = new System.Windows.Forms.Label();
            this.label_IHM5 = new System.Windows.Forms.Label();
            this.label_IHM6 = new System.Windows.Forms.Label();
            this.label_IHM7 = new System.Windows.Forms.Label();
            this.label_IHM8 = new System.Windows.Forms.Label();
            this.label_IHM9 = new System.Windows.Forms.Label();
            this.label_IHM10 = new System.Windows.Forms.Label();
            this.label_IHM11 = new System.Windows.Forms.Label();
            this.label_IHM12 = new System.Windows.Forms.Label();
            this.label_IHM4 = new System.Windows.Forms.Label();
            this.textBox_Seuil = new System.Windows.Forms.TextBox();
            this.label_IHM3 = new System.Windows.Forms.Label();
            this.label_IHM15 = new System.Windows.Forms.Label();
            this.button_ModeAuto_Start = new System.Windows.Forms.Button();
            this.button_ModeManu = new System.Windows.Forms.RadioButton();
            this.button_ModeAuto = new System.Windows.Forms.RadioButton();
            this.button_ModeManu_Previous = new System.Windows.Forms.Button();
            this.button_ModeManu_Next = new System.Windows.Forms.Button();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_note = new System.Windows.Forms.Label();
            this.label_min = new System.Windows.Forms.Label();
            this.label_med = new System.Windows.Forms.Label();
            this.label_max = new System.Windows.Forms.Label();
            this.label_moy = new System.Windows.Forms.Label();
            this.label_ecartType = new System.Windows.Forms.Label();
            this.label_echec = new System.Windows.Forms.Label();
            this.label_succes = new System.Windows.Forms.Label();
            this.label_nbrQCM = new System.Windows.Forms.Label();
            this.label_IHM0 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar_vitesse = new System.Windows.Forms.TrackBar();
            this.label_vitesse = new System.Windows.Forms.Label();
            this.button_majStats = new System.Windows.Forms.Button();
            this.checkBox_majStats = new System.Windows.Forms.CheckBox();
            this.button_seuil = new System.Windows.Forms.Button();
            this.textBox_classe = new System.Windows.Forms.TextBox();
            this.button_classe = new System.Windows.Forms.Button();
            this.button_TEST = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_copie)).BeginInit();
            this.menuStrip_IHM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_vitesse)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_copie
            // 
            this.pictureBox_copie.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox_copie.Location = new System.Drawing.Point(25, 26);
            this.pictureBox_copie.Name = "pictureBox_copie";
            this.pictureBox_copie.Size = new System.Drawing.Size(437, 466);
            this.pictureBox_copie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_copie.TabIndex = 0;
            this.pictureBox_copie.TabStop = false;
            this.pictureBox_copie.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox_copie_LoadCompleted);
            // 
            // menuStrip_IHM
            // 
            this.menuStrip_IHM.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_IHM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Fichier,
            this.menu_Corrige,
            this.menu_Correcteur,
            this.menu_Bareme});
            this.menuStrip_IHM.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_IHM.Name = "menuStrip_IHM";
            this.menuStrip_IHM.Size = new System.Drawing.Size(1156, 24);
            this.menuStrip_IHM.TabIndex = 1;
            this.menuStrip_IHM.Text = "menuStrip1";
            // 
            // menu_Fichier
            // 
            this.menu_Fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Fichier_About,
            this.menu_Fichier_Fermer});
            this.menu_Fichier.Name = "menu_Fichier";
            this.menu_Fichier.Size = new System.Drawing.Size(54, 20);
            this.menu_Fichier.Text = "Fichier";
            // 
            // menu_Fichier_About
            // 
            this.menu_Fichier_About.Name = "menu_Fichier_About";
            this.menu_Fichier_About.Size = new System.Drawing.Size(137, 22);
            this.menu_Fichier_About.Text = "Information";
            this.menu_Fichier_About.Click += new System.EventHandler(this.menu_Fichier_About_Click);
            // 
            // menu_Fichier_Fermer
            // 
            this.menu_Fichier_Fermer.Name = "menu_Fichier_Fermer";
            this.menu_Fichier_Fermer.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.menu_Fichier_Fermer.Size = new System.Drawing.Size(137, 22);
            this.menu_Fichier_Fermer.Text = "Fermer";
            this.menu_Fichier_Fermer.Click += new System.EventHandler(this.menu_Fichier_Fermer_Click);
            // 
            // menu_Corrige
            // 
            this.menu_Corrige.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Corrige_ChargerIMG,
            this.menu_Corrige_Sauver,
            this.menu_Corrige_Afficher});
            this.menu_Corrige.Name = "menu_Corrige";
            this.menu_Corrige.Size = new System.Drawing.Size(119, 20);
            this.menu_Corrige.Text = "Feuille de réponses";
            // 
            // menu_Corrige_ChargerIMG
            // 
            this.menu_Corrige_ChargerIMG.Name = "menu_Corrige_ChargerIMG";
            this.menu_Corrige_ChargerIMG.Size = new System.Drawing.Size(182, 22);
            this.menu_Corrige_ChargerIMG.Text = "Charger image";
            this.menu_Corrige_ChargerIMG.Click += new System.EventHandler(this.menu_Corrige_ChargerIMG_Click);
            // 
            // menu_Corrige_Sauver
            // 
            this.menu_Corrige_Sauver.Name = "menu_Corrige_Sauver";
            this.menu_Corrige_Sauver.Size = new System.Drawing.Size(182, 22);
            this.menu_Corrige_Sauver.Text = "Enregistrer référence";
            this.menu_Corrige_Sauver.Click += new System.EventHandler(this.menu_Corrige_Sauver_Click);
            // 
            // menu_Corrige_Afficher
            // 
            this.menu_Corrige_Afficher.Name = "menu_Corrige_Afficher";
            this.menu_Corrige_Afficher.Size = new System.Drawing.Size(182, 22);
            this.menu_Corrige_Afficher.Text = "Afficher corrigé";
            this.menu_Corrige_Afficher.Click += new System.EventHandler(this.menu_Corrige_Afficher_Click);
            // 
            // menu_Correcteur
            // 
            this.menu_Correcteur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Correcteur_NewCorrection,
            this.menu_Correcteur_ChargerLib,
            this.menu_Correcteur_startCorrec,
            this.menu_Correcteur_SaveResult});
            this.menu_Correcteur.Name = "menu_Correcteur";
            this.menu_Correcteur.Size = new System.Drawing.Size(75, 20);
            this.menu_Correcteur.Text = "Correcteur";
            // 
            // menu_Correcteur_NewCorrection
            // 
            this.menu_Correcteur_NewCorrection.Name = "menu_Correcteur_NewCorrection";
            this.menu_Correcteur_NewCorrection.Size = new System.Drawing.Size(209, 22);
            this.menu_Correcteur_NewCorrection.Text = "Nouvelle correction";
            this.menu_Correcteur_NewCorrection.Click += new System.EventHandler(this.menu_Correcteur_NewCorrection_Click);
            // 
            // menu_Correcteur_ChargerLib
            // 
            this.menu_Correcteur_ChargerLib.Name = "menu_Correcteur_ChargerLib";
            this.menu_Correcteur_ChargerLib.Size = new System.Drawing.Size(209, 22);
            this.menu_Correcteur_ChargerLib.Text = "Charger dossier de copies";
            this.menu_Correcteur_ChargerLib.Click += new System.EventHandler(this.menu_Correcteur_ChargerLib_Click);
            // 
            // menu_Correcteur_startCorrec
            // 
            this.menu_Correcteur_startCorrec.Name = "menu_Correcteur_startCorrec";
            this.menu_Correcteur_startCorrec.Size = new System.Drawing.Size(209, 22);
            this.menu_Correcteur_startCorrec.Text = "Commencer correction";
            this.menu_Correcteur_startCorrec.Click += new System.EventHandler(this.menu_Correcteur_startCorrec_Click);
            // 
            // menu_Correcteur_SaveResult
            // 
            this.menu_Correcteur_SaveResult.Name = "menu_Correcteur_SaveResult";
            this.menu_Correcteur_SaveResult.Size = new System.Drawing.Size(209, 22);
            this.menu_Correcteur_SaveResult.Text = "Enregistrer résulat";
            this.menu_Correcteur_SaveResult.Click += new System.EventHandler(this.menu_Correcteur_SaveResult_Click);
            // 
            // menu_Bareme
            // 
            this.menu_Bareme.Name = "menu_Bareme";
            this.menu_Bareme.Size = new System.Drawing.Size(59, 20);
            this.menu_Bareme.Text = "Barême";
            // 
            // openFile_Corrige
            // 
            this.openFile_Corrige.FileName = "openFileDialog1";
            // 
            // timer_ModeAuto
            // 
            this.timer_ModeAuto.Tick += new System.EventHandler(this.timer_ModeAuto_Tick);
            // 
            // label_IHM1
            // 
            this.label_IHM1.AutoSize = true;
            this.label_IHM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IHM1.Location = new System.Drawing.Point(523, 115);
            this.label_IHM1.Name = "label_IHM1";
            this.label_IHM1.Size = new System.Drawing.Size(114, 13);
            this.label_IHM1.TabIndex = 2;
            this.label_IHM1.Text = "Nom de l\'étudiant :";
            // 
            // label_IHM2
            // 
            this.label_IHM2.AutoSize = true;
            this.label_IHM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IHM2.Location = new System.Drawing.Point(523, 144);
            this.label_IHM2.Name = "label_IHM2";
            this.label_IHM2.Size = new System.Drawing.Size(42, 13);
            this.label_IHM2.TabIndex = 3;
            this.label_IHM2.Text = "Note :";
            // 
            // label_IHM5
            // 
            this.label_IHM5.AutoSize = true;
            this.label_IHM5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IHM5.Location = new System.Drawing.Point(523, 225);
            this.label_IHM5.Name = "label_IHM5";
            this.label_IHM5.Size = new System.Drawing.Size(39, 13);
            this.label_IHM5.TabIndex = 5;
            this.label_IHM5.Text = "Min : ";
            // 
            // label_IHM6
            // 
            this.label_IHM6.AutoSize = true;
            this.label_IHM6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IHM6.Location = new System.Drawing.Point(523, 251);
            this.label_IHM6.Name = "label_IHM6";
            this.label_IHM6.Size = new System.Drawing.Size(63, 13);
            this.label_IHM6.TabIndex = 6;
            this.label_IHM6.Text = "Mediane :";
            // 
            // label_IHM7
            // 
            this.label_IHM7.AutoSize = true;
            this.label_IHM7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IHM7.Location = new System.Drawing.Point(523, 278);
            this.label_IHM7.Name = "label_IHM7";
            this.label_IHM7.Size = new System.Drawing.Size(38, 13);
            this.label_IHM7.TabIndex = 7;
            this.label_IHM7.Text = "Max :";
            // 
            // label_IHM8
            // 
            this.label_IHM8.AutoSize = true;
            this.label_IHM8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IHM8.Location = new System.Drawing.Point(789, 225);
            this.label_IHM8.Name = "label_IHM8";
            this.label_IHM8.Size = new System.Drawing.Size(66, 13);
            this.label_IHM8.TabIndex = 8;
            this.label_IHM8.Text = "Moyenne :";
            // 
            // label_IHM9
            // 
            this.label_IHM9.AutoSize = true;
            this.label_IHM9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IHM9.Location = new System.Drawing.Point(789, 251);
            this.label_IHM9.Name = "label_IHM9";
            this.label_IHM9.Size = new System.Drawing.Size(77, 13);
            this.label_IHM9.TabIndex = 9;
            this.label_IHM9.Text = "Ecart-Type :";
            // 
            // label_IHM10
            // 
            this.label_IHM10.AutoSize = true;
            this.label_IHM10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IHM10.Location = new System.Drawing.Point(523, 323);
            this.label_IHM10.Name = "label_IHM10";
            this.label_IHM10.Size = new System.Drawing.Size(69, 13);
            this.label_IHM10.TabIndex = 10;
            this.label_IHM10.Text = "Échec(s) : ";
            // 
            // label_IHM11
            // 
            this.label_IHM11.AutoSize = true;
            this.label_IHM11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IHM11.Location = new System.Drawing.Point(765, 323);
            this.label_IHM11.Name = "label_IHM11";
            this.label_IHM11.Size = new System.Drawing.Size(57, 13);
            this.label_IHM11.TabIndex = 11;
            this.label_IHM11.Text = "Succès :";
            // 
            // label_IHM12
            // 
            this.label_IHM12.AutoSize = true;
            this.label_IHM12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IHM12.Location = new System.Drawing.Point(934, 323);
            this.label_IHM12.Name = "label_IHM12";
            this.label_IHM12.Size = new System.Drawing.Size(156, 13);
            this.label_IHM12.TabIndex = 12;
            this.label_IHM12.Text = "Nombre de QCM corrigés :";
            // 
            // label_IHM4
            // 
            this.label_IHM4.AutoSize = true;
            this.label_IHM4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IHM4.Location = new System.Drawing.Point(522, 189);
            this.label_IHM4.Name = "label_IHM4";
            this.label_IHM4.Size = new System.Drawing.Size(115, 24);
            this.label_IHM4.TabIndex = 13;
            this.label_IHM4.Text = "Statistiques";
            // 
            // textBox_Seuil
            // 
            this.textBox_Seuil.Location = new System.Drawing.Point(813, 144);
            this.textBox_Seuil.Name = "textBox_Seuil";
            this.textBox_Seuil.Size = new System.Drawing.Size(100, 20);
            this.textBox_Seuil.TabIndex = 16;
            // 
            // label_IHM3
            // 
            this.label_IHM3.AutoSize = true;
            this.label_IHM3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IHM3.Location = new System.Drawing.Point(771, 147);
            this.label_IHM3.Name = "label_IHM3";
            this.label_IHM3.Size = new System.Drawing.Size(43, 13);
            this.label_IHM3.TabIndex = 17;
            this.label_IHM3.Text = "Seuil :";
            // 
            // label_IHM15
            // 
            this.label_IHM15.AutoSize = true;
            this.label_IHM15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IHM15.Location = new System.Drawing.Point(649, 469);
            this.label_IHM15.Name = "label_IHM15";
            this.label_IHM15.Size = new System.Drawing.Size(56, 13);
            this.label_IHM15.TabIndex = 19;
            this.label_IHM15.Text = "Vitesse :";
            this.label_IHM15.UseWaitCursor = true;
            // 
            // button_ModeAuto_Start
            // 
            this.button_ModeAuto_Start.Location = new System.Drawing.Point(568, 469);
            this.button_ModeAuto_Start.Name = "button_ModeAuto_Start";
            this.button_ModeAuto_Start.Size = new System.Drawing.Size(75, 23);
            this.button_ModeAuto_Start.TabIndex = 20;
            this.button_ModeAuto_Start.Text = "Start";
            this.button_ModeAuto_Start.UseVisualStyleBackColor = true;
            this.button_ModeAuto_Start.Click += new System.EventHandler(this.button_ModeAuto_Start_Click);
            // 
            // button_ModeManu
            // 
            this.button_ModeManu.AutoSize = true;
            this.button_ModeManu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ModeManu.Location = new System.Drawing.Point(517, 361);
            this.button_ModeManu.Name = "button_ModeManu";
            this.button_ModeManu.Size = new System.Drawing.Size(156, 28);
            this.button_ModeManu.TabIndex = 21;
            this.button_ModeManu.TabStop = true;
            this.button_ModeManu.Text = "Mode manuel";
            this.button_ModeManu.UseVisualStyleBackColor = true;
            this.button_ModeManu.CheckedChanged += new System.EventHandler(this.button_ModeManu_CheckedChanged);
            // 
            // button_ModeAuto
            // 
            this.button_ModeAuto.AutoSize = true;
            this.button_ModeAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ModeAuto.Location = new System.Drawing.Point(517, 421);
            this.button_ModeAuto.Name = "button_ModeAuto";
            this.button_ModeAuto.Size = new System.Drawing.Size(201, 28);
            this.button_ModeAuto.TabIndex = 22;
            this.button_ModeAuto.TabStop = true;
            this.button_ModeAuto.Text = "Mode automatique";
            this.button_ModeAuto.UseVisualStyleBackColor = true;
            this.button_ModeAuto.CheckedChanged += new System.EventHandler(this.button_ModeAuto_CheckedChanged);
            // 
            // button_ModeManu_Previous
            // 
            this.button_ModeManu_Previous.Location = new System.Drawing.Point(598, 395);
            this.button_ModeManu_Previous.Name = "button_ModeManu_Previous";
            this.button_ModeManu_Previous.Size = new System.Drawing.Size(75, 23);
            this.button_ModeManu_Previous.TabIndex = 23;
            this.button_ModeManu_Previous.Text = "<<";
            this.button_ModeManu_Previous.UseVisualStyleBackColor = true;
            this.button_ModeManu_Previous.Click += new System.EventHandler(this.button_ModeManu_Previous_Click);
            // 
            // button_ModeManu_Next
            // 
            this.button_ModeManu_Next.Location = new System.Drawing.Point(679, 395);
            this.button_ModeManu_Next.Name = "button_ModeManu_Next";
            this.button_ModeManu_Next.Size = new System.Drawing.Size(75, 23);
            this.button_ModeManu_Next.TabIndex = 24;
            this.button_ModeManu_Next.Text = ">>";
            this.button_ModeManu_Next.UseVisualStyleBackColor = true;
            this.button_ModeManu_Next.Click += new System.EventHandler(this.button_ModeManu_Next_Click);
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(643, 115);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(95, 13);
            this.label_nom.TabIndex = 25;
            this.label_nom.Text = "Hugo CONSTANT";
            // 
            // label_note
            // 
            this.label_note.AutoSize = true;
            this.label_note.Location = new System.Drawing.Point(565, 144);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(19, 13);
            this.label_note.TabIndex = 26;
            this.label_note.Text = "10";
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(565, 225);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(13, 13);
            this.label_min.TabIndex = 27;
            this.label_min.Text = "0";
            // 
            // label_med
            // 
            this.label_med.AutoSize = true;
            this.label_med.Location = new System.Drawing.Point(592, 251);
            this.label_med.Name = "label_med";
            this.label_med.Size = new System.Drawing.Size(13, 13);
            this.label_med.TabIndex = 28;
            this.label_med.Text = "0";
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Location = new System.Drawing.Point(565, 278);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(13, 13);
            this.label_max.TabIndex = 29;
            this.label_max.Text = "0";
            // 
            // label_moy
            // 
            this.label_moy.AutoSize = true;
            this.label_moy.Location = new System.Drawing.Point(861, 225);
            this.label_moy.Name = "label_moy";
            this.label_moy.Size = new System.Drawing.Size(13, 13);
            this.label_moy.TabIndex = 30;
            this.label_moy.Text = "0";
            // 
            // label_ecartType
            // 
            this.label_ecartType.AutoSize = true;
            this.label_ecartType.Location = new System.Drawing.Point(872, 251);
            this.label_ecartType.Name = "label_ecartType";
            this.label_ecartType.Size = new System.Drawing.Size(13, 13);
            this.label_ecartType.TabIndex = 31;
            this.label_ecartType.Text = "0";
            // 
            // label_echec
            // 
            this.label_echec.AutoSize = true;
            this.label_echec.Location = new System.Drawing.Point(589, 323);
            this.label_echec.Name = "label_echec";
            this.label_echec.Size = new System.Drawing.Size(13, 13);
            this.label_echec.TabIndex = 32;
            this.label_echec.Text = "0";
            // 
            // label_succes
            // 
            this.label_succes.AutoSize = true;
            this.label_succes.Location = new System.Drawing.Point(828, 323);
            this.label_succes.Name = "label_succes";
            this.label_succes.Size = new System.Drawing.Size(13, 13);
            this.label_succes.TabIndex = 33;
            this.label_succes.Text = "0";
            // 
            // label_nbrQCM
            // 
            this.label_nbrQCM.AutoSize = true;
            this.label_nbrQCM.Location = new System.Drawing.Point(1096, 323);
            this.label_nbrQCM.Name = "label_nbrQCM";
            this.label_nbrQCM.Size = new System.Drawing.Size(13, 13);
            this.label_nbrQCM.TabIndex = 34;
            this.label_nbrQCM.Text = "0";
            // 
            // label_IHM0
            // 
            this.label_IHM0.AutoSize = true;
            this.label_IHM0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IHM0.Location = new System.Drawing.Point(523, 82);
            this.label_IHM0.Name = "label_IHM0";
            this.label_IHM0.Size = new System.Drawing.Size(52, 13);
            this.label_IHM0.TabIndex = 35;
            this.label_IHM0.Text = "Classe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(522, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Résultat";
            // 
            // trackBar_vitesse
            // 
            this.trackBar_vitesse.LargeChange = 100;
            this.trackBar_vitesse.Location = new System.Drawing.Point(711, 455);
            this.trackBar_vitesse.Maximum = 5000;
            this.trackBar_vitesse.Minimum = 500;
            this.trackBar_vitesse.Name = "trackBar_vitesse";
            this.trackBar_vitesse.Size = new System.Drawing.Size(433, 45);
            this.trackBar_vitesse.SmallChange = 100;
            this.trackBar_vitesse.TabIndex = 38;
            this.trackBar_vitesse.TickFrequency = 100;
            this.trackBar_vitesse.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_vitesse.Value = 5000;
            this.trackBar_vitesse.Scroll += new System.EventHandler(this.trackBar_vitesse_Scroll);
            // 
            // label_vitesse
            // 
            this.label_vitesse.AutoSize = true;
            this.label_vitesse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vitesse.Location = new System.Drawing.Point(660, 482);
            this.label_vitesse.Name = "label_vitesse";
            this.label_vitesse.Size = new System.Drawing.Size(0, 13);
            this.label_vitesse.TabIndex = 39;
            this.label_vitesse.UseWaitCursor = true;
            // 
            // button_majStats
            // 
            this.button_majStats.Location = new System.Drawing.Point(1034, 193);
            this.button_majStats.Name = "button_majStats";
            this.button_majStats.Size = new System.Drawing.Size(75, 21);
            this.button_majStats.TabIndex = 44;
            this.button_majStats.Text = "maj Stats";
            this.button_majStats.UseVisualStyleBackColor = true;
            this.button_majStats.Click += new System.EventHandler(this.button_majStats_Click);
            // 
            // checkBox_majStats
            // 
            this.checkBox_majStats.AutoSize = true;
            this.checkBox_majStats.Location = new System.Drawing.Point(646, 193);
            this.checkBox_majStats.Name = "checkBox_majStats";
            this.checkBox_majStats.Size = new System.Drawing.Size(97, 17);
            this.checkBox_majStats.TabIndex = 45;
            this.checkBox_majStats.Text = "maj Temps réel";
            this.checkBox_majStats.UseVisualStyleBackColor = true;
            // 
            // button_seuil
            // 
            this.button_seuil.Location = new System.Drawing.Point(919, 143);
            this.button_seuil.Name = "button_seuil";
            this.button_seuil.Size = new System.Drawing.Size(75, 21);
            this.button_seuil.TabIndex = 46;
            this.button_seuil.Text = "Valider";
            this.button_seuil.UseVisualStyleBackColor = true;
            this.button_seuil.Click += new System.EventHandler(this.button_seuil_Click);
            // 
            // textBox_classe
            // 
            this.textBox_classe.Location = new System.Drawing.Point(581, 79);
            this.textBox_classe.Name = "textBox_classe";
            this.textBox_classe.Size = new System.Drawing.Size(100, 20);
            this.textBox_classe.TabIndex = 47;
            // 
            // button_classe
            // 
            this.button_classe.Location = new System.Drawing.Point(687, 78);
            this.button_classe.Name = "button_classe";
            this.button_classe.Size = new System.Drawing.Size(75, 21);
            this.button_classe.TabIndex = 48;
            this.button_classe.Text = "Valider";
            this.button_classe.UseVisualStyleBackColor = true;
            this.button_classe.Click += new System.EventHandler(this.button_classe_Click);
            // 
            // button_TEST
            // 
            this.button_TEST.Location = new System.Drawing.Point(1015, 74);
            this.button_TEST.Name = "button_TEST";
            this.button_TEST.Size = new System.Drawing.Size(129, 54);
            this.button_TEST.TabIndex = 49;
            this.button_TEST.Text = "TEST";
            this.button_TEST.UseVisualStyleBackColor = true;
            this.button_TEST.Click += new System.EventHandler(this.button_TEST_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 508);
            this.Controls.Add(this.button_TEST);
            this.Controls.Add(this.button_classe);
            this.Controls.Add(this.textBox_classe);
            this.Controls.Add(this.button_seuil);
            this.Controls.Add(this.checkBox_majStats);
            this.Controls.Add(this.button_majStats);
            this.Controls.Add(this.label_vitesse);
            this.Controls.Add(this.trackBar_vitesse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_IHM0);
            this.Controls.Add(this.label_nbrQCM);
            this.Controls.Add(this.label_succes);
            this.Controls.Add(this.label_echec);
            this.Controls.Add(this.label_ecartType);
            this.Controls.Add(this.label_moy);
            this.Controls.Add(this.label_max);
            this.Controls.Add(this.label_med);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.label_note);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.button_ModeManu_Next);
            this.Controls.Add(this.button_ModeManu_Previous);
            this.Controls.Add(this.button_ModeAuto);
            this.Controls.Add(this.button_ModeManu);
            this.Controls.Add(this.button_ModeAuto_Start);
            this.Controls.Add(this.label_IHM15);
            this.Controls.Add(this.label_IHM3);
            this.Controls.Add(this.textBox_Seuil);
            this.Controls.Add(this.label_IHM4);
            this.Controls.Add(this.label_IHM12);
            this.Controls.Add(this.label_IHM11);
            this.Controls.Add(this.label_IHM10);
            this.Controls.Add(this.label_IHM9);
            this.Controls.Add(this.label_IHM8);
            this.Controls.Add(this.label_IHM7);
            this.Controls.Add(this.label_IHM6);
            this.Controls.Add(this.label_IHM5);
            this.Controls.Add(this.label_IHM2);
            this.Controls.Add(this.label_IHM1);
            this.Controls.Add(this.pictureBox_copie);
            this.Controls.Add(this.menuStrip_IHM);
            this.MainMenuStrip = this.menuStrip_IHM;
            this.Name = "Form1";
            this.Text = "Correcteur de QCM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_copie)).EndInit();
            this.menuStrip_IHM.ResumeLayout(false);
            this.menuStrip_IHM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_vitesse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_copie;
        private System.Windows.Forms.MenuStrip menuStrip_IHM;
        private System.Windows.Forms.ToolStripMenuItem menu_Fichier;
        private System.Windows.Forms.ToolStripMenuItem menu_Fichier_Fermer;
        private System.Windows.Forms.ToolStripMenuItem menu_Corrige;
        private System.Windows.Forms.ToolStripMenuItem menu_Corrige_ChargerIMG;
        private System.Windows.Forms.ToolStripMenuItem menu_Corrige_Sauver;
        private System.Windows.Forms.ToolStripMenuItem menu_Corrige_Afficher;
        private System.Windows.Forms.ToolStripMenuItem menu_Correcteur;
        private System.Windows.Forms.ToolStripMenuItem menu_Correcteur_NewCorrection;
        private System.Windows.Forms.ToolStripMenuItem menu_Correcteur_ChargerLib;
        private System.Windows.Forms.ToolStripMenuItem menu_Correcteur_SaveResult;
        private System.Windows.Forms.ToolStripMenuItem menu_Bareme;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser_Result;
        private System.Windows.Forms.OpenFileDialog openFile_Corrige;
        private System.Windows.Forms.Timer timer_ModeAuto;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser_LibImg;
        private System.Windows.Forms.Label label_IHM1;
        private System.Windows.Forms.Label label_IHM2;
        private System.Windows.Forms.Label label_IHM5;
        private System.Windows.Forms.Label label_IHM6;
        private System.Windows.Forms.Label label_IHM7;
        private System.Windows.Forms.Label label_IHM8;
        private System.Windows.Forms.Label label_IHM9;
        private System.Windows.Forms.Label label_IHM10;
        private System.Windows.Forms.Label label_IHM11;
        private System.Windows.Forms.Label label_IHM12;
        private System.Windows.Forms.Label label_IHM4;
        private System.Windows.Forms.TextBox textBox_Seuil;
        private System.Windows.Forms.Label label_IHM3;
        private System.Windows.Forms.Label label_IHM15;
        private System.Windows.Forms.Button button_ModeAuto_Start;
        private System.Windows.Forms.RadioButton button_ModeManu;
        private System.Windows.Forms.RadioButton button_ModeAuto;
        private System.Windows.Forms.Button button_ModeManu_Previous;
        private System.Windows.Forms.Button button_ModeManu_Next;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_note;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.Label label_med;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label label_moy;
        private System.Windows.Forms.Label label_ecartType;
        private System.Windows.Forms.Label label_echec;
        private System.Windows.Forms.Label label_succes;
        private System.Windows.Forms.Label label_nbrQCM;
        private System.Windows.Forms.Label label_IHM0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar_vitesse;
        private System.Windows.Forms.Label label_vitesse;
        private System.Windows.Forms.Button button_majStats;
        private System.Windows.Forms.CheckBox checkBox_majStats;
        private System.Windows.Forms.ToolStripMenuItem menu_Fichier_About;
        private System.Windows.Forms.Button button_seuil;
        private System.Windows.Forms.TextBox textBox_classe;
        private System.Windows.Forms.Button button_classe;
        private System.Windows.Forms.ToolStripMenuItem menu_Correcteur_startCorrec;
        private System.Windows.Forms.Button button_TEST;
    }
}

