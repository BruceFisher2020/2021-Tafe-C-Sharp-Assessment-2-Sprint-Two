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
// Date: 09/10/21
// Version: v3.8
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
        static int ArraySize = 24;
        int[] NeutrinoInteractions = new int[ArraySize];

        bool firstKeyPress = true; // user input for TextBox first keypress

        static int InputLowestRange = 10; // lowest initial value input range
        static int InputHighestRange = 99; // highest initial value input range

        int selectedIndex = -1; // Set nothing selected from list box
        int numberOfDataEntries = 0; // Set number of Array entries to none

        static String BlankEntry = "-"; // used for display of array cell equals 0

        bool isSorted = false; // Array is not sorted

        bool toggleSystemConfigPanel = false;

        int foundIndex = 0; // sequential search found index
        int startOfSearch = 0; // index to start Next sequential search from

        #region Initialise Form Components
        /// <summary>
        /// Initialises Form Components
        /// </summary>
        public AstronomicalProcessingForm()
        {
            InitializeComponent();

            // Tool Tips for mouse cursor hovering over Buttons and Text Box
            toolTip1.SetToolTip(LabelTitle, "Title of the Application");
            toolTip1.SetToolTip(TextBoxMain, "Input Value to process");
            toolTip1.SetToolTip(ListBoxMain, "List of All Values");

            toolTip1.SetToolTip(ButtonAdd, "Add Value to List - from given input");
            toolTip1.SetToolTip(ButtonEdit, "Edit Value in List - from selection in list");
            toolTip1.SetToolTip(ButtonDelete, "Delete Value In List - from selection in list");
            toolTip1.SetToolTip(ButtonSort, "Sort Values - ascending order");
            toolTip1.SetToolTip(ButtonSearch, "Binary Search for Occurances of Value - from given input");
            toolTip1.SetToolTip(ButtonSeqSearch, "Sequential Search for Occurances of Value - from given input");
            toolTip1.SetToolTip(ButtonAutoFill, "Pre-Fill List - random values");
            toolTip1.SetToolTip(ButtonFindNext, "Find Next Occurance of Sequential Search");

            toolTip1.SetToolTip(ButtonMidExtreme, "Calculate the Mid Extreme - Sum of Smallest Value and Largest Value ÷ 2");
            toolTip1.SetToolTip(TextBoxMidExtreme, "Mid Extreme Calculation Output");

            toolTip1.SetToolTip(ButtonMode, "List Values that Appear Most Frequent");
            toolTip1.SetToolTip(ListBoxMode, "List of Values Most Frequent");

            toolTip1.SetToolTip(ButtonAverage, "Calculate the Average - Sum of All Values ÷ Total Number of Values");
            toolTip1.SetToolTip(TextBoxAverage, "Average Calculation Output");

            toolTip1.SetToolTip(ButtonRange, "Calculate the Range - Difference Between the Smallest Value and Largest Value");
            toolTip1.SetToolTip(TextBoxRange, "Range Calculation Output");

            toolTip1.SetToolTip(toolStrip1, "User Messages Output");

            toolStripLabel1.Text = ""; // initialise to no text in toolstrip label

            // set input Box Main max length to the InputHighestRange length
            TextBoxMain.MaxLength = InputHighestRange.ToString().Length;


            // System Configuration Panel Tools Initial Setting OFF
            SystemConfigPanel.Visible = false;
            LabelMinDataSize.Visible = false;
            TextBoxMinDataSize.Visible = false;
            LabelMaxDataSize.Visible = false;
            TextBoxMaxDataSize.Visible = false;
            ButtonSaveDataSize.Visible = false;
            TextBoxMinDataSize.Text = InputLowestRange.ToString();
            TextBoxMaxDataSize.Text = InputHighestRange.ToString();
            TextBoxMinDataSize.MaxLength = 10;
            TextBoxMaxDataSize.MaxLength = 10;

            ButtonFindNext.Visible = false; // set find next button to invisible until sequential search performed
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
            firstKeyPress = true; // reset

            if (Int32.TryParse(inputText, out inputInt) && inputInt >= InputLowestRange) // Check for invalid input
            {
                if (numberOfDataEntries < NeutrinoInteractions.Length)
                {
                    for (int i = 0; i < NeutrinoInteractions.Length; i++) //for looking for empty slots
                    {
                        if (NeutrinoInteractions[i] == 0)
                        {
                            NeutrinoInteractions[i] = inputInt;
                            DisplayToLabelMsg("Added value : " + inputInt);
                            numberOfDataEntries++;
                            selectedIndex = -1; // Set nothing selected from list box
                            UpdateDisplay();
                            TextBoxMain.Clear();
                            TextBoxMain.Focus(); // place cursor back in TextBoxMain
                            isSorted = false;
                            return;
                        }
                    }
                }
                TextBoxMain.Clear(); // clear entry
                TextBoxMain.Focus(); // place cursor back in TextBoxMain
                DisplayToLabelMsg("Error - List already full, max : " + NeutrinoInteractions.Length);
                return;
            }
            TextBoxMain.Clear(); // clear invalid entry
            TextBoxMain.Focus(); // place cursor back in TextBoxMain
            DisplayToLabelMsg("Error - Please enter an integer " + InputLowestRange + " to " + InputHighestRange);
        }
        #endregion
        #region Edit Button
        /// <summary>
        /// Edits value in the array NeutrinoInteractions
        /// </summary>
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            String inputText = TextBoxMain.Text;
            int inputInt;
            int dataEdited;

            if (selectedIndex == -1) // Check data is selected from list box
            {
                TextBoxMain.Clear(); // clear invalid entry
                TextBoxMain.Focus(); // place cursor back in TextBoxMain
                DisplayToLabelMsg("Error - Please select existing value from list");
                return;
            }
  
            dataEdited = (int)NeutrinoInteractions[selectedIndex]; // store old value to print in message label
            firstKeyPress = true; // reset

            if (Int32.TryParse(inputText, out inputInt) && inputInt >= InputLowestRange) // Check for invalid input
            {
                NeutrinoInteractions[selectedIndex] = inputInt;
                DisplayToLabelMsg("Value " + dataEdited + " Edited to : " + inputInt);
                selectedIndex = -1; // Set nothing selected from list box
                UpdateDisplay();
                TextBoxMain.Clear();
                TextBoxMain.Focus(); // place cursor back in TextBoxMain
                isSorted = false;
                return;
            }
            TextBoxMain.Clear(); // clear invalid entry
            TextBoxMain.Focus(); // place cursor back in TextBoxMain
            DisplayToLabelMsg("Error - Please enter an integer " + InputLowestRange + " to " + InputHighestRange);
        }
        #endregion
        #region Delete Button
        /// <summary>
        /// Deletes value from the array NeutrinoInteractions from given textbox input
        /// </summary>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            int dataDeleted;

            if (selectedIndex == -1) // Check data is selected from list box
            {
                TextBoxMain.Clear(); // clear invalid entry
                TextBoxMain.Focus(); // place cursor back in TextBoxMain
                DisplayToLabelMsg("Error - Please select existing value from list");
                return;
            }
            
            dataDeleted = NeutrinoInteractions[selectedIndex]; // store old value used to print in message labels
            firstKeyPress = true; // reset

            DialogResult DeleteValue = MessageBox.Show("Are you sure you want to Delete this value?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DeleteValue == DialogResult.Yes)
            {
                NeutrinoInteractions[selectedIndex] = 0;
                DisplayToLabelMsg("Deleted value : " + dataDeleted);
                numberOfDataEntries--;
                selectedIndex = -1; // Set nothing selected from list box
                UpdateDisplay();
                TextBoxMain.Clear();
                TextBoxMain.Focus(); // place cursor back in TextBoxMain
                isSorted = false;
            }
            else
            {
                selectedIndex = -1; // Set nothing selected from list box
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
            selectedIndex = -1; // Set nothing selected from list box
            TextBoxMain.Clear(); // clear any old text box item
            TextBoxMain.Focus(); // place cursor back in TextBoxMain

            if (numberOfDataEntries != 0)
            {
                SortIntArray(NeutrinoInteractions);
                DisplayToLabelMsg("Data has been Sorted in ascending order");
                UpdateDisplay();
            }
            else
            {
                DisplayToLabelMsg("Error - No Data in the List");
            }
        }
        #endregion
        #region Search Button
        /// <summary>
        /// Searches for given value from textbox in the array NeutrinoInteractions
        /// </summary>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            String searchText = TextBoxMain.Text;
            int inputInt;
            if (numberOfDataEntries != 0)
            {
                if (!isSorted)
                {
                    DisplayToLabelMsg("Error - Please Sort list first");
                    return;
                }

                if (searchText.Equals(""))
                {
                    TextBoxMain.Focus(); // place cursor back in TextBoxMain
                    DisplayToLabelMsg("Error - Text box empty, please enter value to Search");
                    return;
                }

                if (!Int32.TryParse(searchText, out inputInt) || inputInt < InputLowestRange) // Check for invalid input
                {
                    TextBoxMain.Clear(); // clear invalid entry
                    TextBoxMain.Focus(); // place cursor back in TextBoxMain
                    DisplayToLabelMsg("Error - Please enter an integer " + InputLowestRange + " to " + InputHighestRange);
                    return;
                }

                DuplicateBinarySearch(inputInt);
            }
            else
            {
                DisplayToLabelMsg("Error - No Data in the List");
            }
        }
        #endregion
        #region Sequential Search Button
        private void ButtonSeqSearch_Click(object sender, EventArgs e)
        {
            String searchText = TextBoxMain.Text;
            int inputInt;

            startOfSearch = 0; // index to start search from
            foundIndex = 0; // search item found at index

            if (numberOfDataEntries != 0)
            {
                if (searchText.Equals(""))
                {
                    TextBoxMain.Focus(); // place cursor back in TextBoxMain
                    DisplayToLabelMsg("Error - Text box empty, please enter value to Search");
                    return;
                }

                if (!Int32.TryParse(searchText, out inputInt) || inputInt < InputLowestRange) // Check for invalid input
                {
                    TextBoxMain.Clear(); // clear invalid entry
                    TextBoxMain.Focus(); // place cursor back in TextBoxMain
                    DisplayToLabelMsg("Error - Please enter an integer " + InputLowestRange + " to " + InputHighestRange);
                    return;
                }

            
                if ((foundIndex = sequentialSearch(startOfSearch, inputInt)) != 0)
                {                    
                    ButtonFindNext.Visible = true; // Display find next button - user can then click to find next item
                    TextBoxMain.Enabled = false; // prevent user from changing search value half way thru sequential search
                    ListBoxMain.SetSelected(foundIndex - 1, true); // set item found in list to first item found
                    DisplayToLabelMsg("Value Found : " + NeutrinoInteractions[foundIndex - 1] + " at index " + (foundIndex));
                    startOfSearch = foundIndex; // set point to continue next search from
                }
                else
                {
                    TextBoxMain.Clear(); // clear entry
                    TextBoxMain.Focus(); // place cursor back in TextBoxMain
                    DisplayToLabelMsg("Value NOT Found : " + inputInt);
                }
            }
            else
            {
                TextBoxMain.Clear(); // clear invalid entry
                TextBoxMain.Focus(); // place cursor back in TextBoxMain
                DisplayToLabelMsg("Error - No Data in the List");
            }
        }
        #endregion
        #region Find Next Button
        private void ButtonFindNext_Click(object sender, EventArgs e)
        {
            String searchText = TextBoxMain.Text;
            int inputInt;

            if (!Int32.TryParse(searchText, out inputInt) || inputInt < InputLowestRange) // trap to Check for invalid input
            {
                TextBoxMain.Clear(); // clear invalid entry
                TextBoxMain.Focus(); // place cursor back in TextBoxMain
                DisplayToLabelMsg("Error - Please enter an integer " + InputLowestRange + " to " + InputHighestRange);
                return;
            }

            TextBoxMain.Enabled = false; // prevent user from changing search value half way thru sequential search

            if ((foundIndex = sequentialSearch(startOfSearch, inputInt)) != 0)
            {
                ListBoxMain.SetSelected(foundIndex - 1, true); // set item found in list to first item found
                DisplayToLabelMsg("Value Next Found : " + NeutrinoInteractions[foundIndex - 1] + " at index " + (foundIndex));
                startOfSearch = foundIndex; // set point to continue next search from
            }
            else
            {
                ButtonFindNext.Visible = false; // Disable find next button
                TextBoxMain.Enabled = true; // set back TextBoxMain to user input enabled
                TextBoxMain.Clear(); // clear entry
                TextBoxMain.Focus(); // place cursor back in TextBoxMain        
            }
        }
        #endregion
        #region Mid Extreme Button
        /// <summary>
        /// 
        /// </summary>
        private void ButtonMidExtreme_Click(object sender, EventArgs e)
        {
            float calculation = mathCalculations("MidExtreme");

            if (calculation != 0)
            {
                TextBoxMidExtreme.Text = calculation.ToString("0.00");
                DisplayToLabelMsg("Mid Extreme Calculated");
            }
        }
        #endregion
        #region Mode Button
        /// <summary>
        /// List Values that Appear Most Frequent
        /// </summary>
        private void ButtonMode_Click(object sender, EventArgs e)
        {
            int counter;
            int element;
            int highestFrequency = 1;


            // stores all Modes against their Frequencies for current Valid Data size
            int[,] ModesFreq = new int[ArraySize, 2];
            
            int previousListedMode = 0;
            Boolean modesListed = false;

            // used to sort ModesFreq Array to display in order for list
            int temp;
            int temp2;

            if (numberOfDataEntries != 0)
            {
                for (int i = 0; i < NeutrinoInteractions.Length; i++)
                {
                    if (NeutrinoInteractions[i] != 0)
                    {
                        counter = 0;
                        element = NeutrinoInteractions[i];
                        for (int j = 0; j < NeutrinoInteractions.Length; j++)
                        {
                            if (element == NeutrinoInteractions[j])
                            {
                                counter++;
                            }
                        }
                        if (counter >= highestFrequency)
                        {
                            highestFrequency = counter;
                            ModesFreq[i, 0] = element; // store multiple modes
                            ModesFreq[i, 1] = highestFrequency; // store multiple frequencies
                        }
                    }
                }

                // Sort Modes stored against Frequency to organise to Display List              
                for (int i = 0; i < ArraySize; i++)
                {
                    for (int j = 0; j + 1 < ArraySize; j++)
                    {
                        temp = ModesFreq[j, 0];
                        temp2 = ModesFreq[j, 1];
                        if (ModesFreq[j, 0] > ModesFreq[j + 1, 0])
                        {
                            ModesFreq[j, 0] = ModesFreq[j + 1, 0];
                            ModesFreq[j + 1, 0] = temp;
                            ModesFreq[j, 1] = ModesFreq[j + 1, 1];
                            ModesFreq[j + 1, 1] = temp2;
                        }
                    }
                }

                // Diplay in list the most frequent modes found
                ListBoxMode.Items.Clear();
                for (int i = 0; i < ArraySize; i++)
                {
                    if (ModesFreq[i, 1] != 1 && ModesFreq[i, 1] == highestFrequency && ModesFreq[i, 0] != previousListedMode)
                    {
                        modesListed = true;
                        previousListedMode = ModesFreq[i, 0];
                        ListBoxMode.Items.Add(String.Format("{0,3} {1,12}", ModesFreq[i, 0], ModesFreq[i, 1]));
                    }
                }

                DisplayToLabelMsg("Mode Calculated");
                
                if (!modesListed)
                {
                    ListBoxMode.Items.Add("All Mode Frequencies 1");
                }
            }
            else
            {
                DisplayToLabelMsg("Error - No Data in the List");
            }
        }
        #endregion
        #region Average Button
        /// <summary>
        /// 
        /// </summary>
        private void ButtonAverage_Click(object sender, EventArgs e)
        {
            float calculation = mathCalculations("Average");

            if (calculation != 0)
            {
                TextBoxAverage.Text = calculation.ToString("0.00");
                DisplayToLabelMsg("Average Calculated");
            }
        }
        #endregion
        #region Range Buton
        /// <summary>
        /// 
        /// </summary>
        private void ButtonRange_Click(object sender, EventArgs e)
        {
            float calculation = mathCalculations("Range");

            if (calculation != 0)
            {
                TextBoxRange.Text = calculation.ToString("0");
                DisplayToLabelMsg("Range Calculated");
            }
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            DisplayToLabelMsg(""); // clear previous user error msg

            // trap when user presses backspace after valid input
            // if input is not in config setting
            if (TextBoxMain.Text == "")
            {
                firstKeyPress = true;
            }

            // trap user attempt to enter non valid number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // stop keypress output to textbox
                DisplayToLabelMsg("Error: Please enter an integer"); 
            }
            else
            {
                // trap user attempt to enter first number as 0
                // and check if InputLowestRange is larger than 9 otherwise allow 0
                // and if input TextBox is not for config setting
                if (firstKeyPress && e.KeyChar == '0' && InputLowestRange > 9 && !toggleSystemConfigPanel)
                {
                    e.Handled = true; // stop keypress output to textbox
                    DisplayToLabelMsg("Error Keypress - Please enter an integer " + InputLowestRange + " to " + InputHighestRange);
                }
                else
                {
                    firstKeyPress = false; // valid input was entered for first number
                }
            }
        }
        #endregion
        #region AutoFillData
        /// <summary>
        /// Fills values into the array NeutrinoInteractions with random numbers in the range InputLowestRange to InputHighestRange.
        /// For generating random test data.
        /// </summary>
        private void AutofillData()
        {
            Random rnd = new Random();
            bool alreadyFull = true;
            for (int i = 0; i < NeutrinoInteractions.Length; i++) //for looking for empty slots
            {
                if (NeutrinoInteractions[i] == 0)
                {
                    alreadyFull = false;
                    NeutrinoInteractions[i] = rnd.Next(InputLowestRange, InputHighestRange + 1);
                    numberOfDataEntries++;
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
        /// Sorts data in the array in ascending order
        /// </summary>
        /// <param name="arrayToSort">Array to be sorted</param>
        private void SortIntArray(int[] arrayToSort)
        {
            int temp;
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                for (int j = 0; j + 1 < arrayToSort.Length; j++)
                {
                    temp = arrayToSort[j];
                    if (arrayToSort[j] > arrayToSort[j + 1])
                    {
                        arrayToSort[j] = arrayToSort[j + 1];
                        arrayToSort[j + 1] = temp;
                    }
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
        /// <param name="searchItem">
        /// Search Item
        /// </param>
        private void DuplicateBinarySearch(int searchItem)
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
                if (NeutrinoInteractions[mid] != 0 && NeutrinoInteractions[mid] == searchItem)
                {
                    // find first duplicate element if exists
                    firstFound = mid;
                    if (mid != 0 && (NeutrinoInteractions[mid - 1] != 0 && NeutrinoInteractions[mid - 1] == searchItem))
                    {
                        foundDuplicates = true;
                        while (firstFound != 0 && (NeutrinoInteractions[firstFound - 1] != 0 && NeutrinoInteractions[firstFound - 1] == searchItem))
                        {
                            firstFound--;
                        }
                    }
                    // find last duplicate element if exists
                    lastFound = mid;
                    if (mid != NeutrinoInteractions.Length - 1 && (NeutrinoInteractions[mid + 1] != 0 && NeutrinoInteractions[mid + 1] == searchItem))
                    {
                        foundDuplicates = true;
                        while (lastFound != NeutrinoInteractions.Length - 1 && (NeutrinoInteractions[lastFound + 1] != 0 && NeutrinoInteractions[lastFound + 1] == searchItem))
                        {
                            lastFound++;
                        }
                    }
                    if (foundDuplicates)
                    {
                        //SelectedIndex = firstFound; 
                        ListBoxMain.SetSelected(firstFound, true); // set item found in list to first item found
                        DisplayToLabelMsg("Multiple Values Found : " + NeutrinoInteractions[mid] + " at indexes " + (firstFound + 1) + " to " + (lastFound + 1));
                        selectedIndex = -1; // Set nothing selected from list box
                        TextBoxMain.Clear(); // clear search item
                        TextBoxMain.Focus(); // place cursor back in TextBoxMain
                        return;
                    }
                    else
                    {
                        //SelectedIndex = mid; // set item found in list
                        ListBoxMain.SetSelected(mid, true); // set item found in list to first item found
                        DisplayToLabelMsg("Value Found : " + NeutrinoInteractions[mid] + " at index " + (mid + 1));
                        selectedIndex = -1; // Set nothing selected from list box
                        TextBoxMain.Clear(); // clear search item
                        TextBoxMain.Focus(); // place cursor back in TextBoxMain
                        return;
                    }
                }
                else
                {
                    if (NeutrinoInteractions[mid] != 0 && NeutrinoInteractions[mid] > searchItem)
                    {
                        max = mid - 1;
                    }
                    else if (NeutrinoInteractions[mid] == 0 || NeutrinoInteractions[mid] < searchItem) //assuming zeros where sorted to start of array
                    {
                        min = mid + 1;
                    }
                }
                DisplayToLabelMsg("Value NOT Found : " + searchItem);
                selectedIndex = -1; // Set nothing selected from list box
                TextBoxMain.Clear(); // clear search item
                TextBoxMain.Focus(); // place cursor back in TextBoxMain
            }
        }
        #endregion
        #region Sequential Search
        /// <summary>
        /// Searches through the NeutrinoInteractions array cell by cell 
        /// from passed paramter startOfSearchIndex for passed paramter searchForItem
        /// Returns 
        /// </summary>
        /// <param name="startOfSearchIndex">Start cell Search from this value</param>
        /// <param name="searchForItem">Search Item</param>
        /// <returns>Returns the first foundIndex</returns>
        private int sequentialSearch(int startOfSearchIndex, int searchForItem)
        {
            foundIndex = 0;
            for (int i = startOfSearchIndex; i < NeutrinoInteractions.Length; i++)
            {
                if (NeutrinoInteractions[i] == searchForItem)
                {
                    foundIndex = i; // searchItem found at index i
                    return foundIndex + 1; // add 1 for User readability plus control conditions
                }
            }
            return foundIndex; // returns 0 if item not found
        }
        #endregion
        #region Mathematic Calculations
        /// <summary>
        /// Function used to do calculations and returns calculation 
        /// depending on passed calMethod String value
        /// </summary>
        /// <param name="calMethod">
        /// Switches which Calculation to return ...
        /// MidExtreme - Calculate the Mid Extreme - Sum of Smallest Value and Largest Value ÷ 2 ...
        /// Average - Calculate the Average - Sum of All Values ÷ Total Number of Values ...
        /// Range - Calculate the Range - Difference Between the Smallest Value and Largest Value
        /// </param>
        /// Returns the Switched required calculation
        /// <returns></returns>
        private float mathCalculations(String calMethod)
        {
            float calculation = 0; // return value from calMethod switch
            
            float midExtreme;
            int smallestValue = InputHighestRange; // set to max range for user input of value
            int largestValue = InputLowestRange; // set to min range for user input of value

            float average;
            int sum = 0;

            int range;

            if (numberOfDataEntries != 0)
            {
                for (int i = 0; i < NeutrinoInteractions.Length; i++)
                {
                    if (NeutrinoInteractions[i] != 0)
                    {
                        sum += NeutrinoInteractions[i]; // sum all values for average calculation

                        // find largest value for mid extreme and range calculation
                        if (largestValue < NeutrinoInteractions[i])
                        {
                            largestValue = NeutrinoInteractions[i];
                        }

                        // find smallest value for mid extreme and range calculation
                        if (smallestValue > NeutrinoInteractions[i])
                        {
                            smallestValue = NeutrinoInteractions[i];
                        }
                    }
                }
                midExtreme = (float)(smallestValue + largestValue) / 2;
                average = (float)sum / numberOfDataEntries;
                range = largestValue - smallestValue;
            }
            else
            {
                DisplayToLabelMsg("Error - No Data in the List");
                return 0; // no results as No Data in the List
            }

            // determine which calculation was requested from Method call
            switch(calMethod)
            {
                case "MidExtreme":
                    calculation = midExtreme;
                    break;
                case "Average":
                    calculation = average;
                    break;
                case "Range":
                    calculation = range;
                    break;
                default:
                    // coding error display system error
                    DisplayToLabelMsg("System ERROR: wrong calMethod passed!!!");
                    break;
            }

            return calculation;
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
                if (NeutrinoInteractions[i] != 0)
                {
                    ListBoxMain.Items.Add(NeutrinoInteractions[i]);
                }
                else
                {
                    ListBoxMain.Items.Add(BlankEntry); // empty cell value of 0 -> empty token "-"  displayed
                }
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
            if (curItem == BlankEntry)
            {
                selectedIndex = -1; // Set nothing selected from list box
            }
            else
            {
                selectedIndex = ListBoxMain.SelectedIndex;
                TextBoxMain.Text = curItem;
            }
        }
        #endregion
        #region DisplayToolLabelMsg
        /// <summary>
        /// Displays string parameter given onto toolstriplabel and flashes 
        /// label to draw attention to user that message has been updated
        /// </summary>
        /// <param name="message">
        /// The String to Display in the Tool Label
        /// </param>
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

        private void ButtonSystemConfig_Click(object sender, EventArgs e)
        {
            toggleSystemConfigPanel = !toggleSystemConfigPanel; // toggle System Configuration Panel ON and OFF

            TextBoxMinDataSize.Focus(); // set focus on first TextBox input

            if (toggleSystemConfigPanel)
            { 
                // System Configuration Panel Tools ON
                SystemConfigPanel.Visible = true;
                LabelMinDataSize.Visible = true;
                TextBoxMinDataSize.Visible = true;
                LabelMaxDataSize.Visible = true;
                TextBoxMaxDataSize.Visible = true;
                ButtonSaveDataSize.Visible = true;
            }
            else
            {
                // System Configuration Panel Tools OFF
                SystemConfigPanel.Visible = false;
                LabelMinDataSize.Visible = false;
                TextBoxMinDataSize.Visible = false;
                LabelMaxDataSize.Visible = false;
                TextBoxMaxDataSize.Visible = false;
                ButtonSaveDataSize.Visible = false;
            }
        }

        private void ButtonSaveDataSize_Click(object sender, EventArgs e)
        {        
            String inputMinText = TextBoxMinDataSize.Text;
            int inputMinInt;
            int oldInputMinInt = InputLowestRange;

            String inputMaxText = TextBoxMaxDataSize.Text;
            int inputMaxInt;
            int oldInputMaxInt = InputHighestRange;

            if (Int32.TryParse(inputMinText, out inputMinInt) && Int32.TryParse(inputMaxText, out inputMaxInt) && inputMinInt < inputMaxInt && inputMinInt != 0)
            {
                InputLowestRange = inputMinInt; // set new lowest value input range
                InputHighestRange = inputMaxInt; // set new highest value input range

                // set input Box Main max length to the InputHighestRange length
                TextBoxMain.MaxLength = InputHighestRange.ToString().Length;

                // if inputMinInt and inputMaxInt same as old values 
                if (inputMinInt == oldInputMinInt && inputMaxInt == oldInputMaxInt)
                {
                    ListBoxMain.Items.Clear(); //clear Array and clear List if change made
                    Array.Clear(NeutrinoInteractions, 0, ArraySize); // reset NeutrinoInteractions Array back to zeros
                    numberOfDataEntries = 0; // Set number of Array entries to none
                }
                else if (inputMinInt == oldInputMinInt)
                {
                    InputLowestRange = oldInputMinInt; // reset value back to old as nothing changed
                }
            
                toggleSystemConfigPanel = !toggleSystemConfigPanel; // toggle System Configuration Panel ON and OFF

                // System Configuration Panel Tools OFF
                SystemConfigPanel.Visible = false;
                LabelMinDataSize.Visible = false;
                TextBoxMinDataSize.Visible = false;
                LabelMaxDataSize.Visible = false;
                TextBoxMaxDataSize.Visible = false;
                ButtonSaveDataSize.Visible = false;
            }
            else
            {
                TextBoxMinDataSize.Clear(); // clear invalid entry
                TextBoxMinDataSize.Focus(); // place cursor back in TextBoxMain
                TextBoxMaxDataSize.Clear(); // clear invalid entry
                
                TextBoxMinDataSize.Text = oldInputMinInt.ToString(); // reset to orignal inputs
                TextBoxMaxDataSize.Text = oldInputMaxInt.ToString(); // reset to orignal inputs
                DisplayToLabelMsg("Error - Min cannot be greater than or equal to Max OR 0");

                firstKeyPress = false; // allow user input for TextBoxes first keypress as 0
            }
        }
    }
}
