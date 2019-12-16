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
using System.Diagnostics;

namespace GUI_MANAGER
{
    public partial class frmRingTheBell : Form
    {
        public static string SetValueForNameCustomer = "";
        public static string SetValueForTongGioDa = "";
        public static string SetValueForSoGioDatSan1 = "";
        public static string SetValueForSoGioDatSan2 = "";
        public static string SetValueForMaSan = "";


        private fieldDTO field1DTO, field2DTO;
        private fieldBUS fieldBUS;
        private int durationField1 = 0; // with minutes
        private int durationField2 = 0;
        public frmRingTheBell()
        {
            InitializeComponent();

        }

        private void btnField1_Click(object sender, EventArgs e)
        {
            durationField1 = changeStringIntoIntTime(tbTimerField1.Text);
            if (tbTimerField1.BackColor == Color.Green) // to check field busy
            {
                if (!String.IsNullOrEmpty(tbCustomerField1.Text))
                {
                    SetValueForSoGioDatSan1 = tbTimerField1.Text;
                    countDownTimerField1.Start();
                    countDownTimerField1.Enabled = true;
                    tbTimerField1.BackColor = Color.Red;
                }

            }
            else if (tbTimerField1.BackColor == Color.Red) // to click another time
            {
                if (!String.IsNullOrEmpty(tbCustomerField1.Text))
                {
                    countDownTimerField1.Stop();
                    tbTimerField1.BackColor = Color.Green;
                    DialogResult result = MessageBox.Show("Bạn có muốn tính tiền sân này không?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        SetValueForNameCustomer = tbCustomerField1.Text;
                        SetValueForTongGioDa = (changeStringIntoIntTime(SetValueForSoGioDatSan1) - durationField1).ToString();
                        SetValueForMaSan = "1";
                        frmPayment frmPayment = new frmPayment();
                        frmPayment.Show();

                        loadInfo();
                    }
                    else if (result == DialogResult.No)
                    {
                        countDownTimerField1.Start();
                        tbTimerField1.BackColor = Color.Red;
                    }
                }
            }
        }

        private void btnField2_Click(object sender, EventArgs e)
        {
            durationField2 = changeStringIntoIntTime(tbTimerField2.Text);
            if (tbTimerField2.BackColor == Color.Green) // to check field busy
            {
                if (!String.IsNullOrEmpty(tbCustomerField2.Text))
                {
                    countDownTimerField2.Start();
                    countDownTimerField2.Enabled = true;
                    tbTimerField2.BackColor = Color.Red;
                }

            }
            else if (tbTimerField2.BackColor == Color.Red) // to click another time
            {
                if (!String.IsNullOrEmpty(tbCustomerField1.Text))
                {
                    countDownTimerField2.Stop();
                    tbTimerField2.BackColor = Color.Green;
                    DialogResult result = MessageBox.Show("Bạn có muốn tính tiền sân này không?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        SetValueForNameCustomer = tbCustomerField2.Text;
                        SetValueForTongGioDa = (changeStringIntoIntTime(SetValueForSoGioDatSan1) - durationField2).ToString();
                        SetValueForMaSan = "2";
                        frmPayment frmPayment = new frmPayment();
                        frmPayment.Show();
                        /*get data to form payment here*/
                        /*Update database functionin here*/
                        loadInfo();
                    }
                    else if (result == DialogResult.No)
                    {
                        countDownTimerField2.Start();
                        tbTimerField2.BackColor = Color.Red;
                    }
                }
            }
        }
        private void countDownTimerField1_Tick(object sender, EventArgs e)
        {
            durationField1--;
            int hours, minutes, seconds;
            hours = durationField1 / 3600;
            minutes = (durationField1 % 3600) / 60;
            seconds = (durationField1 % 3600) % 60;
            tbTimerField1.Text = (hours >= 10 ? hours.ToString() : "0" + hours) + ":" +
                (minutes >= 10 ? minutes.ToString() : "0" + minutes) + ":" +
                    (seconds >= 10 ? seconds.ToString() : "0" + seconds);
            if (durationField1 == 0)
            {
                countDownTimerField1.Stop();
                btnPaymentField1.Visible = true;
                tbTimerField1.BackColor = Color.Green;
                frmPayment frmPayment = new frmPayment();
                frmPayment.Show();
                // to show data of bill
            }
        }
        private void countDownTimerField2_Tick(object sender, EventArgs e)
        {
            durationField2--;
            int hours, minutes, seconds;
            hours = durationField2 / 3600;
            minutes = (durationField2 % 3600) / 60;
            seconds = (durationField2 % 3600) % 60;
            tbTimerField2.Text = (hours >= 10 ? hours.ToString() : "0" + hours) + ":" +
                (minutes >= 10 ? minutes.ToString() : "0" + minutes) + ":" +
                    (seconds >= 10 ? seconds.ToString() : "0" + seconds);
            if (durationField2 == 0)
            {
                countDownTimerField2.Stop();
                btnPaymentField2.Visible = true;
                tbTimerField2.BackColor = Color.Green;
                frmPayment frmPayment = new frmPayment();
                frmPayment.Show();
                // to show data of bill
            }
        }

        private int changeStringIntoIntTime(String time) // to change string of time such hh:mm:ss to seconds with int type
        {
            string[] result;// result after split
            int seconds = 0;
            // Split a string delimited by characters.
            result = time.Split(':');
            try
            {
                seconds = int.Parse(result[0]) * 3600 + int.Parse(result[1]) * 60 + int.Parse(result[2]);
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi");
                return 0;
            }
            return seconds;
        }

        private void frmRingTheBell_Load(object sender, EventArgs e)
        {
            field1DTO = new fieldDTO();
            field2DTO = new fieldDTO();
            fieldBUS = new fieldBUS();
            field1DTO.MaSanBanh = "1";
            field2DTO.MaSanBanh = "2";
            tbTimerField1.BackColor = Color.Green;
            tbTimerField2.BackColor = Color.Green;
            loadInfo();

        }
        private void loadInfo() // to load information for field including customer name, duration of field, field status
        {
            //DateTime.Now.ToString("HH:mm") : to get current time 
            List<fieldDTO> lstFields = fieldBUS.selectedFields();
            if (lstFields != null)
            {
                foreach (fieldDTO fields in lstFields)
                {
                    displayInfoField(fields);
                }
            }
            else return;
        }
        // to use 

        private void btnPaymentField_Click(object sender, EventArgs e)
        {
            frmPayment frmPayment = new frmPayment();
            frmPayment.Show();
            /*get data to form payment here*/
        }

        /* to display information about fields
        */
        private void displayInfoField(fieldDTO field)
        {
            string bookingDate = field.NgayDatSan.ToShortDateString();
            string bookingTime = field.GioDatSan.ToString("HH:mm:ss");
            if (field1DTO.MaSanBanh == field.MaSanBanh)
            {
                if ("20:00:00" == bookingTime && "3/3/2019" == bookingDate)
                {
                    tbCustomerField1.Text = field.tenKH;
                    tbTimerField1.Text = field.ThoiLuongDatSan.ToString("HH:mm:ss");
                }
            }

            if (field2DTO.MaSanBanh == field.MaSanBanh)
            {
                if ("20:00:00" == bookingTime && "3/3/2019" == bookingDate)
                {
                    tbCustomerField2.Text = field.tenKH;
                    tbTimerField2.Text = field.ThoiLuongDatSan.ToString("HH:mm:ss");
                }
            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
