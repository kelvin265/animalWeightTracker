namespace animalWeightTracker
{
    partial class frmAnimal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAnimalMeal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMeals = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefreshMeals = new System.Windows.Forms.Button();
            this.btnDeleteMeal = new System.Windows.Forms.Button();
            this.btnUpdateMeal = new System.Windows.Forms.Button();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAnimalExercise = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewExercise = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefreshExercise = new System.Windows.Forms.Button();
            this.btnDeleteExercise = new System.Windows.Forms.Button();
            this.btnUpdateExercise = new System.Windows.Forms.Button();
            this.btnAddExercise = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblWaist = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAnimalMeasurement = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewMeasurement = new System.Windows.Forms.DataGridView();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefreshAnimalMeasurement = new System.Windows.Forms.Button();
            this.btnDeleteAnimalMeasurement = new System.Windows.Forms.Button();
            this.btnUpdateAnimalMeasurement = new System.Windows.Forms.Button();
            this.btnAddAnimalMeasurement = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewActivity = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeals)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercise)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeasurement)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivity)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(974, 474);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lblAnimalMeal);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridViewMeals);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(143, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(827, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Animal Meal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Name :";
            // 
            // lblAnimalMeal
            // 
            this.lblAnimalMeal.AutoSize = true;
            this.lblAnimalMeal.Location = new System.Drawing.Point(632, 70);
            this.lblAnimalMeal.Name = "lblAnimalMeal";
            this.lblAnimalMeal.Size = new System.Drawing.Size(30, 25);
            this.lblAnimalMeal.TabIndex = 8;
            this.lblAnimalMeal.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Meals given today :";
            // 
            // dataGridViewMeals
            // 
            this.dataGridViewMeals.AllowUserToAddRows = false;
            this.dataGridViewMeals.AllowUserToDeleteRows = false;
            this.dataGridViewMeals.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridViewMeals.Location = new System.Drawing.Point(3, 98);
            this.dataGridViewMeals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMeals.Name = "dataGridViewMeals";
            this.dataGridViewMeals.Size = new System.Drawing.Size(812, 292);
            this.dataGridViewMeals.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Calories/gram";
            this.Column3.Name = "Column3";
            this.Column3.Width = 165;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Grams";
            this.Column4.Name = "Column4";
            this.Column4.Width = 93;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total calories";
            this.Column5.Name = "Column5";
            this.Column5.Width = 178;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Time";
            this.Column6.Name = "Column6";
            this.Column6.Width = 107;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "select";
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column7.Width = 75;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnRefreshMeals);
            this.panel1.Controls.Add(this.btnDeleteMeal);
            this.panel1.Controls.Add(this.btnUpdateMeal);
            this.panel1.Controls.Add(this.btnAddMeal);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 46);
            this.panel1.TabIndex = 3;
            // 
            // btnRefreshMeals
            // 
            this.btnRefreshMeals.Location = new System.Drawing.Point(343, 2);
            this.btnRefreshMeals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshMeals.Name = "btnRefreshMeals";
            this.btnRefreshMeals.Size = new System.Drawing.Size(99, 40);
            this.btnRefreshMeals.TabIndex = 3;
            this.btnRefreshMeals.Text = "Refresh";
            this.btnRefreshMeals.UseVisualStyleBackColor = true;
            this.btnRefreshMeals.Click += new System.EventHandler(this.BtnRefreshMeals_Click);
            // 
            // btnDeleteMeal
            // 
            this.btnDeleteMeal.Location = new System.Drawing.Point(232, 2);
            this.btnDeleteMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteMeal.Name = "btnDeleteMeal";
            this.btnDeleteMeal.Size = new System.Drawing.Size(85, 40);
            this.btnDeleteMeal.TabIndex = 2;
            this.btnDeleteMeal.Text = "Delete";
            this.btnDeleteMeal.UseVisualStyleBackColor = true;
            this.btnDeleteMeal.Click += new System.EventHandler(this.BtnDeleteMeal_Click);
            // 
            // btnUpdateMeal
            // 
            this.btnUpdateMeal.Location = new System.Drawing.Point(112, 2);
            this.btnUpdateMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateMeal.Name = "btnUpdateMeal";
            this.btnUpdateMeal.Size = new System.Drawing.Size(105, 40);
            this.btnUpdateMeal.TabIndex = 1;
            this.btnUpdateMeal.Text = "Update";
            this.btnUpdateMeal.UseVisualStyleBackColor = true;
            this.btnUpdateMeal.Click += new System.EventHandler(this.BtnUpdateMeal_Click);
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.Location = new System.Drawing.Point(9, 2);
            this.btnAddMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(85, 40);
            this.btnAddMeal.TabIndex = 0;
            this.btnAddMeal.Text = "Add";
            this.btnAddMeal.UseVisualStyleBackColor = true;
            this.btnAddMeal.Click += new System.EventHandler(this.BtnAddMeal_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.lblAnimalExercise);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dataGridViewExercise);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(143, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(827, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Animal Exercise";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(553, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Name :";
            // 
            // lblAnimalExercise
            // 
            this.lblAnimalExercise.AutoSize = true;
            this.lblAnimalExercise.Location = new System.Drawing.Point(639, 69);
            this.lblAnimalExercise.Name = "lblAnimalExercise";
            this.lblAnimalExercise.Size = new System.Drawing.Size(30, 25);
            this.lblAnimalExercise.TabIndex = 9;
            this.lblAnimalExercise.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Exercises done today :";
            // 
            // dataGridViewExercise
            // 
            this.dataGridViewExercise.AllowUserToAddRows = false;
            this.dataGridViewExercise.AllowUserToDeleteRows = false;
            this.dataGridViewExercise.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewExercise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExercise.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dataGridViewExercise.Location = new System.Drawing.Point(3, 98);
            this.dataGridViewExercise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewExercise.Name = "dataGridViewExercise";
            this.dataGridViewExercise.Size = new System.Drawing.Size(812, 292);
            this.dataGridViewExercise.TabIndex = 5;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Id";
            this.Column8.Name = "Column8";
            this.Column8.Width = 50;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Type";
            this.Column9.Name = "Column9";
            this.Column9.Width = 103;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Lost Calories/Minute";
            this.Column10.Name = "Column10";
            this.Column10.Width = 235;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Minutes Spent";
            this.Column11.Name = "Column11";
            this.Column11.Width = 175;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Total Lost";
            this.Column12.Name = "Column12";
            this.Column12.Width = 130;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "select";
            this.Column13.Name = "Column13";
            this.Column13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column13.Width = 75;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btnRefreshExercise);
            this.panel2.Controls.Add(this.btnDeleteExercise);
            this.panel2.Controls.Add(this.btnUpdateExercise);
            this.panel2.Controls.Add(this.btnAddExercise);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 46);
            this.panel2.TabIndex = 4;
            // 
            // btnRefreshExercise
            // 
            this.btnRefreshExercise.Location = new System.Drawing.Point(343, 2);
            this.btnRefreshExercise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshExercise.Name = "btnRefreshExercise";
            this.btnRefreshExercise.Size = new System.Drawing.Size(99, 40);
            this.btnRefreshExercise.TabIndex = 3;
            this.btnRefreshExercise.Text = "Refresh";
            this.btnRefreshExercise.UseVisualStyleBackColor = true;
            this.btnRefreshExercise.Click += new System.EventHandler(this.BtnRefreshExercise_Click);
            // 
            // btnDeleteExercise
            // 
            this.btnDeleteExercise.Location = new System.Drawing.Point(232, 2);
            this.btnDeleteExercise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteExercise.Name = "btnDeleteExercise";
            this.btnDeleteExercise.Size = new System.Drawing.Size(94, 40);
            this.btnDeleteExercise.TabIndex = 2;
            this.btnDeleteExercise.Text = "Delete";
            this.btnDeleteExercise.UseVisualStyleBackColor = true;
            this.btnDeleteExercise.Click += new System.EventHandler(this.BtnDeleteExercise_Click);
            // 
            // btnUpdateExercise
            // 
            this.btnUpdateExercise.Location = new System.Drawing.Point(110, 2);
            this.btnUpdateExercise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateExercise.Name = "btnUpdateExercise";
            this.btnUpdateExercise.Size = new System.Drawing.Size(110, 40);
            this.btnUpdateExercise.TabIndex = 1;
            this.btnUpdateExercise.Text = "Update";
            this.btnUpdateExercise.UseVisualStyleBackColor = true;
            this.btnUpdateExercise.Click += new System.EventHandler(this.BtnUpdateExercise_Click);
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.Location = new System.Drawing.Point(9, 2);
            this.btnAddExercise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(85, 40);
            this.btnAddExercise.TabIndex = 0;
            this.btnAddExercise.Text = "Add";
            this.btnAddExercise.UseVisualStyleBackColor = true;
            this.btnAddExercise.Click += new System.EventHandler(this.BtnAddExercise_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblWaist);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.lblWeight);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.lblAnimalMeasurement);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dataGridViewMeasurement);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(143, 4);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1005, 560);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = " Measurement";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblWaist
            // 
            this.lblWaist.AutoSize = true;
            this.lblWaist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaist.Location = new System.Drawing.Point(738, 398);
            this.lblWaist.Name = "lblWaist";
            this.lblWaist.Size = new System.Drawing.Size(30, 25);
            this.lblWaist.TabIndex = 19;
            this.lblWaist.Text = "...";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(566, 398);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 25);
            this.label14.TabIndex = 18;
            this.label14.Text = "Waist of the day :";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(189, 398);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(30, 25);
            this.lblWeight.TabIndex = 17;
            this.lblWeight.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Weight of the day :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(738, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Cms";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(665, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 25);
            this.label12.TabIndex = 14;
            this.label12.Text = "Waist :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(94, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Kgs";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Weight :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Name :";
            // 
            // lblAnimalMeasurement
            // 
            this.lblAnimalMeasurement.AutoSize = true;
            this.lblAnimalMeasurement.Location = new System.Drawing.Point(629, 76);
            this.lblAnimalMeasurement.Name = "lblAnimalMeasurement";
            this.lblAnimalMeasurement.Size = new System.Drawing.Size(30, 25);
            this.lblAnimalMeasurement.TabIndex = 9;
            this.lblAnimalMeasurement.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Today\'s Measurements:";
            // 
            // dataGridViewMeasurement
            // 
            this.dataGridViewMeasurement.AllowUserToAddRows = false;
            this.dataGridViewMeasurement.AllowUserToDeleteRows = false;
            this.dataGridViewMeasurement.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewMeasurement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeasurement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18});
            this.dataGridViewMeasurement.Location = new System.Drawing.Point(3, 104);
            this.dataGridViewMeasurement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMeasurement.Name = "dataGridViewMeasurement";
            this.dataGridViewMeasurement.Size = new System.Drawing.Size(812, 292);
            this.dataGridViewMeasurement.TabIndex = 6;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Id";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Measurement Type";
            this.Column15.Name = "Column15";
            this.Column15.Width = 240;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Measurement";
            this.Column16.Name = "Column16";
            this.Column16.Width = 155;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Day Time";
            this.Column17.Name = "Column17";
            this.Column17.Width = 170;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Select";
            this.Column18.Name = "Column18";
            this.Column18.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column18.Width = 104;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.btnRefreshAnimalMeasurement);
            this.panel3.Controls.Add(this.btnDeleteAnimalMeasurement);
            this.panel3.Controls.Add(this.btnUpdateAnimalMeasurement);
            this.panel3.Controls.Add(this.btnAddAnimalMeasurement);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(3, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 46);
            this.panel3.TabIndex = 4;
            // 
            // btnRefreshAnimalMeasurement
            // 
            this.btnRefreshAnimalMeasurement.Location = new System.Drawing.Point(343, 2);
            this.btnRefreshAnimalMeasurement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshAnimalMeasurement.Name = "btnRefreshAnimalMeasurement";
            this.btnRefreshAnimalMeasurement.Size = new System.Drawing.Size(99, 40);
            this.btnRefreshAnimalMeasurement.TabIndex = 3;
            this.btnRefreshAnimalMeasurement.Text = "Refresh";
            this.btnRefreshAnimalMeasurement.UseVisualStyleBackColor = true;
            this.btnRefreshAnimalMeasurement.Click += new System.EventHandler(this.BtnRefreshAnimalMeasurement_Click);
            // 
            // btnDeleteAnimalMeasurement
            // 
            this.btnDeleteAnimalMeasurement.Location = new System.Drawing.Point(232, 2);
            this.btnDeleteAnimalMeasurement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteAnimalMeasurement.Name = "btnDeleteAnimalMeasurement";
            this.btnDeleteAnimalMeasurement.Size = new System.Drawing.Size(85, 40);
            this.btnDeleteAnimalMeasurement.TabIndex = 2;
            this.btnDeleteAnimalMeasurement.Text = "Delete";
            this.btnDeleteAnimalMeasurement.UseVisualStyleBackColor = true;
            this.btnDeleteAnimalMeasurement.Click += new System.EventHandler(this.BtnDeleteAnimalMeasurement_Click);
            // 
            // btnUpdateAnimalMeasurement
            // 
            this.btnUpdateAnimalMeasurement.Location = new System.Drawing.Point(115, 2);
            this.btnUpdateAnimalMeasurement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateAnimalMeasurement.Name = "btnUpdateAnimalMeasurement";
            this.btnUpdateAnimalMeasurement.Size = new System.Drawing.Size(91, 40);
            this.btnUpdateAnimalMeasurement.TabIndex = 1;
            this.btnUpdateAnimalMeasurement.Text = "Update";
            this.btnUpdateAnimalMeasurement.UseVisualStyleBackColor = true;
            this.btnUpdateAnimalMeasurement.Click += new System.EventHandler(this.BtnUpdateAnimalMeasurement_Click);
            // 
            // btnAddAnimalMeasurement
            // 
            this.btnAddAnimalMeasurement.Location = new System.Drawing.Point(9, 2);
            this.btnAddAnimalMeasurement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAnimalMeasurement.Name = "btnAddAnimalMeasurement";
            this.btnAddAnimalMeasurement.Size = new System.Drawing.Size(85, 40);
            this.btnAddAnimalMeasurement.TabIndex = 0;
            this.btnAddAnimalMeasurement.Text = "Add";
            this.btnAddAnimalMeasurement.UseVisualStyleBackColor = true;
            this.btnAddAnimalMeasurement.Click += new System.EventHandler(this.BtnAddAnimalMeasurement_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.dataGridViewActivity);
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Location = new System.Drawing.Point(143, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(827, 466);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Activity Level";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Today\'s Activity Level :";
            // 
            // dataGridViewActivity
            // 
            this.dataGridViewActivity.AllowUserToAddRows = false;
            this.dataGridViewActivity.AllowUserToDeleteRows = false;
            this.dataGridViewActivity.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.dataGridViewActivity.Location = new System.Drawing.Point(0, 105);
            this.dataGridViewActivity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewActivity.Name = "dataGridViewActivity";
            this.dataGridViewActivity.Size = new System.Drawing.Size(419, 292);
            this.dataGridViewActivity.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Activity Level";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 170;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Select";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn1.Width = 104;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button4);
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(3, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(809, 46);
            this.panel4.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(112, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 40);
            this.button4.TabIndex = 0;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // frmAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 474);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAnimal";
            this.Load += new System.EventHandler(this.FrmAnimal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeals)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercise)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeasurement)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivity)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefreshMeals;
        private System.Windows.Forms.Button btnDeleteMeal;
        private System.Windows.Forms.Button btnUpdateMeal;
        private System.Windows.Forms.Button btnAddMeal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMeals;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefreshExercise;
        private System.Windows.Forms.Button btnDeleteExercise;
        private System.Windows.Forms.Button btnUpdateExercise;
        private System.Windows.Forms.Button btnAddExercise;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRefreshAnimalMeasurement;
        private System.Windows.Forms.Button btnDeleteAnimalMeasurement;
        private System.Windows.Forms.Button btnUpdateAnimalMeasurement;
        private System.Windows.Forms.Button btnAddAnimalMeasurement;
        private System.Windows.Forms.DataGridView dataGridViewExercise;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewMeasurement;
        private System.Windows.Forms.Label lblAnimalMeal;
        private System.Windows.Forms.Label lblAnimalExercise;
        private System.Windows.Forms.Label lblAnimalMeasurement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column18;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWaist;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column13;
    }
}