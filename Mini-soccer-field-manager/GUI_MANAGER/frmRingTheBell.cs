using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DTO_MANAGER;
using BUS_MANAGER;
using System.Windows.Forms;

namespace GUI_MANAGER
{
    public partial class frmRingTheBell : Form
    {
        private fieldDTO field1DTO, field2DTO;
        private fieldBUS fieldBUS;
        public frmRingTheBell()
        {
            InitializeComponent();
        }

        private void btnField1_Click(object sender, EventArgs e)
        {

        }

        private void frmRingTheBell_Load(object sender, EventArgs e)
        {
            field1DTO = new fieldDTO();
            field2DTO = new fieldDTO();
            fieldBUS = new fieldBUS();
            field1DTO.MaSanBanh = "1";
            field2DTO.MaSanBanh = "2";
            loadInfo();

        }
        private void loadInfo() // to load information for field including customer name, duration of field, field status
        {
            List<fieldDTO> lstFields = fieldBUS.selectedFields();
            if (lstFields != null)
            {
               foreach( fieldDTO fields in lstFields)
                {
                    if (field1DTO.MaSanBanh == fields.MaSanBanh)
                    {
                        tbCustomerField1.Text = fields.tenKH;
                    }
                    else
                    {
                        MessageBox.Show("Nothing to show");
                    }
                }
            }
            else return;
        }
    }
}
