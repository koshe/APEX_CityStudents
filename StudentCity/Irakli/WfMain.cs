using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace Irakli{
    public partial class WfMain : Form
    {
        public WfMain() {
            InitializeComponent();
        }

        private void WfMain_Load(object sender, EventArgs e){
            LoadData();
	        LoadForm();
        }

	    private void LoadForm(){
			if(Properties.Settings.Default.Maximized) {
				WindowState = FormWindowState.Maximized;
				Location = Properties.Settings.Default.Location;
				Size = Properties.Settings.Default.Size;
			} else if(Properties.Settings.Default.Minimized) {
				WindowState = FormWindowState.Minimized;
				Location = Properties.Settings.Default.Location;
				Size = Properties.Settings.Default.Size;
			} else {
				Location = Properties.Settings.Default.Location;
				Size = Properties.Settings.Default.Size;
			}
	    }

	    private void LoadData()
        {
            LoadStudents();
            LoadCity();
        }

        private void LoadStudents(int cityId=0)
        {
            StudentCityDataContext dc=Helpers.SCDC;
            var qu = from x in dc.Students
                where cityId==0 ? true: x.City_id==cityId
                     select new { FullName = x.FirstName + " " + x.LastName, PersonalID = x.PersonalID, PhoneNumber = x.PhoneNumber, Student_id = x.Student_id ,City_id=x.City_id };
            DgStudent.DataSource = qu.ToList();
        }

        private void dgvCity_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvCity.CurrentRow == null) {
                return;
            }
            LoadStudents(Int32.Parse(dgvCity.CurrentRow.Cells["dgCity_City_id"].Value.ToString()));
        }

        private void btnDeleteCity_Click(object sender, EventArgs e) {
            DeleteCity();
        }

        private void DeleteCity() {
            if (dgvCity.CurrentRow == null ||
                MessageBox.Show("გსურთ ჩანაწერის წაშლა?","წაშლა",MessageBoxButtons.OKCancel)!=DialogResult.OK)
            {
                return;
            }
            int id = Int32.Parse(dgvCity.CurrentRow.Cells["dgCity_City_id"].Value.ToString());
                var dc = Helpers.SCDC;
            try
            {
                dc.Cities.DeleteOnSubmit(dc.Cities.First(x => x.City_id == id));
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadCity();
			LoadStudents(Int32.Parse(dgvCity.CurrentRow.Cells["dgCity_City_id"].Value.ToString()));
        }

        private void btnEditCity_Click(object sender, EventArgs e)
        {
            EditCity();
        }

        private void EditCity() {
            if (dgvCity.CurrentRow == null || dgvCity.CurrentRow.Cells["dgCity_City_id"].Value.ToString() == "0") {
                return;
            }
            var frm = new WfCityAddEdit
            {
                Edit = true,
                CityId = Int32.Parse(dgvCity.CurrentRow.Cells["dgCity_City_id"].Value.ToString())
            };
            frm.tbCityName.Text = dgvCity.CurrentRow.Cells["dgCity_CityName"].Value.ToString();
            frm.ShowDialog();
            LoadCity();
        }

        private void LoadCity()
        {
            var dc = Helpers.SCDC;
            try
            {
            var qu =( from x in dc.Cities
                      select new { City_id =x.City_id,CityName=x.CityName}).ToList();
            qu.Insert(0, new { City_id = 0, CityName = "ყველა" });
                    bsCity.DataSource = qu;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddCity_Click(object sender, EventArgs e) {
            AddCity();
        }

        private void AddCity() {
            var frm = new WfCityAddEdit { Edit = false };

            frm.ShowDialog();
            LoadCity();
        }

        private void btnAddStudent_Click(object sender, EventArgs e) {
            AddStudent();
        }

        private void AddStudent() {
            var frm = new WfStudentAddEdit { Edit = false };
			frm.cbCity.SelectedValue = Int32.Parse(dgvCity.CurrentRow.Cells["dgCity_City_id"].Value.ToString());
            frm.ShowDialog();
            LoadStudents();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            EditStudent();
        }

        private void EditStudent() {
            if (DgStudent.CurrentRow != null) {
                WfStudentAddEdit frm = new WfStudentAddEdit {
                    Edit = true,
                    StudentId = Int32.Parse(DgStudent.CurrentRow.Cells["dgStudent_Student_id"].Value.ToString())
                };
                string[] names = DgStudent.CurrentRow.Cells["dgStudent_FullName"].Value.ToString().Split(' ');
                frm.tbFirstName.Text = names[0];
                frm.tbLastName.Text = names[1];
                frm.tbPhoneNumber.Text = DgStudent.CurrentRow.Cells["dgStudent_PhoneNumber"].Value.ToString();
                frm.tbPersonalID.Text = DgStudent.CurrentRow.Cells["dgStudent_PersonalID"].Value.ToString();
                frm.cbCity.SelectedValue = Int32.Parse(DgStudent.CurrentRow.Cells["dgStudent_City_id"].Value.ToString());
                frm.ShowDialog();
                LoadStudents(Int32.Parse(dgvCity.CurrentRow.Cells["dgCity_City_id"].Value.ToString()));
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e) {
            DeleteStudent();
        }

        private void DeleteStudent() {
            if (DgStudent.CurrentRow == null ||
                MessageBox.Show("გსურთ ჩანაწერის წაშლა?", "წაშლა", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
				return;
            }
            StudentCityDataContext dc = Helpers.SCDC;
                dc.DeleteStudents(Int32.Parse(DgStudent.CurrentRow.Cells["dgStudent_Student_id"].Value.ToString()));
                try {
                    LoadStudents(dgvCity.CurrentRow == null ? 0 : Int32.Parse(dgvCity.CurrentRow.Cells["dgCity_City_id"].Value.ToString()));
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
        }

        private void cmsCityBtnAdd_Click(object sender, EventArgs e) {
            AddCity();
        }

        private void cmsCityBtnEdit_Click(object sender, EventArgs e) {
            EditCity();
        }

        private void cmsCityBtnDelete_Click(object sender, EventArgs e) {
            DeleteCity();
        }

        private void cmsStudentsBtnAdd_Click(object sender, EventArgs e) {
            AddStudent();
            
        }

        private void cmsStudentsBtnEdit_Click(object sender, EventArgs e) {
            EditStudent();
        }

        private void cmsStudentsBtnDelete_Click(object sender, EventArgs e) {
            DeleteStudent();
        }

        private void dgvCity_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (dgvCity.CurrentRow==null)
            {
                return;
            }

            if (e.Button==MouseButtons.Right)
            {
               var dg= (sender as DataGridView);
                dg.CurrentCell = dg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                dg.Rows[e.RowIndex].Selected = true;
                dg.Focus();
                cmsCity.Show();
            }
        }

        private void DgStudent_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button != MouseButtons.Right) return;
            var dg=(sender as DataGridView);
            dg.CurrentCell = dg.Rows[e.RowIndex].Cells[e.ColumnIndex];
            dg.Rows[e.RowIndex].Selected = true;
            dg.Focus();
            cmsStudents.Show();
        }

		private void dgvCity_RowEnter(object sender, DataGridViewCellEventArgs e) {
			if(dgvCity.CurrentRow !=null) {
			LoadStudents(Int32.Parse(dgvCity.Rows[e.RowIndex].Cells["dgCity_City_id"].Value.ToString()));
				
			} else{
				LoadStudents();
			}
		}

		private void WfMain_FormClosing(object sender, FormClosingEventArgs e) {
			if(WindowState == FormWindowState.Maximized) {
				Properties.Settings.Default.Location = RestoreBounds.Location;
				Properties.Settings.Default.Size = RestoreBounds.Size;
				Properties.Settings.Default.Maximized = true;
				Properties.Settings.Default.Minimized = false;
			} else if(WindowState == FormWindowState.Normal) {
				Properties.Settings.Default.Location = Location;
				Properties.Settings.Default.Size = Size;
				Properties.Settings.Default.Maximized = false;
				Properties.Settings.Default.Minimized = false;
			} else {
				Properties.Settings.Default.Location = RestoreBounds.Location;
				Properties.Settings.Default.Size = RestoreBounds.Size;
				Properties.Settings.Default.Maximized = false;
				Properties.Settings.Default.Minimized = true;
			}
			Properties.Settings.Default.Save();
		}
    }
}
