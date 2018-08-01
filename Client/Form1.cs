using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelf_Click(object sender, EventArgs e)
        {
            int card = int.Parse(txtCardno.Text);
            int cvv = int.Parse(txtCvv.Text);
            int amount = int.Parse(txtTransact.Text);
           
            try
            {
                
                ServiceReference1.icard cc = new ServiceReference1.icardClient();
                var cardVal = cc.cardvalidate(card);
                var cvvVal = cc.cvvValidate(cvv);
                var amt = cc.transaction(amount);
              
                MessageBox.Show("Transaction succesful");
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
