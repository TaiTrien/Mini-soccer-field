using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_MANAGER;
using DTO_MANAGER;

namespace GUI_MANAGER
{
    public partial class frmImportDrinks : Form
    {
        private drinksBUS cleanwaterBUS, reviveBUS, drinksBUS;
        private drinksDTO cleanwaterDTO, reviveDTO;
        public frmImportDrinks()
        {
            InitializeComponent();
            //to custom date of numericupdown
            numericUpDown1.Value = (int)numericUpDown1.Value;
            numericUpDown1.Value = (int)numericUpDown2.Value;
        }

        private void BtnImportDrinks_Click(object sender, EventArgs e)
        {
            cleanwaterBUS = new drinksBUS();
            reviveBUS = new drinksBUS();

            cleanwaterDTO.DoUongConLai += Convert.ToInt32(numericUpDown1.Value);
            reviveDTO.DoUongConLai += Convert.ToInt32(numericUpDown2.Value);

            bool result1 = cleanwaterBUS.update(cleanwaterDTO);
            bool result2 = reviveBUS.update(reviveDTO);
            if (result1 == true && result2 == true)
            {
                MessageBox.Show("Nhập nước thành công :)");
                load();
            }
            else
            {
                MessageBox.Show("Nhập nước thất bại :(");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LbRevie_Click(object sender, EventArgs e)
        {

        }

        private void PBRevie_Click(object sender, EventArgs e)
        {

        }

        private void FrmImportDrinks_Load(object sender, EventArgs e)
        {
            cleanwaterDTO = new drinksDTO();
            reviveDTO = new drinksDTO();
            drinksBUS = new drinksBUS();
            cleanwaterDTO.MaDoUong = "1";
            reviveDTO.MaDoUong = "2";

            calc();
            load();

        }
        private void load()
        {
            tbRestOfWater.Text = cleanwaterDTO.DoUongConLai.ToString();
            tbRestOfRevive.Text = reviveDTO.DoUongConLai.ToString();
        }
        private void calc()
        {
            List<drinksDTO> lsDrinks = drinksBUS.selectDrinks();

            for (int i = 0; i < lsDrinks.Count; i++)
            {
                if (lsDrinks[i].MaDoUong == "1")
                {
                    cleanwaterDTO.DoUongConLai += lsDrinks[i].DoUongConLai;
                }
                else
                {
                    reviveDTO.DoUongConLai += lsDrinks[i].DoUongConLai;
                }
            }
        }

        private void lbRevive_Click(object sender, EventArgs e)
        {

        }
    }
}
