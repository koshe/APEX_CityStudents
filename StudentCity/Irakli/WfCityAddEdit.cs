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
    public partial class WfCityAddEdit : Form {
        public bool Edit { get; set; }
        private int _cityId=0;
        public int CityId { get; set; }
        public WfCityAddEdit() {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbCityName.Text=="")
            {
                MessageBox.Show("შეიყვანეთ სახელი");
                return;
            }
            using (var dc=Helpers.SCDC)
            {
                try
                {
                if (Edit)
                {
                    var city = dc.Cities.First(x => x.City_id == CityId);
                    city.CityName = tbCityName.Text;
                }
                else
                {
                    dc.Cities.InsertOnSubmit(new City{CityName = tbCityName.Text});
                }
                dc.SubmitChanges(ConflictMode.FailOnFirstConflict);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (Edit)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else {
                        tbCityName.Text = "";
                    }
                }
            }

        }
    }
}
