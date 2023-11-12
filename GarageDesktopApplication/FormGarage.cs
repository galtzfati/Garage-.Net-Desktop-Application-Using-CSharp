using GarageDesktopApplication.Extensions;
using GarageLogic;
using GarageLogic.Attributes;
using GarageLogic.DTOs;
using GarageLogic.Proxies;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace GarageDesktopApplication
{
    public partial class FormGarage : Form
    {
        private Garage<float> m_Garage = new Garage<float>();
        private Client m_Client = null;
        private System.ComponentModel.BindingList<VehicleDetails<float>> m_VehiclesDetailsQueryBindingList = new System.ComponentModel.BindingList<VehicleDetails<float>>();
        public FormGarage()
        {
            InitializeComponent();
        }

        private void bindDataGridViewQuery()
        {
            dataGridViewQuery.DataSource = m_VehiclesDetailsQueryBindingList;
        }
        private void bindDataGridViewVehiclesInGarageDataSource()
        {
            dataGridViewVehiclesInGarage.DataSource = m_Garage.VehiclesDetails;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearRegistryTabWindow();
        }
        private void buttonClientDetails_Click(object sender, EventArgs e)
        {
            using (FormClientDetails formClientDetails = new FormClientDetails())
            {
                if (m_Client != null)
                {
                    formClientDetails.Client = m_Client;
                    formClientDetails.RegexTextBoxName.Text = m_Client.Name;
                    formClientDetails.RegexTextBoxId.Text = m_Client.Id;
                    formClientDetails.RegexTextBoxPhoneNumber.Text = m_Client.PhoneNumber;
                }
                formClientDetails.ShowDialog();
                m_Client = formClientDetails.Client;
            }
            notifyClientDetailsUpdates(m_Client != null);
        }
        private void buttonCurrentColor_Click(object sender, EventArgs e)
        {
            handleColorChoosingRequest(panelCurrentColor);
        }
        private void buttonGarageOperation_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehiclesInGarage.SelectedRows.Count > 0)
            {
                Button clickedButton = sender as Button;
                if (clickedButton != null)
                {
                    eGarageJobs garageJob = m_Garage.JobNameToEnumJobDictionary[clickedButton.Text];
                    int selectedRowIndex = dataGridViewVehiclesInGarage.SelectedRows[0].Index;
                    string license = ((VehicleDetails<float>)dataGridViewVehiclesInGarage.SelectedRows[0].DataBoundItem).License;
                    try
                    {
                        m_Garage.DoJob(license, garageJob);
                        dataGridViewVehiclesInGarage.Rows[selectedRowIndex].Selected = true;
                        MessageBox.Show($"{clickedButton.Text} ended successfully.", "Operation Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clickedButton.Enabled = false;
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a vehicle (row in the table).", "No Vehicle Selected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            registerVehicle();
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehiclesInGarage.SelectedRows.Count > 0)
            {
                string license = ((VehicleDetails<float>)dataGridViewVehiclesInGarage.SelectedRows[0].DataBoundItem).License;
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this vehicle?", "Removing Vehicle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    string clientName = m_Garage.GetClient(license).Name;
                    m_Garage.RemoveVehicle(license);
                    MessageBox.Show($"{clientName}, thank you for visiting our garage!{Environment.NewLine}Hope to see you again!", "Goodbye", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }
        private void buttonToNewColor_Click(object sender, EventArgs e)
        {
            handleColorChoosingRequest(panelToNewColor);
        }
        private void checkedListBoxGarageJobs_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (m_Garage.JobNameToEnumJobDictionary[(string)checkedListBoxGarageJobs.Items[e.Index]] == eGarageJobs.PaintVehicle)
            {
                buttonToNewColor.Visible = panelToNewColor.Visible = e.NewValue == CheckState.Checked;
            }
        }
        private void clearRegistryTabWindow()
        {
            regexTextBoxLicense.Clear();
            regexTextBoxModel.Clear();
            comboBoxVehicles.SelectedIndex = 0;
            comboBoxEngines.SelectedIndex = 0;
            panelCurrentColor.BackColor = Color.White;
            panelToNewColor.BackColor = Color.White;
            dateTimePickerLastTest.Value = DateTime.Now;
            regexTextBoxCurrentAirPressure.Clear();
            numericUpDownEngineMaxHorsePower.Value = numericUpDownEngineMaxHorsePower.Minimum;
            groupBoxManufacturer.Controls.OfType<RadioButton>().First(radioButton => radioButton.TabIndex == 0).Checked = true;
            uncheckAllItemsInCheckBoxListJobs();
            m_Client = null;
            notifyClientDetailsUpdates(false);
        }
        private void comboBoxQueryOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            eQuery query = (eQuery)((TypeProxy)comboBoxQueryOptions.SelectedItem).Value;
            setVehicleDetailsPassedQueryToQueryBindingList(query);
        }
        private void dataGridViewQuery_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 &&
                (dataGridViewQuery.Columns[e.ColumnIndex].Name == "VehicleType"
                || dataGridViewQuery.Columns[e.ColumnIndex].Name == "EnergySourceType"))
            {
                e.Value = new TypeProxy((Type)e.Value).Name;
                e.FormattingApplied = true;
            }
        }
        private void dataGridViewVehiclesInGarage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                VehicleDetails<float> vehicleDetails = (VehicleDetails<float>)dataGridViewVehiclesInGarage.Rows[e.RowIndex].DataBoundItem;
                Client client = m_Garage.GetClient(vehicleDetails.License);
                MessageBox.Show(@$"Name: {client.Name}
Id: {client.Id}
Phone: {client.PhoneNumber}
Owns: {vehicleDetails.Model}
License: {vehicleDetails.License}", "Client Details", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
        private void dataGridViewVehiclesInGarage_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 &&
                (dataGridViewVehiclesInGarage.Columns[e.ColumnIndex].Name == "VehicleType"
                || dataGridViewVehiclesInGarage.Columns[e.ColumnIndex].Name == "EnergySourceType"))
            {
                e.Value = new TypeProxy((Type)e.Value).Name;
                e.FormattingApplied = true;
            }
        }
        private void dataGridViewVehiclesInGarage_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewVehiclesInGarage.SelectedRows.Count > 0)
            {
                VehicleDetails<float> vehicleDetails = dataGridViewVehiclesInGarage.SelectedRows[0].DataBoundItem as VehicleDetails<float>;
                foreach (Control control in flowLayoutPanelGarageOperationButtons.Controls)
                {
                    if (control is Button operationButton)
                    {
                        eGarageJobs enumJob = m_Garage.JobNameToEnumJobDictionary[operationButton.Text];
                        operationButton.Enabled = (enumJob & vehicleDetails.JobsToDo) == enumJob;
                    }
                }
            }
        }
        private void dateTimePickerLastTest_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerLastTest.Value > DateTime.Now)
            {
                MessageBox.Show("Please enter a date that is not later than today's date.", "Invalid Latest Test Date", MessageBoxButtons.OK);
                dateTimePickerLastTest.Value = DateTime.Now;
            }
        }
        private void formGarage_Load(object sender, EventArgs e)
        {
            loadComboBoxSupportedVehicleTypes();
            loadComboBoxSupportedEnergySourceTypes();
            loadCheckBoxListWithGarageJobs();
            loadComboBoxQueryOptions();
            bindDataGridViewVehiclesInGarageDataSource();
            bindDataGridViewQuery();
            loadOperationButtons();
        }
        private void handleColorChoosingRequest(Panel i_Panel)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.AllowFullOpen = false;
                colorDialog.ShowHelp = false;
                colorDialog.SolidColorOnly = true;
                colorDialog.AnyColor = false;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    i_Panel.BackColor = colorDialog.Color;
                }
            }
        }
        private void loadCheckBoxListWithGarageJobs()
        {
            foreach (string jobName in m_Garage.JobNameToEnumJobDictionary.Keys)
            {
                checkedListBoxGarageJobs.Items.Add(jobName);
            }
        }
        private void loadComboBoxQueryOptions()
        {
            comboBoxQueryOptions.DisplayMember = "Name";
            foreach (eQuery query in Enum.GetValues(typeof(eQuery)))
            {
                comboBoxQueryOptions.Items.Add(new TypeProxy(typeof(eQuery), query, type =>
                {
                    DisplayNameAttribute d = ((DisplayNameAttribute)type.GetField(query.ToString()).GetCustomAttribute(typeof(DisplayNameAttribute)));
                    return d != null ? d.DisplayName : throw new Exception($"Error: add [DisplayNameAttribute(\"DisplayName\")] to the eGarageJobs {query} field");
                }));
            }
            comboBoxQueryOptions.SelectedIndex = 0;
        }
        private void loadComboBoxSupportedEnergySourceTypes()
        {
            comboBoxEngines.DisplayMember = "Name";
            foreach (Type type in m_Garage.SupportedEnergySourceTypes)
            {
                comboBoxEngines.Items.Add(new TypeProxy(type));
            }
            comboBoxEngines.SelectedIndex = 0;
        }
        private void loadComboBoxSupportedVehicleTypes()
        {
            comboBoxVehicles.DisplayMember = "Name";
            foreach (Type type in m_Garage.SupportedVehicleTypes)
            {
                comboBoxVehicles.Items.Add(new TypeProxy(type));
            }
            comboBoxVehicles.SelectedIndex = 0;
        }
        private void loadOperationButtons()
        {
            int totalWidth = 0;
            foreach (string jobName in m_Garage.JobNameToEnumJobDictionary.Keys)
            {
                Button newButton = new Button()
                {
                    Text = jobName,
                    Height = flowLayoutPanelGarageOperationButtons.Height - 10,
                    BackColor = Color.AliceBlue,
                    ForeColor = Color.Magenta,
                    AutoSize = true,
                };
                newButton.Click += buttonGarageOperation_Click;
                flowLayoutPanelGarageOperationButtons.Controls.Add(newButton);
                totalWidth += newButton.Width;
            }
            int width = flowLayoutPanelGarageOperationButtons.Width - (totalWidth + 20);
            flowLayoutPanelGarageOperationButtons.Padding = new Padding(width / 2, 2, width / 2, 2);
        }
        private void notifyClientDetailsUpdates(bool isUpdated)
        {
            labelClientDetailsUpdated.Text = isUpdated ? "Updated." : "Not updated.";
            labelClientDetailsUpdated.ForeColor = isUpdated ? Color.LightGreen : Color.Maroon;
        }
        private void registerVehicle()
        {
            eGarageJobs allJobsToDo = getAllRequestedJobsCombined();
            if (m_Client != null && this.AllTextBoxesAreFilled() && allJobsToDo != default)
            {
                m_Client.LicenseNumber = regexTextBoxLicense.Text;
                VehicleDetails<float> vehicleDetails = generateVehicleDetails(allJobsToDo);
                bool insertionSucceeded = tryInsertVehicleToGarage(vehicleDetails, m_Client, out string o_UserMessage);
                if (insertionSucceeded)
                {
                    MessageBox.Show(o_UserMessage, "Registration Succeeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearRegistryTabWindow();
                }
                else
                {
                    MessageBox.Show(o_UserMessage, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Not All data has been applied!{Environment.NewLine}Make sure to check at least one garage operation.{Environment.NewLine}Make sure all text fields are filled.");
            }
        }
        private void setVehicleDetailsPassedQueryToQueryBindingList(eQuery i_Query)
        {
            IEnumerable<VehicleDetails<float>> passedQuery;
            switch (i_Query)
            {
                case eQuery.FullOfEnergy:
                    passedQuery = m_Garage.QueryVehicles(vehicleDetails => vehicleDetails.CurrentEnergyLevel == 100f);
                    break;
                case eQuery.JobsAreDone:
                    passedQuery = m_Garage.QueryVehicles(vehicleDetails => vehicleDetails.JobsToDo == default);
                    break;
                case eQuery.TestPassedInCurrentYear:
                    passedQuery = m_Garage.QueryVehicles(vehicleDetails => vehicleDetails.LastTestDate.Year == DateTime.Now.Year);
                    break;
                case eQuery.VehicleColorIsDark:
                    passedQuery = m_Garage.QueryVehicles(vehicleDetails => vehicleDetails.CurrentColor.IsDarkColor());
                    break;
                default:
                    return;
            }
            m_VehiclesDetailsQueryBindingList.Clear();
            foreach (VehicleDetails<float> vehicleDetails in passedQuery)
            {
                m_VehiclesDetailsQueryBindingList.Add(vehicleDetails);
            }
        }
        private void tabPageQuery_Enter(object sender, EventArgs e)
        {
            setVehicleDetailsPassedQueryToQueryBindingList((eQuery)((TypeProxy)comboBoxQueryOptions.SelectedItem).Value);
        }
        private void uncheckAllItemsInCheckBoxListJobs()
        {
            for (int i = 0; i < checkedListBoxGarageJobs.Items.Count; i++)
            {
                checkedListBoxGarageJobs.SetItemChecked(i, false);
            }
        }
        private bool tryInsertVehicleToGarage(VehicleDetails<float> i_VehicleDetails, Client i_Client, out string o_UserMessage)
        {
            try
            {
                m_Garage.InsertVehicle(i_VehicleDetails, i_Client);
                o_UserMessage = "Vehicle registered to garage successfully.";
                return true;
            }
            catch (TargetInvocationException ex) when (ex.InnerException is NotSupportedException)
            {
                o_UserMessage = ex.InnerException.Message;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                o_UserMessage = ex.Message;
            }
            catch (ArgumentException ex)
            {
                o_UserMessage = ex.Message;
            }
            return false;
        }
        private eGarageJobs getAllRequestedJobsCombined()
        {
            List<eGarageJobs> garageJobsList = new List<eGarageJobs>();
            foreach (object job in getCheckedObjectsOfCheckBoxList(checkedListBoxGarageJobs))
            {
                garageJobsList.Add(m_Garage.JobNameToEnumJobDictionary[(string)job]);
            }
            return combineEnumValues(garageJobsList);
        }
        private IEnumerable<object> getCheckedObjectsOfCheckBoxList(CheckedListBox i_CheckedListBox)
        {
            for (int i = 0; i < i_CheckedListBox.Items.Count; i++)
            {
                if (i_CheckedListBox.GetItemChecked(i))
                {
                    yield return i_CheckedListBox.Items[i];
                }
            }
        }
        private RadioButton fetchChosenRadioButton(GroupBox i_GroupBox)
        {
            foreach (Control control in i_GroupBox.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    if (radioButton.Checked)
                    {
                        return radioButton;
                    }
                }
            }
            return null;
        }
        private TEnum combineEnumValues<TEnum>(IEnumerable<TEnum> i_Enums)
            where TEnum : Enum
        {
            int intValue = 0;
            foreach (TEnum enumValue in i_Enums)
            {
                intValue |= Convert.ToInt32(enumValue);
            }
            return (TEnum)Enum.ToObject(typeof(TEnum), intValue);
        }
        private VehicleDetails<float> generateVehicleDetails(eGarageJobs i_GarageJobsToDo)
        {
            return new VehicleDetails<float>()
            {
                VehicleType = (comboBoxVehicles.SelectedItem as TypeProxy).Type,
                EnergySourceType = (comboBoxEngines.SelectedItem as TypeProxy).Type,
                MaximalEnergyCapacity = (float)numericUpDownEngineMaxHorsePower.Value,
                WheelManufacturer = fetchChosenRadioButton(groupBoxManufacturer).Text,
                License = regexTextBoxLicense.Text,
                Model = regexTextBoxModel.Text,
                LastTestDate = dateTimePickerLastTest.Value.Date,
                CurrentWheelAirPressure = float.Parse(regexTextBoxCurrentAirPressure.Text),
                JobsToDo = i_GarageJobsToDo,
                CurrentColor = panelCurrentColor.BackColor,
                NewColor = panelToNewColor.BackColor
            };
        }
    }
}