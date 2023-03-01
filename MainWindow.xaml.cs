using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using Microsoft.VisualBasic;

namespace SelectionBox1
{
    //EDNA LYNN LAXA 
    // FEBRUARY 26, 2022 
    // SELECTION BOXES 
    // CSI 122 - PROGRAMMING II 

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        Student selectedStudent = null; 


        public MainWindow()
        {
            InitializeComponent();

            studentNames();  //Calling studentNames method 
            DisplayListBox(); //Calling DisplayBox Method 
            DisplayToComboBox();

           


            LBDisplay.SelectedIndex = 0; // Auto selects a name on the LB , index 0 will be highlighted. 
            CBDisplay.SelectedIndex = 0; // Auto selects a name on the CB , index 0 will be highlighted. 

        }

        public void studentNames()
        {
            Student student = new Student("Mileena", "Kombat", 29, 94);
            students.Add(new Student("Jax", "Mortal", 38, 85));
            students.Add(new Student("Kitana", "Kombat", 68, 90));
            students.Add(new Student("Sonya", "Blade", 71, 94));
            students.Add(new Student("Katy", "Perry", 95, 100));
            students.Add(new Student("Reese", "Witherspoon", 100, 100));

        }
        public void DisplayStudentInformation(Student student)
        {
            txtFirstName.Text = student.firstName;
            txtLastName.Text = student.lastName;
            txtCSIgrade.Text = student.CSIgrade.ToString();
            txtGenEdGrade.Text = student.GenEdGrade.ToString();
        }


        public void DisplayListBox() // DEDICATED METHOD FOR DATA THAT PROMPTS ONTO LISTBOX 
        {
            //Use.Clear() to clear items in list box
            LBDisplay.Items.Clear();



            for (int i = 0; i < students.Count; i++) // Presenting a for loop , usage to go through student list and displaying names in LB.
            {

                LBDisplay.Items.Add(students[i]);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) // Manually add student name , ADD STUDENT BUTTON 
        {
            // Button One, take the information from the text boxes, create a new Student, and add that student to the list.Have the listbox update with the new student. ✔

            string fName = txtFirstName.Text;    //Providing value for first name textbox. 
            string lName = txtLastName.Text;    //Providing value for last  name textbox. 
            string csi = txtCSIgrade.Text;      //Providing value for CSI grade textbox. 
            string gened = txtGenEdGrade.Text;  //Providing value for GenEd textbox. 

            int genEdGrade = int.Parse(gened); // Parsing grade to integer 
            int csigrade = int.Parse(csi); // Parsing grade to integer 



            students.Add(new Student(fName, lName, csigrade, genEdGrade)); //This code structures provides a create action for new instance of student. This will add the text in ListBox where the student's names are already listed. 


            DisplayListBox(); // Calling DisplayListBox method to add student name accordingly to it's original list. 
        }

        private void btnDisplayStudent_Click(object sender, RoutedEventArgs e) // DISPLAY STUDEN INFO IN TEXT BOX BUTTON 
        {
            //Button Two, when a student is selected in the list, when the button is clicked, have that students information display in the text boxes✔

            // Can access the LB  by selecting the highlighted name, the computer will define that name as a Index.
            // This can be identified by using .SelectedIndex 

            int selectedIndex = LBDisplay.SelectedIndex;

            if (selectedIndex < 0)
            {
                MessageBox.Show("Please select a name from the box");  // Msg will prompt if nothing is selected when clicking button. 
            }
            else
            {
                Student selectedStudent = students[selectedIndex];

                txtFirstName.Text = selectedStudent.firstName;
                txtLastName.Text = selectedStudent.lastName;
                txtCSIgrade.Text = selectedStudent.CSIgrade.ToString();
                txtGenEdGrade.Text = selectedStudent.GenEdGrade.ToString();


            }


        }

        private void btnRemove_Click(object sender, RoutedEventArgs e) // REMOVE FROM LIST BUTTON 
        {
            //Button Three: Remove the selected student from the student's list. Then update the listbox. The student should no longer be seen on the list box.✔

            int selectedIndex = LBDisplay.SelectedIndex;

            students.RemoveAt(selectedIndex);

            DisplayListBox();
          
        }
        public void DisplayToComboBox()
        {
            //Use.Clear() to clear items in list box
            CBDisplay.Items.Clear();



            for (int i = 0; i < students.Count; i++) // Presenting a for loop , usage to go through student list and displaying names in LB.
            {

                CBDisplay.Items.Add(students[i]);
            }
        }
        public void DisplayUpdatedInformation(int selectedIndex)
        {
            
            selectedStudent = students[selectedIndex]; //Selecting a student and it's corresponding Index 
            DisplayStudentInformation(selectedStudent); // This method queues information to the textbox 
        }
        
        private void CBDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Add a combo box✔

            //Have the code you just built work for the combo box too.You don't need to create duplicates of your controls✔

            DisplayUpdatedInformation(CBDisplay.SelectedIndex); //Calling DisplayUpdatedInformation onto ComboBox event, W/IN 
            //the DisplayUpdatedInformation method, it is calling DisplayStudentInformation in which means whatever name is selected
            //W/IN the combobox will follow onto the text boxes. 
        }
    }
}
