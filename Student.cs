using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SelectionBox1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>


    public class Student
    {
        //Create a Student Class✔



        //FIELDS ✔

        public string firstName;
        public string lastName;
        public int CSIgrade;
        public int GenEdGrade;

        //CONSTRUCTOR ✔

        public Student(string firstName, string lastName, int cSIgrade, int genEdGrade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            CSIgrade = cSIgrade;
            GenEdGrade = genEdGrade;
        }





        // Override ToString() ✔

        public override string ToString()
        {
            return firstName + " " + lastName ;
        }




        //What "Item" in your listbox and combo box do you add objects to to display them?
            // ANSWER: Items.Add 

        //What's the property name that returns the selected item's index?
            // ANSWER:  .SelectedIndex 

        //What's the difference between the combo box and the list box?
          // ANSWER: COMBO BOX : Drop down list that shows only one item when selected || LIST BOX: Display multi items & you can select from thenm. 

        //You remove an item from your list box but not the list of data you've associated it with. Is this a problem? Yes or no? And why?
            // ANSWER: 

        //What kind of event is created when you double-click a combo or list box?
         // ANSWER: Double clicking the combo and list box triggers a control method for each boxes. 
    }
}
