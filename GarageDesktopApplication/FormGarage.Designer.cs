namespace GarageDesktopApplication
{
    partial class FormGarage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            tabControl = new System.Windows.Forms.TabControl();
            tabPageRegistry = new System.Windows.Forms.TabPage();
            panelToNewColor = new System.Windows.Forms.Panel();
            buttonToNewColor = new System.Windows.Forms.Button();
            groupBoxManufacturer = new System.Windows.Forms.GroupBox();
            radioButtonAlubizTires = new System.Windows.Forms.RadioButton();
            radioButtonTitanWheelz = new System.Windows.Forms.RadioButton();
            radioButtonHoltzFierro = new System.Windows.Forms.RadioButton();
            numericUpDownEngineMaxHorsePower = new System.Windows.Forms.NumericUpDown();
            labelEngineMaxHorsePower = new System.Windows.Forms.Label();
            labelClientDetailsUpdated = new System.Windows.Forms.Label();
            buttonClientDetails = new System.Windows.Forms.Button();
            checkedListBoxGarageJobs = new System.Windows.Forms.CheckedListBox();
            buttonClear = new System.Windows.Forms.Button();
            regexTextBoxCurrentAirPressure = new Proxies.RegexTextBox();
            labelCurrentAirPressure = new System.Windows.Forms.Label();
            buttonRegister = new System.Windows.Forms.Button();
            labelLatestTestDate = new System.Windows.Forms.Label();
            regexTextBoxLicense = new Proxies.RegexTextBox();
            dateTimePickerLastTest = new System.Windows.Forms.DateTimePicker();
            panelCurrentColor = new System.Windows.Forms.Panel();
            buttonCurrentColor = new System.Windows.Forms.Button();
            comboBoxVehicles = new System.Windows.Forms.ComboBox();
            labelVehicle = new System.Windows.Forms.Label();
            comboBoxEngines = new System.Windows.Forms.ComboBox();
            labelEngine = new System.Windows.Forms.Label();
            labelModel = new System.Windows.Forms.Label();
            regexTextBoxModel = new System.Windows.Forms.TextBox();
            labelLicense = new System.Windows.Forms.Label();
            tabPageRepair = new System.Windows.Forms.TabPage();
            buttonRemove = new System.Windows.Forms.Button();
            flowLayoutPanelGarageOperationButtons = new System.Windows.Forms.FlowLayoutPanel();
            dataGridViewVehiclesInGarage = new System.Windows.Forms.DataGridView();
            tabPageQuery = new System.Windows.Forms.TabPage();
            comboBoxQueryOptions = new System.Windows.Forms.ComboBox();
            dataGridViewQuery = new System.Windows.Forms.DataGridView();
            tabControl.SuspendLayout();
            tabPageRegistry.SuspendLayout();
            groupBoxManufacturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEngineMaxHorsePower).BeginInit();
            tabPageRepair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiclesInGarage).BeginInit();
            tabPageQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQuery).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControl.Controls.Add(tabPageRegistry);
            tabControl.Controls.Add(tabPageRepair);
            tabControl.Controls.Add(tabPageQuery);
            tabControl.Location = new System.Drawing.Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(776, 464);
            tabControl.TabIndex = 0;
            // 
            // tabPageRegistry
            // 
            tabPageRegistry.BackColor = System.Drawing.Color.SlateGray;
            tabPageRegistry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tabPageRegistry.Controls.Add(panelToNewColor);
            tabPageRegistry.Controls.Add(buttonToNewColor);
            tabPageRegistry.Controls.Add(groupBoxManufacturer);
            tabPageRegistry.Controls.Add(numericUpDownEngineMaxHorsePower);
            tabPageRegistry.Controls.Add(labelEngineMaxHorsePower);
            tabPageRegistry.Controls.Add(labelClientDetailsUpdated);
            tabPageRegistry.Controls.Add(buttonClientDetails);
            tabPageRegistry.Controls.Add(checkedListBoxGarageJobs);
            tabPageRegistry.Controls.Add(buttonClear);
            tabPageRegistry.Controls.Add(regexTextBoxCurrentAirPressure);
            tabPageRegistry.Controls.Add(labelCurrentAirPressure);
            tabPageRegistry.Controls.Add(buttonRegister);
            tabPageRegistry.Controls.Add(labelLatestTestDate);
            tabPageRegistry.Controls.Add(regexTextBoxLicense);
            tabPageRegistry.Controls.Add(dateTimePickerLastTest);
            tabPageRegistry.Controls.Add(panelCurrentColor);
            tabPageRegistry.Controls.Add(buttonCurrentColor);
            tabPageRegistry.Controls.Add(comboBoxVehicles);
            tabPageRegistry.Controls.Add(labelVehicle);
            tabPageRegistry.Controls.Add(comboBoxEngines);
            tabPageRegistry.Controls.Add(labelEngine);
            tabPageRegistry.Controls.Add(labelModel);
            tabPageRegistry.Controls.Add(regexTextBoxModel);
            tabPageRegistry.Controls.Add(labelLicense);
            tabPageRegistry.Location = new System.Drawing.Point(4, 34);
            tabPageRegistry.Name = "tabPageRegistry";
            tabPageRegistry.Padding = new System.Windows.Forms.Padding(3);
            tabPageRegistry.Size = new System.Drawing.Size(768, 426);
            tabPageRegistry.TabIndex = 0;
            tabPageRegistry.Text = "Registry";
            // 
            // panelToNewColor
            // 
            panelToNewColor.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            panelToNewColor.BackColor = System.Drawing.Color.White;
            panelToNewColor.Location = new System.Drawing.Point(717, 143);
            panelToNewColor.Name = "panelToNewColor";
            panelToNewColor.Size = new System.Drawing.Size(34, 38);
            panelToNewColor.TabIndex = 5;
            panelToNewColor.Visible = false;
            // 
            // buttonToNewColor
            // 
            buttonToNewColor.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonToNewColor.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonToNewColor.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            buttonToNewColor.Location = new System.Drawing.Point(656, 138);
            buttonToNewColor.Name = "buttonToNewColor";
            buttonToNewColor.Size = new System.Drawing.Size(57, 49);
            buttonToNewColor.TabIndex = 9;
            buttonToNewColor.Text = "To";
            buttonToNewColor.UseVisualStyleBackColor = true;
            buttonToNewColor.Visible = false;
            buttonToNewColor.Click += buttonToNewColor_Click;
            // 
            // groupBoxManufacturer
            // 
            groupBoxManufacturer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            groupBoxManufacturer.Controls.Add(radioButtonAlubizTires);
            groupBoxManufacturer.Controls.Add(radioButtonTitanWheelz);
            groupBoxManufacturer.Controls.Add(radioButtonHoltzFierro);
            groupBoxManufacturer.Font = new System.Drawing.Font("Bauhaus 93", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBoxManufacturer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            groupBoxManufacturer.Location = new System.Drawing.Point(484, 189);
            groupBoxManufacturer.Name = "groupBoxManufacturer";
            groupBoxManufacturer.Size = new System.Drawing.Size(216, 133);
            groupBoxManufacturer.TabIndex = 22;
            groupBoxManufacturer.TabStop = false;
            groupBoxManufacturer.Text = "Wheel Manufacturer";
            // 
            // radioButtonAlubizTires
            // 
            radioButtonAlubizTires.AutoSize = true;
            radioButtonAlubizTires.Font = new System.Drawing.Font("Bauhaus 93", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioButtonAlubizTires.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            radioButtonAlubizTires.Location = new System.Drawing.Point(6, 98);
            radioButtonAlubizTires.Name = "radioButtonAlubizTires";
            radioButtonAlubizTires.Size = new System.Drawing.Size(137, 27);
            radioButtonAlubizTires.TabIndex = 2;
            radioButtonAlubizTires.TabStop = true;
            radioButtonAlubizTires.Text = "Alubiz Tires";
            radioButtonAlubizTires.UseVisualStyleBackColor = true;
            // 
            // radioButtonTitanWheelz
            // 
            radioButtonTitanWheelz.AutoSize = true;
            radioButtonTitanWheelz.Font = new System.Drawing.Font("Bauhaus 93", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioButtonTitanWheelz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            radioButtonTitanWheelz.Location = new System.Drawing.Point(6, 64);
            radioButtonTitanWheelz.Name = "radioButtonTitanWheelz";
            radioButtonTitanWheelz.Size = new System.Drawing.Size(151, 27);
            radioButtonTitanWheelz.TabIndex = 1;
            radioButtonTitanWheelz.TabStop = true;
            radioButtonTitanWheelz.Text = "Titan Wheelz";
            radioButtonTitanWheelz.UseVisualStyleBackColor = true;
            // 
            // radioButtonHoltzFierro
            // 
            radioButtonHoltzFierro.AutoSize = true;
            radioButtonHoltzFierro.Checked = true;
            radioButtonHoltzFierro.Font = new System.Drawing.Font("Bauhaus 93", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioButtonHoltzFierro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            radioButtonHoltzFierro.Location = new System.Drawing.Point(6, 30);
            radioButtonHoltzFierro.Name = "radioButtonHoltzFierro";
            radioButtonHoltzFierro.Size = new System.Drawing.Size(136, 27);
            radioButtonHoltzFierro.TabIndex = 0;
            radioButtonHoltzFierro.TabStop = true;
            radioButtonHoltzFierro.Text = "Holtz Fierro";
            radioButtonHoltzFierro.UseVisualStyleBackColor = true;
            // 
            // numericUpDownEngineMaxHorsePower
            // 
            numericUpDownEngineMaxHorsePower.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            numericUpDownEngineMaxHorsePower.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            numericUpDownEngineMaxHorsePower.Increment = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDownEngineMaxHorsePower.Location = new System.Drawing.Point(204, 189);
            numericUpDownEngineMaxHorsePower.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownEngineMaxHorsePower.MaximumSize = new System.Drawing.Size(400, 0);
            numericUpDownEngineMaxHorsePower.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDownEngineMaxHorsePower.MinimumSize = new System.Drawing.Size(223, 0);
            numericUpDownEngineMaxHorsePower.Name = "numericUpDownEngineMaxHorsePower";
            numericUpDownEngineMaxHorsePower.Size = new System.Drawing.Size(256, 31);
            numericUpDownEngineMaxHorsePower.TabIndex = 4;
            numericUpDownEngineMaxHorsePower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            numericUpDownEngineMaxHorsePower.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // labelEngineMaxHorsePower
            // 
            labelEngineMaxHorsePower.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelEngineMaxHorsePower.AutoSize = true;
            labelEngineMaxHorsePower.Font = new System.Drawing.Font("Bauhaus 93", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelEngineMaxHorsePower.ForeColor = System.Drawing.Color.White;
            labelEngineMaxHorsePower.Location = new System.Drawing.Point(21, 195);
            labelEngineMaxHorsePower.Name = "labelEngineMaxHorsePower";
            labelEngineMaxHorsePower.Size = new System.Drawing.Size(182, 25);
            labelEngineMaxHorsePower.TabIndex = 20;
            labelEngineMaxHorsePower.Text = "Max HorsePower:";
            // 
            // labelClientDetailsUpdated
            // 
            labelClientDetailsUpdated.AutoSize = true;
            labelClientDetailsUpdated.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelClientDetailsUpdated.ForeColor = System.Drawing.Color.Maroon;
            labelClientDetailsUpdated.Location = new System.Drawing.Point(181, 381);
            labelClientDetailsUpdated.Name = "labelClientDetailsUpdated";
            labelClientDetailsUpdated.Size = new System.Drawing.Size(138, 23);
            labelClientDetailsUpdated.TabIndex = 19;
            labelClientDetailsUpdated.Text = "Not updated.";
            // 
            // buttonClientDetails
            // 
            buttonClientDetails.BackColor = System.Drawing.Color.CornflowerBlue;
            buttonClientDetails.Font = new System.Drawing.Font("Bauhaus 93", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonClientDetails.Location = new System.Drawing.Point(21, 366);
            buttonClientDetails.Name = "buttonClientDetails";
            buttonClientDetails.Size = new System.Drawing.Size(154, 54);
            buttonClientDetails.TabIndex = 10;
            buttonClientDetails.Text = "Client Details";
            buttonClientDetails.UseVisualStyleBackColor = false;
            buttonClientDetails.Click += buttonClientDetails_Click;
            // 
            // checkedListBoxGarageJobs
            // 
            checkedListBoxGarageJobs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            checkedListBoxGarageJobs.FormattingEnabled = true;
            checkedListBoxGarageJobs.HorizontalScrollbar = true;
            checkedListBoxGarageJobs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            checkedListBoxGarageJobs.Location = new System.Drawing.Point(484, 17);
            checkedListBoxGarageJobs.Name = "checkedListBoxGarageJobs";
            checkedListBoxGarageJobs.Size = new System.Drawing.Size(278, 116);
            checkedListBoxGarageJobs.TabIndex = 7;
            checkedListBoxGarageJobs.ItemCheck += checkedListBoxGarageJobs_ItemCheck;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonClear.BackColor = System.Drawing.Color.LightCoral;
            buttonClear.Font = new System.Drawing.Font("Bauhaus 93", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonClear.Location = new System.Drawing.Point(484, 366);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new System.Drawing.Size(128, 54);
            buttonClear.TabIndex = 16;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // regexTextBoxCurrentAirPressure
            // 
            regexTextBoxCurrentAirPressure.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            regexTextBoxCurrentAirPressure.Location = new System.Drawing.Point(237, 279);
            regexTextBoxCurrentAirPressure.MaximumSize = new System.Drawing.Size(400, 31);
            regexTextBoxCurrentAirPressure.MinimumSize = new System.Drawing.Size(223, 31);
            regexTextBoxCurrentAirPressure.Name = "regexTextBoxCurrentAirPressure";
            regexTextBoxCurrentAirPressure.RegexPattern = "^[0-9\\b]*(?:\\.[0-9\\b]*)?$";
            regexTextBoxCurrentAirPressure.Size = new System.Drawing.Size(223, 31);
            regexTextBoxCurrentAirPressure.TabIndex = 6;
            // 
            // labelCurrentAirPressure
            // 
            labelCurrentAirPressure.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelCurrentAirPressure.AutoSize = true;
            labelCurrentAirPressure.Font = new System.Drawing.Font("Bauhaus 93", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelCurrentAirPressure.ForeColor = System.Drawing.Color.White;
            labelCurrentAirPressure.Location = new System.Drawing.Point(21, 278);
            labelCurrentAirPressure.Name = "labelCurrentAirPressure";
            labelCurrentAirPressure.Size = new System.Drawing.Size(210, 25);
            labelCurrentAirPressure.TabIndex = 14;
            labelCurrentAirPressure.Text = "Current Air Pressure:";
            // 
            // buttonRegister
            // 
            buttonRegister.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonRegister.BackColor = System.Drawing.Color.LightGreen;
            buttonRegister.Font = new System.Drawing.Font("Bauhaus 93", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonRegister.Location = new System.Drawing.Point(634, 365);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new System.Drawing.Size(128, 54);
            buttonRegister.TabIndex = 11;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // labelLatestTestDate
            // 
            labelLatestTestDate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelLatestTestDate.AutoSize = true;
            labelLatestTestDate.Font = new System.Drawing.Font("Bauhaus 93", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelLatestTestDate.ForeColor = System.Drawing.Color.White;
            labelLatestTestDate.Location = new System.Drawing.Point(21, 235);
            labelLatestTestDate.Name = "labelLatestTestDate";
            labelLatestTestDate.Size = new System.Drawing.Size(172, 25);
            labelLatestTestDate.TabIndex = 12;
            labelLatestTestDate.Text = "Latest Test Date:";
            // 
            // regexTextBoxLicense
            // 
            regexTextBoxLicense.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            regexTextBoxLicense.Location = new System.Drawing.Point(204, 17);
            regexTextBoxLicense.MaximumSize = new System.Drawing.Size(400, 31);
            regexTextBoxLicense.MinimumSize = new System.Drawing.Size(223, 31);
            regexTextBoxLicense.Name = "regexTextBoxLicense";
            regexTextBoxLicense.RegexPattern = "^[0-9\\b]*$";
            regexTextBoxLicense.Size = new System.Drawing.Size(259, 31);
            regexTextBoxLicense.TabIndex = 0;
            regexTextBoxLicense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePickerLastTest
            // 
            dateTimePickerLastTest.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dateTimePickerLastTest.Font = new System.Drawing.Font("Bauhaus 93", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateTimePickerLastTest.Location = new System.Drawing.Point(204, 231);
            dateTimePickerLastTest.MaximumSize = new System.Drawing.Size(400, 31);
            dateTimePickerLastTest.MinimumSize = new System.Drawing.Size(223, 31);
            dateTimePickerLastTest.Name = "dateTimePickerLastTest";
            dateTimePickerLastTest.Size = new System.Drawing.Size(256, 31);
            dateTimePickerLastTest.TabIndex = 5;
            dateTimePickerLastTest.ValueChanged += dateTimePickerLastTest_ValueChanged;
            // 
            // panelCurrentColor
            // 
            panelCurrentColor.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            panelCurrentColor.BackColor = System.Drawing.Color.White;
            panelCurrentColor.Location = new System.Drawing.Point(616, 143);
            panelCurrentColor.Name = "panelCurrentColor";
            panelCurrentColor.Size = new System.Drawing.Size(34, 38);
            panelCurrentColor.TabIndex = 4;
            // 
            // buttonCurrentColor
            // 
            buttonCurrentColor.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonCurrentColor.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonCurrentColor.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            buttonCurrentColor.Location = new System.Drawing.Point(484, 138);
            buttonCurrentColor.Name = "buttonCurrentColor";
            buttonCurrentColor.Size = new System.Drawing.Size(128, 48);
            buttonCurrentColor.TabIndex = 8;
            buttonCurrentColor.Text = "Current Color";
            buttonCurrentColor.UseVisualStyleBackColor = true;
            buttonCurrentColor.Click += buttonCurrentColor_Click;
            // 
            // comboBoxVehicles
            // 
            comboBoxVehicles.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comboBoxVehicles.BackColor = System.Drawing.Color.White;
            comboBoxVehicles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxVehicles.FormattingEnabled = true;
            comboBoxVehicles.Location = new System.Drawing.Point(204, 101);
            comboBoxVehicles.MaximumSize = new System.Drawing.Size(400, 0);
            comboBoxVehicles.MinimumSize = new System.Drawing.Size(223, 0);
            comboBoxVehicles.Name = "comboBoxVehicles";
            comboBoxVehicles.Size = new System.Drawing.Size(256, 33);
            comboBoxVehicles.TabIndex = 2;
            // 
            // labelVehicle
            // 
            labelVehicle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelVehicle.AutoSize = true;
            labelVehicle.Font = new System.Drawing.Font("Bauhaus 93", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelVehicle.ForeColor = System.Drawing.Color.White;
            labelVehicle.Location = new System.Drawing.Point(21, 106);
            labelVehicle.Name = "labelVehicle";
            labelVehicle.Size = new System.Drawing.Size(91, 25);
            labelVehicle.TabIndex = 7;
            labelVehicle.Text = "Vehicle:";
            // 
            // comboBoxEngines
            // 
            comboBoxEngines.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comboBoxEngines.BackColor = System.Drawing.Color.White;
            comboBoxEngines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxEngines.FormattingEnabled = true;
            comboBoxEngines.Location = new System.Drawing.Point(204, 145);
            comboBoxEngines.MaximumSize = new System.Drawing.Size(400, 0);
            comboBoxEngines.MinimumSize = new System.Drawing.Size(223, 0);
            comboBoxEngines.Name = "comboBoxEngines";
            comboBoxEngines.Size = new System.Drawing.Size(256, 33);
            comboBoxEngines.TabIndex = 3;
            // 
            // labelEngine
            // 
            labelEngine.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelEngine.AutoSize = true;
            labelEngine.Font = new System.Drawing.Font("Bauhaus 93", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelEngine.ForeColor = System.Drawing.Color.White;
            labelEngine.Location = new System.Drawing.Point(21, 149);
            labelEngine.Name = "labelEngine";
            labelEngine.Size = new System.Drawing.Size(86, 25);
            labelEngine.TabIndex = 4;
            labelEngine.Text = "Engine:";
            // 
            // labelModel
            // 
            labelModel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelModel.AutoSize = true;
            labelModel.Font = new System.Drawing.Font("Bauhaus 93", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelModel.ForeColor = System.Drawing.Color.White;
            labelModel.Location = new System.Drawing.Point(21, 63);
            labelModel.Name = "labelModel";
            labelModel.Size = new System.Drawing.Size(81, 25);
            labelModel.TabIndex = 3;
            labelModel.Text = "Model:";
            // 
            // regexTextBoxModel
            // 
            regexTextBoxModel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            regexTextBoxModel.Location = new System.Drawing.Point(204, 59);
            regexTextBoxModel.MaximumSize = new System.Drawing.Size(400, 31);
            regexTextBoxModel.MinimumSize = new System.Drawing.Size(223, 31);
            regexTextBoxModel.Name = "regexTextBoxModel";
            regexTextBoxModel.Size = new System.Drawing.Size(259, 31);
            regexTextBoxModel.TabIndex = 1;
            regexTextBoxModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelLicense
            // 
            labelLicense.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelLicense.AutoSize = true;
            labelLicense.Font = new System.Drawing.Font("Bauhaus 93", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelLicense.ForeColor = System.Drawing.Color.White;
            labelLicense.Location = new System.Drawing.Point(21, 20);
            labelLicense.Name = "labelLicense";
            labelLicense.Size = new System.Drawing.Size(89, 25);
            labelLicense.TabIndex = 1;
            labelLicense.Text = "License:";
            // 
            // tabPageRepair
            // 
            tabPageRepair.Controls.Add(buttonRemove);
            tabPageRepair.Controls.Add(flowLayoutPanelGarageOperationButtons);
            tabPageRepair.Controls.Add(dataGridViewVehiclesInGarage);
            tabPageRepair.Location = new System.Drawing.Point(4, 34);
            tabPageRepair.Name = "tabPageRepair";
            tabPageRepair.Padding = new System.Windows.Forms.Padding(3);
            tabPageRepair.Size = new System.Drawing.Size(768, 426);
            tabPageRepair.TabIndex = 1;
            tabPageRepair.Text = "Repair";
            tabPageRepair.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = System.Drawing.Color.Black;
            buttonRemove.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            buttonRemove.Location = new System.Drawing.Point(324, 383);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new System.Drawing.Size(120, 43);
            buttonRemove.TabIndex = 2;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // flowLayoutPanelGarageOperationButtons
            // 
            flowLayoutPanelGarageOperationButtons.AutoScroll = true;
            flowLayoutPanelGarageOperationButtons.BackColor = System.Drawing.SystemColors.ControlDark;
            flowLayoutPanelGarageOperationButtons.Location = new System.Drawing.Point(0, 333);
            flowLayoutPanelGarageOperationButtons.Name = "flowLayoutPanelGarageOperationButtons";
            flowLayoutPanelGarageOperationButtons.Size = new System.Drawing.Size(768, 49);
            flowLayoutPanelGarageOperationButtons.TabIndex = 1;
            // 
            // dataGridViewVehiclesInGarage
            // 
            dataGridViewVehiclesInGarage.AllowUserToAddRows = false;
            dataGridViewVehiclesInGarage.AllowUserToDeleteRows = false;
            dataGridViewVehiclesInGarage.AllowUserToResizeColumns = false;
            dataGridViewVehiclesInGarage.AllowUserToResizeRows = false;
            dataGridViewVehiclesInGarage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewVehiclesInGarage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewVehiclesInGarage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewVehiclesInGarage.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewVehiclesInGarage.Location = new System.Drawing.Point(0, 0);
            dataGridViewVehiclesInGarage.MultiSelect = false;
            dataGridViewVehiclesInGarage.Name = "dataGridViewVehiclesInGarage";
            dataGridViewVehiclesInGarage.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewVehiclesInGarage.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewVehiclesInGarage.RowHeadersWidth = 62;
            dataGridViewVehiclesInGarage.RowTemplate.Height = 33;
            dataGridViewVehiclesInGarage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVehiclesInGarage.Size = new System.Drawing.Size(768, 327);
            dataGridViewVehiclesInGarage.TabIndex = 0;
            dataGridViewVehiclesInGarage.CellDoubleClick += dataGridViewVehiclesInGarage_CellDoubleClick;
            dataGridViewVehiclesInGarage.CellFormatting += dataGridViewVehiclesInGarage_CellFormatting;
            dataGridViewVehiclesInGarage.SelectionChanged += dataGridViewVehiclesInGarage_SelectionChanged;
            // 
            // tabPageQuery
            // 
            tabPageQuery.Controls.Add(comboBoxQueryOptions);
            tabPageQuery.Controls.Add(dataGridViewQuery);
            tabPageQuery.Location = new System.Drawing.Point(4, 34);
            tabPageQuery.Name = "tabPageQuery";
            tabPageQuery.Padding = new System.Windows.Forms.Padding(3);
            tabPageQuery.Size = new System.Drawing.Size(768, 426);
            tabPageQuery.TabIndex = 2;
            tabPageQuery.Text = "Query";
            tabPageQuery.UseVisualStyleBackColor = true;
            tabPageQuery.Enter += tabPageQuery_Enter;
            // 
            // comboBoxQueryOptions
            // 
            comboBoxQueryOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxQueryOptions.FormattingEnabled = true;
            comboBoxQueryOptions.Location = new System.Drawing.Point(266, 6);
            comboBoxQueryOptions.Name = "comboBoxQueryOptions";
            comboBoxQueryOptions.Size = new System.Drawing.Size(236, 33);
            comboBoxQueryOptions.TabIndex = 1;
            comboBoxQueryOptions.SelectedIndexChanged += comboBoxQueryOptions_SelectedIndexChanged;
            // 
            // dataGridViewQuery
            // 
            dataGridViewQuery.AllowUserToAddRows = false;
            dataGridViewQuery.AllowUserToDeleteRows = false;
            dataGridViewQuery.AllowUserToResizeColumns = false;
            dataGridViewQuery.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewQuery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewQuery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewQuery.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewQuery.Location = new System.Drawing.Point(6, 45);
            dataGridViewQuery.MultiSelect = false;
            dataGridViewQuery.Name = "dataGridViewQuery";
            dataGridViewQuery.ReadOnly = true;
            dataGridViewQuery.RowHeadersWidth = 62;
            dataGridViewQuery.RowTemplate.Height = 33;
            dataGridViewQuery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewQuery.Size = new System.Drawing.Size(756, 375);
            dataGridViewQuery.TabIndex = 0;
            dataGridViewQuery.CellFormatting += dataGridViewQuery_CellFormatting;
            // 
            // FormGarage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(800, 488);
            Controls.Add(tabControl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(1200, 700);
            MinimumSize = new System.Drawing.Size(822, 506);
            Name = "FormGarage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Garage";
            Load += formGarage_Load;
            tabControl.ResumeLayout(false);
            tabPageRegistry.ResumeLayout(false);
            tabPageRegistry.PerformLayout();
            groupBoxManufacturer.ResumeLayout(false);
            groupBoxManufacturer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEngineMaxHorsePower).EndInit();
            tabPageRepair.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiclesInGarage).EndInit();
            tabPageQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewQuery).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageRegistry;
        private System.Windows.Forms.TabPage tabPageRepair;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox regexTextBoxModel;
        private System.Windows.Forms.Label labelLicense;
        private System.Windows.Forms.ComboBox comboBoxEngines;
        private System.Windows.Forms.Label labelEngine;
        private System.Windows.Forms.ComboBox comboBoxVehicles;
        private System.Windows.Forms.Label labelVehicle;
        private System.Windows.Forms.Button buttonCurrentColor;
        private System.Windows.Forms.Panel panelCurrentColor;
        private System.Windows.Forms.DateTimePicker dateTimePickerLastTest;
        private Proxies.RegexTextBox regexTextBoxLicense;
        private System.Windows.Forms.Label labelLatestTestDate;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelCurrentAirPressure;
        private Proxies.RegexTextBox regexTextBoxCurrentAirPressure;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.CheckedListBox checkedListBoxGarageJobs;
        private System.Windows.Forms.Button buttonClientDetails;
        private System.Windows.Forms.Label labelClientDetailsUpdated;
        private System.Windows.Forms.NumericUpDown numericUpDownEngineMaxHorsePower;
        private System.Windows.Forms.Label labelEngineMaxHorsePower;
        private System.Windows.Forms.GroupBox groupBoxManufacturer;
        private System.Windows.Forms.RadioButton radioButtonHoltzFierro;
        private System.Windows.Forms.RadioButton radioButtonAlubizTires;
        private System.Windows.Forms.RadioButton radioButtonTitanWheelz;
        private System.Windows.Forms.DataGridView dataGridViewVehiclesInGarage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGarageOperationButtons;
        private System.Windows.Forms.Panel panelToNewColor;
        private System.Windows.Forms.Button buttonToNewColor;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TabPage tabPageQuery;
        private System.Windows.Forms.ComboBox comboBoxQueryOptions;
        private System.Windows.Forms.DataGridView dataGridViewQuery;
    }
}