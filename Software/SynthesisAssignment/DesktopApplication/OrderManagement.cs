using DataLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication
{
    public partial class OrderManagement : Form
    {
        private LoginForm loginForm;
        public OrderRepository OrderRepository = new OrderRepository();
        public OrderManager orderManager;
        private User user;
        public OrderManagement(LoginForm loginForm, User user)
        {
            orderManager = new OrderManager(OrderRepository);
            this.loginForm = loginForm;
            this.user = user;
            InitializeComponent();
            dgvOrders.DataSource = orderManager.GetAllOrders();
            cbxStatus.DataSource = Enum.GetValues(typeof(EnumOrderStatus));
            lblOrderManagerUser.Text = "Welcome, " + user.UserName + "!";
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            orderManager = new OrderManager(OrderRepository);
            int index = dgvOrders.CurrentRow.Index;
            int orderID;
            DataGridViewRow row = dgvOrders.Rows[index];
            orderID = Convert.ToInt32(row.Cells[0].Value.ToString());
            string status = cbxStatus.Text;
            if(orderManager.UpdateOrderStatus(orderID, status) == true)
            {
                dgvOrders.DataSource = orderManager.GetAllOrders();
                MessageBox.Show("Status changed successfully");
            }
            else
            {
                MessageBox.Show("Please select a status");
            }
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            orderManager = new OrderManager(OrderRepository);
            int index = dgvOrders.CurrentRow.Index;
            int orderID;
            DataGridViewRow row = dgvOrders.Rows[index];
            orderID = Convert.ToInt32(row.Cells[0].Value.ToString());
            Order order = orderManager.GetOrder(orderID);
            List<OrderProduct> products = orderManager.GetOrderProducts(orderID);
            dgvProducts.DataSource = products;
            dgvProducts.Columns[1].Visible = false;

           
        }

        private void OrderManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
