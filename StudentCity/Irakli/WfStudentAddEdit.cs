using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Irakli {
    public partial class WfStudentAddEdit : Form {
        public WfStudentAddEdit() {
            InitializeComponent();
            LoadCity();
        }

        private string _validationMessage = "";

        public bool Edit { get; set; }
        public int StudentId { get; set; }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            if (!ValidateData())
            {
                MessageBox.Show(_validationMessage);
                return;
            }
            using (StudentCityDataContext dc=Helpers.SCDC)
            {
                if (!Edit) {
                    try
                    {
                        //dc.Students.InsertOnSubmit(new Student
                        //{
                        //    City_id = Int32.Parse(cbCity.SelectedValue.ToString()),
                        //    FirstName = tbFirstName.Text,
                        //    LastName = tbLastName.Text,
                        //    PersonalID = tbPersonalID.Text,
                        //    PhoneNumber = tbPhoneNumber.Text
                        //});
                        dc.AddStudents(Int32.Parse(cbCity.SelectedValue.ToString()), tbFirstName.Text, tbLastName.Text, tbPersonalID.Text, tbPhoneNumber.Text);
                      //  dc.SubmitChanges();
                        ClearFields();
                    }
                    catch (SqlException ex)
                    {
						//if (ex.Number == 2601)
						//{
						//	MessageBox.Show("სტუდენტი მოცემული პირადი ნომრით უკვე დარეგისტრირებულია.");
						//} else {
                            MessageBox.Show(ex.Message);
						//}
                    }
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(ex.Message);
                    //}
                }
                else {
                    try
                    {
                        var student = dc.Students.First(x => x.Student_id == StudentId);
                        student.City_id = Int32.Parse(cbCity.SelectedValue.ToString());
                        student.FirstName = tbFirstName.Text;
                        student.LastName = tbLastName.Text;
                        student.PersonalID = tbPersonalID.Text;
                        student.PhoneNumber = tbPhoneNumber.Text;
                        dc.SubmitChanges();
                        this.Close();
                    } catch (SqlException ex) {
						//if (ex.Number == 2627) {
						//	MessageBox.Show("სტუდენტი მოცემული პირადი ნომრით უკვე დარეგისტრირებულია.");
						//}
						//else
						//{
                            MessageBox.Show(ex.Message);
						//}
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void ClearFields()
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbPersonalID.Text = "";
            tbPhoneNumber.Text = "";
            cbCity.SelectedIndex = 0;
        }

        private bool ValidateData()
        {
            _validationMessage = "";
            bool retVal = true;
            if (tbFirstName.Text.Length > 100) {
                _validationMessage += "სახელი დასაშვებზე გრძელია! " + Environment.NewLine;
                retVal = false;
            }
            if (tbLastName.Text.Length > 100) {
                _validationMessage += "გვარი დასაშვებზე გრძელია! "  + Environment.NewLine;
                retVal = false;
            }
            if (tbPhoneNumber.Text.Length > 100) {
                _validationMessage += "ტელ. ნომერი დასაშვებზე გრძელია! " + Environment.NewLine;
                retVal = false;
            }
            if (tbPersonalID.Text.Length<11) {
                _validationMessage += "პირადი ნომერი არასწორია! " + Environment.NewLine;
                retVal = false;
            }
			if(Helpers.SCDC.Students.First(x => x.PersonalID == tbPersonalID.Text) == null){
				_validationMessage += "მომხმარებელი იგივე პირადი ნომრით უკვე არსებობს !" + Environment.NewLine;
				retVal = false;
			}
            return retVal;
        }

        private void LoadCity()
        {
            try
            {
                var dc = Helpers.SCDC;
                var qu = from x in dc.Cities
                    select x;
                cbCity.DataSource = qu.ToList();
            } catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
