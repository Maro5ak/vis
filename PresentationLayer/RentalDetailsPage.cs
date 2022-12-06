using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer {
    public partial class RentalDetailsPage : Form {
        Rental current;
        int sumPrice = 0;
        int action = 0;
        int currentId;
        public RentalDetailsPage(int id) {
            InitializeComponent();
            current = Rental.GetRental(id);
            currentId = id;
            rentalNameLabel.Text = Utils.Concat(current.Instrument.Manufacturer, current.Instrument.Name);
            rentalDateLabel.Text = current.StartTime.ToString();
            rentalEndDateLabel.Text = current.EndTime.ToString();
            penaltyLabel.Visible = false;
            if (current.Penalty) {
                rentalEndDateLabel.ForeColor = Color.FromArgb(192, 0, 0);
                penaltyLabel.Visible = true;
                penaltyLabel.Text = $"Penalty: ${current.CalculatePenaltyPrice()}";
            }

            priceLabel.Text = $"Deposit return: ${current.Instrument.Deposit}";

            int price = current.GetRentalUpdatePrice();
            if (price < 0)
                priceSumLabel.Text = $"To be returned: ${sumPrice + price}";

            else
                priceSumLabel.Text = $"Sum: ${sumPrice + price}";
        }

        private void goBtn_Click(object sender, EventArgs e) {
            if(action == 0) {
                current.ReturnRental();
            }
            else {
                current.ExtendReturnTime(currentId);
            }

            SceneManager.ChangeScene(this, new RentalsPage());
        }
        private void actionCheckBox_ItemCheck(object sender, ItemCheckEventArgs e) {
            int priceChange = 0;
            for (int i = 0; i < actionCheckBox.Items.Count; i++)
                if (i != e.Index) actionCheckBox.SetItemChecked(i, false);
            for (int i = 0; i < actionCheckBox.Items.Count; i++) {
                if (i == e.Index && i == 0) {
                    actionCheckBox.Text = $"Action | Extend";
                    priceChange = current.Instrument.PriceRent;
                    if (!current.CheckPenaltyAfterUpdate()) {
                        rentalEndDateLabel.ForeColor = Color.White;
                        penaltyLabel.Visible = false;
                        
                    }
                    action = 1;
                    break;
                }
                else if (i == e.Index && i == 1) {
                    actionCheckBox.Text = $"Action | Return";
                    action = 0;
                }
            }
            if (sumPrice + priceChange < 0) 
                priceSumLabel.Text = $"To be returned: ${sumPrice + priceChange}";

            else
                priceSumLabel.Text = $"Sum: ${sumPrice + priceChange}";
        }

        private void goBackBtn_Click(object sender, EventArgs e) {
            SceneManager.ChangeScene(this, new RentalsPage());
        }
    }
}
