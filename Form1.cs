using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bill_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtamount.KeyPress += new KeyPressEventHandler(txtamount_KeyPress);
            txtbill.KeyPress += new KeyPressEventHandler(txtbill_KeyPress);
            txtname.KeyPress += new KeyPressEventHandler(txtname_KeyPress);
            txtparticular.KeyPress += new KeyPressEventHandler(txtparticular_KeyPress);
            
        }
        double total = 0.0d;
        int i;

        private void BILL_Click(object sender, EventArgs e)
        {

        }

        private void txtbill_TextChanged(object sender, EventArgs e)
        {

        }

        private void DATE_Click(object sender, EventArgs e)
        {

        }

        private void txtdate_ValueChanged(object sender, EventArgs e)
        {

        }
           
        private void NAME_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TYPE_Click(object sender, EventArgs e)
        {

        }

        private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void STATUS_Click(object sender, EventArgs e)
        {

        }

        private void cbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WING_Click(object sender, EventArgs e)
        {

        }

        private void cbwing_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FLATNO_Click(object sender, EventArgs e)
        {

        }

        private void txtflat_TextChanged(object sender, EventArgs e)
        {

        }

        private void PARTICULAR_Click(object sender, EventArgs e)
        {

        }

        private void txtparticular_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AMOUNT_Click(object sender, EventArgs e)
        {

        }

        private void txtamount_TextChanged(object sender, EventArgs e)
        {
          
        }

       
           
            
      

      

        private void TOTAL_Click(object sender, EventArgs e)
        {
           
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

      

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnitems_Click_2(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtparticular.Text, txtamount.Text);
            txtparticular.Clear();
            txtamount.Clear();
        }

        private void btncalculate_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i<dataGridView1.Rows.Count-1; i++)
            {
                total += Convert.ToInt16(dataGridView1.Rows[i].Cells["ADD"].Value.ToString());
            }
            txttotal.Text = total.ToString();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))//The  character represents a backspace
            {
                e.Handled = true; //Do not reject the input
                MessageBox.Show("Please Enter a Valid Number");
            }
                
            
           /*  if (e.KeyChar >= '0' && e.KeyChar <= '9') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
                
            }
            else
            {
                e.Handled = true; //Reject the input
                MessageBox.Show("Please Enter a Valid Number");
            }*/
        }

        private void txtbill_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '8') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input

            }
            else
            {
                e.Handled = true; //Reject the input
                MessageBox.Show("Please Enter a Valid Number");
            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))//The  character represents a backspace
            {
                e.Handled = true; //Do not reject the input
                MessageBox.Show("Please Enter a Propername");
            }
         /*  else
            {
                e.Handled = false; //Reject the input
                
            }*/
        }

        private void txtparticular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))//The  character represents a backspace
            {
                e.Handled = true; //Do not reject the input
                MessageBox.Show("Please Enter a Propername");
            }
        }

       private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells[5].Value.ToString() =="1")
                {
                    row.DefaultCellStyle.BackColor = Color.Black;
                }
                else if(row.Cells[5].Value.ToString() =="2")
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }*/

        }

}
}

