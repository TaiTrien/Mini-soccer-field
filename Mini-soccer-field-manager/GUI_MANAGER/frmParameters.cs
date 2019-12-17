using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_MANAGER;
using BUS_MANAGER;
namespace GUI_MANAGER
{
    public partial class frmParameters : Form
    {
        private parametersBUS paraBUS;
        parametersDTO para = new parametersDTO();
        
        public frmParameters()
        {
            InitializeComponent();
            paraBUS = new parametersBUS();
        }
        public void loadInfo()
        {
            para = paraBUS.Selected();
            tbFieldPriceDay.Text = para.GiaSanNgay.ToString();
            tbFieldPriceNight.Text = para.GiaSanDem.ToString();
            tbPriceParking.Text = para.GiaGiuXe.ToString();
            tbSalary.Text = para.LuongNhanVien.ToString();
            tbDeposit.Text = para.GiaCoc.ToString();
            loadDrinks();

        }

        private void frmParameters_Load(object sender, EventArgs e)
        {
            loadInfo();
            loadDrinks();
        }
        public void loadDrinks()
        {
            List<drinksDTO> lsDrinks = paraBUS.selectedDrinks();

            for (int i = 0; i < lsDrinks.Count; i++)
            {
                if (lsDrinks[i].MaDoUong == "1")
                {
                    tbWaterInput.Text = lsDrinks[i].DonGiaMua.ToString();
                    tbWaterOutput.Text = lsDrinks[i].DonGiaBan.ToString();
                }
                else
                {
                    tbReviveInput.Text = lsDrinks[i].DonGiaMua.ToString();
                    tbReviveOutput.Text = lsDrinks[i].DonGiaBan.ToString();

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool result;
            //map data from gui
            para.LuongNhanVien = float.Parse(tbSalary.Text);
            para.GiaCoc = float.Parse(tbDeposit.Text);
            para.GiaSanNgay = float.Parse(tbFieldPriceDay.Text);
            para.GiaSanDem = float.Parse(tbFieldPriceNight.Text);
            para.GiaGiuXe = float.Parse(tbPriceParking.Text);

            List<drinksDTO> lsDrinks = new List<drinksDTO> (2);
            drinksDTO waterDTO = new drinksDTO();
            waterDTO.MaDoUong = "1";
            waterDTO.DonGiaMua = float.Parse(tbWaterInput.Text);
            waterDTO.DonGiaBan = float.Parse(tbWaterOutput.Text);

            drinksDTO reviveDTO = new drinksDTO();
            reviveDTO.MaDoUong = "2";
            reviveDTO.DonGiaMua = float.Parse(tbReviveInput.Text);
            reviveDTO.DonGiaBan = float.Parse(tbReviveOutput.Text);

            lsDrinks.Add(waterDTO);
            lsDrinks.Add(reviveDTO);
            
            result = paraBUS.update(lsDrinks, para);
            if (result == false)
                MessageBox.Show("Sửa thất bại.");
            else
                MessageBox.Show("Sửa thành công.");
        }
    }
}
