using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Original Code V1.0 : Machyl 30017609, C Blunt, Sprint One
// Modified & New Code: © Bruce Fisher P197681, C Blunt, Sprint One
//
// New Code: © Bruce Fisher P197681, C Blunt, Sprint Two
// Date: 06/10/21
// Version: v3.0
// Astronomical Processing
// Program lists continuous data collected from the interaction of Neutrinos with Earth matter.
// The program will utilise simulated data and allows the user to add, edit, delete, sort and 
// binary search the data. 
// 
// Additional requirements to project to allow users to calcualte with a button 
// the mid-extreme, the mode, the average, the range, detailed tool tips on all GUI and sequential search. 

namespace AstronomicalProcessing
{
    public partial class AstronomicalProcessingForm : Form
    {
        int?[] NeutrinoInteractions = new int?[24];
        int SelectedIndex = -1; // Set nothing selected from list box
        int NumberOfDataEntries = 0;
        readonly String blankEntry = "-";
        bool isSorted = false;
        bool firstKeyPress = true;

        #region Initialise Form Components
        /// <summary>
        /// Initialises Form Components
        /// </summary>
        public AstronomicalProcessingForm()
        {
            InitializeComponent();

            // Tool Tips for mouse cursor hovering over Buttons and Text Box
            toolTip1.SetToolTip(TextBoxMain, "Input Value to process");
            toolTip1.SetToolTip(ButtonAdd, "Add Value To List - from given input");
            toolTip1.SetToolTip(ButtonEdit, "Edit Value In List - from selection in list");
            toolTip1.SetToolTip(ButtonDelete, "Delete Value In List - from selection in list");
            toolTip1.SetToolTip(ButtonSort, "Sort Values - ascending order");
            toolTip1.SetToolTip(ButtonSearch, "Search For First Value - from given input");
            toolTip1.SetToolTip(ButtonAutoFill, "Pre-Fill List - random values");
            toolStripLabel1.Text = ""; // initialise to no text in toolstrip label

            TextBoxMain.MaxLength = 2; // fix textbox to only accept input of 2 digits
        }
        #endregion

        #region Add Button
        /// <summary>
        /// Adds value to the array NeutrinoInteractions 
        /// </summary>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            String inputText = TextBoxMain.Text;
            int inputInt;
            firstKeyPress = true;

            if (Int32.TryParse(inputText, out inputInt) && inputInt >= 10) // Check for invalid input
            {
                if (NumberOfDataEntries < NeutrinoInteractions.Length)
                {
                    for (int i = 0; i < NeutrinoInteractions.Length; i++) //for looking for empty slots
                    {
                        if (!NeutrinoInteractions[i].HasValue)
                        {
                            NeutrinoInteractions[i] = inputInt;
                            DisplayToLabelMsg("Added value : " + inputInt);
                            NumberOfDataEntries++;
                            SelectedIndex = -1; // Set nothing selected from list box
                            UpdateDisplay();
                            TextBoxMain.Clear();
                            TextBoxMain.Focus(); // place cursor back in TextBoxMain
                            isSorted = false;
                            return;
                        }
                    }
                    DisplayToLabelMsg("Application Error - Couldn't find null to fill in array");
                    return;
                }
                TextBoxMain.Clear(); // clear entry
                TextBoxMain.Focus(); // place cursor back in TextBoxMain
                DisplayToLabelMsg("Error - List already full, max : " + NeutrinoInteractions.Length);
                return;
            }
            TextBoxMain.Clear(); // clear invalid entry
            TextBoxMain.Focus(); // place cursor back in TextBoxMain
            DisplayToLabelMsg("Error - Please enter an integer 10 to 99");
        }
        #endregion
        #region Edit Button
        /// <summary>
        /// Edits value in the array NeutrinoInteractions
        /// </summary>
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (SelectedIndex == -1) // Check data is selected from list box
            {
                DisplayToLabelMsg("Error - Please select existing value from list");
                return;
            }
            String inputText = TextBoxMain.Text;
            int dataDeleted = (int)NeutrinoInteractions[SelectedIndex]; // store old value to print in message label
            int inputInt;
            firstKeyPress = true;

            if (Int32.TryParse(inputText, out inputInt) && inputInt >= 10) // Check for invalid input
            {
                NeutrinoInteractions[SelectedIndex] = inputInt;
                DisplayToLabelMsg("Value " + dataDeleted + " Edited to : " + inputInt);
                SelectedIndex = -1; // Set nothing selected from list box
                UpdateDisplay();
                TextBoxMain.Clear();
                TextBoxMain.Focus(); // place cursor back in TextBoxMain
                isSorted = false;
                return;
            }
            TextBoxMain.Clear(); // clear invalid entry
            TextBoxMain.Focus(); // place cursor back in TextBoxMain
            DisplayToLabelMsg("Error - Please enter an integer 10 to 99");
        }
        #endregion
        #region Delete Button
        /// <summary>
        /// Deletes value from the array NeutrinoInteractions from given textbox input
        /// </summary>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (SelectedIndex == -1) // Check data is selected from list box
            {
                DisplayToLabelMsg("Error - Please select existing value from list");
                return;
            }
            
            int dataDeleted = (int)NeutrinoInteractions[SelectedIndex]; // store old value used to print in message labels
            firstKeyPress = true;

            DialogResult DeleteValue = MessageBox.Show("Are you sure you want to Delete this value?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DeleteValue == DialogResult.Yes)
            {
                NeutrinoInteractions[SelectedIndex] = null;
                DisplayToLabelMsg("Deleted value : " + dataDeleted);
                NumberOfDataEntries--;
                SelectedIndex = -1; // Set nothing selected from list box
                UpdateDisplay();
                TextBoxMain.Clear();
                TextBoxMain.Focus(); // place cursor back in TextBoxMain
                isSorted = false;
            }
            else
            {
                SelectedIndex = -1; // Set nothing selected from list box
                TextBoxMain.Clear(); // clear entry
                TextBoxMain.Focus(); // place cursor back in TextBoxMain
                DisplayToLabelMsg("Did NOT Delete Value : " + dataDeleted);
            }
        }
        #endregion
        #region Sort Button
        /// <summary>
        /// Sorts data in the array NeutrinoInteractions in ascending order.
        /// And updates the display with sorted data.
        /// </summary>
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            SelectedIndex = -1; // Set nothing selected from list box
            TextBoxMain.Clear(); // clear any old text box item
            TextBoxMain.Focus(); // place cursor back in TextBoxMain
            SortIntArray();
            UpdateDisplay();
        }
        #endregion
        #region Search Button
        /// <summary>
        /// Searches for given value from textbox in the array NeutrinoInteractions
        /// </summary>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (!isSorted)
            {
                DisplayToLabelMsg("Error - Please Sort list first");
                return;
            }

            String searchText = TextBoxMain.Text;

            if (searchText.Equals(""))
            {
                TextBoxMain.Focus(); // place cursor back in TextBoxMain
                DisplayToLabelMsg("Error - Text box empty, please enter value to Search");
                return;
            }

            int inputInt;
            if (!Int32.TryParse(searchText, out inputInt) || inputInt < 10) // Check for invalid input
            {
                TextBoxMain.Clear(); // clear invalid entry
                TextBoxMain.Focus(); // place cursor back in TextBoxMain
                DisplayToLabelMsg("Error - Please enter an integer 10 to 99");
                return;
            }

            DuplicateBinarySearch(inputInt);
        }
        #endregion
        #region Auto Fill Button
        /// <summary>
        /// Fills values into the array NeutrinoInteractions and updates the display
        /// </summary>
        private void ButtonAutoFill_Click(object sender, EventArgs e)
        {
            AutofillData();
            UpdateDisplay();
        }
        #endregion
        #region Utilities
        #region TextBoxInput_KeyPress
        /// <summary>
        /// Checks Text Input with event handler from form for KeyPress only allowing 
        /// for integers to be entered.
        /// </summary>
        private void TextBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            DisplayToLabelMsg("");

            if (TextBoxMain.Text == "")
            {
                firstKeyPress = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                DisplayToLabelMsg("ERROR: Please enter an integer");
                firstKeyPress = true;
            }
            else
            {
                if (firstKeyPress && e.KeyChar == '0')
                {
                    e.Handled = true;
                    DisplayToLabelMsg("Error - Please enter an integer 10 to 99 keypress trap");
                    firstKeyPress = true;
                }
                else
                {
                    firstKeyPress = false;
                }
            }
        }
        #endregion
        #region AutoFillData
        /// <summary>
        /// Fills values into the array NeutrinoInteractions with random numbers in the range 10 to 99.
        /// For generating random test data.
        /// </summary>
        private void AutofillData()
        {
            Random rnd = new Random();
            bool alreadyFull = true;
            for (int i = 0; i < NeutrinoInteractions.Length; i++) //for looking for empty slots
            {
                if (!NeutrinoInteractions[i].HasValue)
                {
                    alreadyFull = false;
                    NeutrinoInteractions[i] = rnd.Next(10, 100);
                    NumberOfDataEntries++;
                    continue;
                }
            }
            if (alreadyFull)
            {
                DisplayToLabelMsg("Error - No empty slots already full, max : " + NeutrinoInteractions.Length);
            }
            else
            {
                DisplayToLabelMsg("Data has been pre-filled");
                isSorted = false;
            }
            TextBoxMain.Clear(); // clear entry
            TextBoxMain.Focus(); // place cursor back in TextBoxMain
        }
        #endregion
        #region Sort Array
        /// <summary>
        /// Sorts data in the array NeutrinoInteractions in ascending order
        /// </summary>
        private void SortIntArray()
        {
            //setting nulls to -1 before sorting
            for (int i = 0; i < NeutrinoInteractions.Length; i++)
            {
                if (!NeutrinoInteractions[i].HasValue)
                {
                    NeutrinoInteractions[i] = -1;
                }
            }

            #region Bubble Sort
            int int1, int2;
            for (int i = 0; i < NeutrinoInteractions.Length; i++)
            {
                for (int j = 0; j + 1 < NeutrinoInteractions.Length; j++)
                {
                    int1 = NeutrinoInteractions[j].Value;
                    int2 = NeutrinoInteractions[j + 1].Value;
                    if (int1 > int2)
                    {
                        NeutrinoInteractions[j] = int2;
                        NeutrinoInteractions[j + 1] = int1;
                    }
                }
            }
            DisplayToLabelMsg("Data has been Sorted in ascending order");
            #endregion

            //set -1 values back to null after sorting
            for (int i = 0; i < NeutrinoInteractions.Length; i++)
            {
                if (NeutrinoInteractions[i] == -1)
                {
                    NeutrinoInteractions[i] = null;
                }
            }

            isSorted = true;
        }
        #endregion
        #region New Binary Search
        /// <summary>
        /// Searches the array using a half-interval search to find the first element.
        /// Further to finding the first, have modified algorithm to search for multiples 
        /// by looking back from that mid point first found to find first target element and then search
        /// forward from mid point first found to find last target element.
        /// </summary>
        private void DuplicateBinarySearch(int inputInt)
        {
            int min = 0;
            int max = NeutrinoInteractions.Length - 1;
            int mid;
            int firstFound;
            int lastFound;
            bool foundDuplicates = false;

            while (min <= max)
            {
                mid = (min + max) / 2;
                if (NeutrinoInteractions[mid].HasValue && NeutrinoInteractions[mid].Value == inputInt)
                {
                    // find first duplicate element if exists
                    firstFound = mid;
                    if (mid != 0 && (NeutrinoInteractions[mid - 1].HasValue && NeutrinoInteractions[mid - 1].Value == inputInt))
                    {
                        foundDuplicates = true;
                        while (firstFound != 0 && (NeutrinoInteractions[firstFound - 1].HasValue && NeutrinoInteractions[firstFound - 1].Value == inputInt))
                        {
                            firstFound--;
                        }
                    }
                    // find last duplicate element if exists
                    lastFound = mid;
                    if (mid != NeutrinoInteractions.Length - 1 && (NeutrinoInteractions[mid + 1].HasValue && NeutrinoInteractions[mid + 1].Value == inputInt))
                    {
                        foundDuplicates = true;
                        while (lastFound != NeutrinoInteractions.Length - 1 && (NeutrinoInteractions[lastFound + 1].HasValue && NeutrinoInteractions[lastFound + 1].Value == inputInt))
                        {
                            lastFound++;
                        }
                    }
                    if (foundDuplicates)
                    {
                        SelectedIndex = firstFound; // set item found in list to first item found
                        ListBoxMain.SetSelected(firstFound, true);
                        DisplayToLabelMsg("Multiple Values Found : " + NeutrinoInteractions[mid] + " at indexes " + (firstFound + 1) + " to " + (lastFound + 1));
                        SelectedIndex = -1; // Set nothing selected from list box
                        TextBoxMain.Clear(); // clear search item
                        TextBoxMain.Focus(); // place cursor back in TextBoxMain
                        return;
                    }
                    else
                    {
                        SelectedIndex = mid; // set item found in list
                        ListBoxMain.SetSelected(mid, true);
                        DisplayToLabelMsg("Value Found : " + NeutrinoInteractions[mid] + " at index " + (mid + 1));
                        SelectedIndex = -1; // Set nothing selected from list box
                        TextBoxMain.Clear(); // clear search item
                        TextBoxMain.Focus(); // place cursor back in TextBoxMain
                        return;
                    }
                }
                else
                {
                    if (NeutrinoInteractions[mid].HasValue && NeutrinoInteractions[mid].Value > inputInt)
                    {
                        max = mid - 1;
                    }
                    else if (!NeutrinoInteractions[mid].HasValue || NeutrinoInteractions[mid].Value < inputInt) //assuming nulls where sorted to start of array
                    {
                        min = mid + 1;
                    }
                }
                DisplayToLabelMsg("Value NOT Found : " + inputInt);
                SelectedIndex = -1; // Set nothing selected from list box
                TextBoxMain.Clear(); // clear search item
                TextBoxMain.Focus(); // place cursor back in TextBoxMain
            }
        }
        #endregion
        #region UpdateDisplay List Box
        /// <summary>
        /// Fills in listbox with data from NeutrinoInteractions array
        /// </summary>
        private void UpdateDisplay()
        {
            ListBoxMain.Items.Clear();
            for (int i = 0; i < NeutrinoInteractions.Length; i++)
            {
                if (NeutrinoInteractions[i].HasValue)
                    ListBoxMain.Items.Add(NeutrinoInteractions[i]);
                else
                    ListBoxMain.Items.Add(blankEntry);
            }
        }
        #endregion
        #region ListBoxMain Selected Index Changed
        /// <summary>
        /// Sets the SelectedIndex upon clicking a selection from listbox values
        /// </summary>
        private void ListBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = ListBoxMain.SelectedItem.ToString();
            if (curItem == blankEntry)
            {
                SelectedIndex = -1; // Set nothing selected from list box
            }
            else
            {
                SelectedIndex = ListBoxMain.SelectedIndex;
                TextBoxMain.Text = curItem;
            }
        }
        #endregion
        #region DisplayToolLabelMsg
        // <summary>
        /// Displays string parameter given onto toolstriplabel and flashes 
        /// label to draw attention to user that message has been updated
        /// </summary>
        private void DisplayToLabelMsg(String message)
        {
            toolStripLabel1.Text = message;

            if (message != "")
            {
                FlashToolLabel();
            }
        }
        #endregion
        #region FlashToolLabel
        /// <summary>
        /// Flashes tool tip by changing toolstriplabel visable on/off 
        /// to bring attention to error message
        /// </summary>
        private void FlashToolLabel()
        {
            toolStrip1.Visible = false;
            System.Threading.Thread.Sleep(100); // wait time between visability of tooltiplabel
            toolStrip1.Visible = true;
        }
        #endregion
        #endregion
    }
}
